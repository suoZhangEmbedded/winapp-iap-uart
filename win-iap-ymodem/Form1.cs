using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace win_iap_ymodem
{
    public partial class Form1 : Form
    {

        static UInt32[] crc32_Table = new UInt32[256];

        public static void init_table()
        {//初始化CRC32表
            UInt32 i, j;
            UInt32 crc;

            UInt32 value = 0;

            for (i = 0; i < 256; i++)
            {
                crc = i;
                for (j = 0; j < 8; j++)
                {

                    value = crc & 1;

                    if (value>0)
                    {
                        crc = (crc >> 1) ^ 0xEDB88320;
                    }
                    else
                    {
                        crc = crc >> 1;
                    }
                }
                crc32_Table[i] = crc;
            }
        }


        public static uint GetCRC32(byte[] bytes)
        {//crc32实现函数
            UInt32 ret = 0xFFFFFFFF;

            UInt32 i;

            init_table();

            uint iCount = (uint)bytes.Length;

            for (i = 0; i < iCount; i++)
            {
                ret = crc32_Table[((ret & 0xFF) ^ bytes[i])] ^ (ret >> 8);
            }

            ret = ~ret;

            return ret;
        }


        private bool hasOpenPort = false;
        public bool HasOpenPort
        {
            get { return hasOpenPort; }
            set
            {
                hasOpenPort = value;
                if (hasOpenPort && hasSelectBin)
                    openControlBtn();
                else
                    closeControlBtn();
            }
        }
        private bool hasSelectBin = false;
        public bool HasSelectBin
        {
            get { return hasSelectBin; }
            set
            {
                hasSelectBin = value;
                if (hasOpenPort && hasSelectBin)
                    openControlBtn();
                else
                    closeControlBtn();
            }
        }

        public static string filePath = "";
        string sendCmd = "";
        int fsLen = 0;

        UInt32 file_crc32_value = 0;

        /* packet define */
        const byte C = 67;   // capital letter C
        byte STX = 2;  // Start Of Text
        //const byte PACKET_SEQNO_INDEX = 1;
        //const byte PACKET_SEQNO_COMP_INDEX = 2;
        //const byte PACKET_HEADER = 3;
        //const byte PACKET_TRAILER = 2;
        //const byte PACKET_OVERHEAD = 2 + 3;

        const int FILE_NAME_LENGTH = 256;
        const byte FILE_SIZE_LENGTH = 16;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            closeControlBtn();
            EnumComportfromReg(cbx_Port);
            serialPort1.Encoding = Encoding.GetEncoding("gb2312");//串口接收编码GB2312码
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//忽略程序跨越线程运行导致的错误.没有此句将会产生错误
            
            // 初始化 下拉选项值
            cbx_Baud.SelectedIndex = 13;
            cbx_PageSize.SelectedIndex = 0;
            channel_number.SelectedIndex = 0;
            switch_state.SelectedIndex = 0;

            tbx_show.AppendText("注意：打开串口和打开升级文件后，相关按钮才可使用。\r\n");

            // 上下 阈值 默认设置
            up_threshold.AppendText( "120" );
            down_threshold.AppendText("-40");

            textBox_progress_value.Text = "%0";

        }


        /// <summary>
        /// enabled all button
        /// </summary>
        private void openControlBtn()
        {
            btn_Update.Enabled = true;
            btn_Upload.Enabled = true;
            //btn_Erase.Enabled = true;
            btn_run_bootloader.Enabled = true;
            btn_RunApp.Enabled = true;
            btn_send.Enabled = true;
            set.Enabled = true;
            query_config.Enabled = true;
        }


        /// <summary>
        /// disabled all button
        /// </summary>
        private void closeControlBtn()
        {
            btn_Update.Enabled = false;
            btn_Upload.Enabled = false;
            //btn_Erase.Enabled = false;
            btn_run_bootloader.Enabled = false;
            btn_RunApp.Enabled = false;
            btn_send.Enabled = false;
            btn_Erase.Enabled = false;
            set.Enabled = false;
            query_config.Enabled = false;
        }


        /// <summary>
        /// the button for select bin file or hex file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        

        /// <summary>
        /// has been selected the right file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filePath = openFileDialog1.FileName;
            //Get the extension of the file
            string extName = Path.GetExtension(filePath);
            if (extName == ".hex")
            {
                //we shoule convert the hex file to bin file.
                if (HexToBin.convertHexToBin(filePath))
                {
                    tbx_show.AppendText("> 文件转换完成!\r\n");
                }
                else
                {
                    tbx_show.AppendText("> 文件转换失败!\r\n");
                }
            }

            txb_FilePath.Text = filePath;

            HasSelectBin = true;//flag has been select file.

            FileStream fileStream = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
            fsLen = (int)fileStream.Length;

            text_file_len.Text = "0x" + fsLen.ToString("X");

            byte[] file_buff = File.ReadAllBytes(@filePath);

            file_crc32_value = GetCRC32(file_buff);

            text_file_crc32.Text = "0x" + file_crc32_value.ToString("X");
            
            fileStream.Close();

        }


        /// <summary>
        /// get all port and add to cbx_Port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Port_DropDown(object sender, EventArgs e)
        {
            if (!HasOpenPort)
            {
                EnumComportfromReg(cbx_Port);
            }
        }


        /// <summary>
        /// open or close port.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Port_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)//try to close
            {
                try
                {
                    serialPort1.Close();
                    btn_Port.Text = "打开";
                    set.Enabled = false;
                    query_config.Enabled = false;
                    HasOpenPort = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("关闭失败");
                    return;
                }
            }
            else //try to open
            {
                if (cbx_Port.Items.Count == 0)
                    return;
                int baud = int.Parse(cbx_Baud.Text);
                serialPort1.PortName = cbx_Port.Text;
                serialPort1.BaudRate = baud;
                try
                {
                    serialPort1.Open();
                    btn_Port.Text = "关闭";
                    HasOpenPort = true;
                    set.Enabled = true;
                    query_config.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开失败");
                    return;
                }
            }
        }


        /// <summary>
        /// Get the port list from the registry
        /// </summary>
        /// <param name="Combobox"></param>
        private void EnumComportfromReg(ComboBox Combobox)
        {
            Combobox.Items.Clear();
            ///定义注册表子Path
            string strRegPath = @"Hardware\\DeviceMap\\SerialComm";
            ///创建两个RegistryKey类，一个将指向Root Path，另一个将指向子Path
            RegistryKey regRootKey;
            RegistryKey regSubKey;
            ///定义Root指向注册表HKEY_LOCAL_MACHINE节点
            regRootKey = Registry.LocalMachine;
            regSubKey = regRootKey.OpenSubKey(strRegPath);
            if (regSubKey.GetValueNames() == null)
            {
                MessageBox.Show("获取串口设备失败");
                return;
            } 
            string[] strCommList = regSubKey.GetValueNames();
            foreach (string VName in strCommList)
            {
                //向listbox1中添加字符串的名称和数据，数据是从rk对象中的GetValue(it)方法中得来的
                Combobox.Items.Add(regSubKey.GetValue(VName));
            }
            if (Combobox.Items.Count > 0)
            {
                Combobox.SelectedIndex = 0;
            }
            else
            {
                Combobox.Text = "";
            }
            regSubKey.Close();
            regRootKey.Close();
        }



        void byte_printf_hex(byte[] buf, Int32 len)
        {
            Int32 i = 0;

            tbx_show.AppendText(">");

            for (i = 0; i < len; i++)
            {
                tbx_show.AppendText("0x" + buf[i].ToString("X") + " ");
            }

            tbx_show.AppendText("\r\n");

        }

        void config_printf(byte[] byteArray)
        {

            // 0xAA 0x55
            // 0xF0 代表 设置 或者 查询应答

            // 1个字节 开关状态
            // 2个字节 上限阈值
            // 2个字节 下限阈值
            // 2个字节 实时温度值

            // 多通道

            // 0D 0A

            if (byteArray[3] == 0)
                switch_state_1.Text = "关";
            else
                switch_state_1.Text = "开";

            int up_threshold_1_value = byteArray[5] * 256 + byteArray[4];
            int down_threshold_1_value = byteArray[7] * 256 + byteArray[6];
            int real_temper_1_value = byteArray[9] * 256 + byteArray[8];

            Int16 value = (Int16)up_threshold_1_value;
            up_threshold_1.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_1_value;
            down_threshold_1.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_1_value;
            if(real_temper_1_value < 1000 )
                temper_state_1.Text = (value.ToString() + "℃");
            else
                temper_state_1.Text = ("未接入");


            if (byteArray[10] == 0)
                switch_state_2.Text = "关";
            else
                switch_state_2.Text = "开";

            int up_threshold_2_value = byteArray[12] * 256 + byteArray[11];
            int down_threshold_2_value = byteArray[14] * 256 + byteArray[13];
            int real_temper_2_value = byteArray[16] * 256 + byteArray[15];

            value = (Int16)up_threshold_2_value;
            up_threshold_2.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_2_value;
            down_threshold_2.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_2_value;
            if (real_temper_2_value < 1000)
                temper_state_2.Text = (value.ToString() + "℃");
            else
                temper_state_2.Text = ("未接入");


            if (byteArray[17] == 0)
                switch_state_3.Text = "关";
            else
                switch_state_3.Text = "开";

            int up_threshold_3_value = byteArray[19] * 256 + byteArray[18];
            int down_threshold_3_value = byteArray[21] * 256 + byteArray[20];
            int real_temper_3_value = byteArray[23] * 256 + byteArray[22];

            value = (Int16)up_threshold_3_value;
            up_threshold_3.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_3_value;
            down_threshold_3.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_3_value;
            if (real_temper_3_value < 1000)
                temper_state_3.Text = (value.ToString() + "℃");
            else
                temper_state_3.Text = ("未接入");


            if (byteArray[24] == 0)
                switch_state_4.Text = "关";
            else
                switch_state_4.Text = "开";

            int up_threshold_4_value = byteArray[26] * 256 + byteArray[25];
            int down_threshold_4_value = byteArray[28] * 256 + byteArray[27];
            int real_temper_4_value = byteArray[30] * 256 + byteArray[29];

            value = (Int16)up_threshold_4_value;
            up_threshold_4.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_4_value;
            down_threshold_4.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_4_value;
            if (real_temper_4_value < 1000)
                temper_state_4.Text = (value.ToString() + "℃");
            else
                temper_state_4.Text = ("未接入");


            if (byteArray[31] == 0)
                switch_state_5.Text = "关";
            else
                switch_state_5.Text = "开";

            int up_threshold_5_value = byteArray[33] * 256 + byteArray[32];
            int down_threshold_5_value = byteArray[35] * 256 + byteArray[34];
            int real_temper_5_value = byteArray[37] * 256 + byteArray[36];

            value = (Int16)up_threshold_5_value;
            up_threshold_5.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_5_value;
            down_threshold_5.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_5_value;
            if (real_temper_5_value < 1000)
                temper_state_5.Text = (value.ToString() + "℃");
            else
                temper_state_5.Text = ("未接入");

            if (byteArray[38] == 0)
                switch_state_6.Text = "关";
            else
                switch_state_6.Text = "开";

            int up_threshold_6_value = byteArray[40] * 256 + byteArray[39];
            int down_threshold_6_value = byteArray[42] * 256 + byteArray[41];
            int real_temper_6_value = byteArray[44] * 256 + byteArray[43];

            value = (Int16)up_threshold_6_value;
            up_threshold_6.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_6_value;
            down_threshold_6.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_6_value;
            if (real_temper_6_value < 1000)
                temper_state_6.Text = (value.ToString() + "℃");
            else
                temper_state_6.Text = ("未接入");

            if (byteArray[45] == 0)
                switch_state_7.Text = "关";
            else
                switch_state_7.Text = "开";

            int up_threshold_7_value = byteArray[47] * 256 + byteArray[46];
            int down_threshold_7_value = byteArray[49] * 256 + byteArray[48];
            int real_temper_7_value = byteArray[51] * 256 + byteArray[50];

            value = (Int16)up_threshold_7_value;
            up_threshold_7.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_7_value;
            down_threshold_7.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_7_value;
            if (real_temper_7_value < 1000)
                temper_state_7.Text = (value.ToString() + "℃");
            else
                temper_state_7.Text = ("未接入");

            if (byteArray[52] == 0)
                switch_state_8.Text = "关";
            else
                switch_state_8.Text = "开";

            int up_threshold_8_value = byteArray[54] * 256 + byteArray[53];
            int down_threshold_8_value = byteArray[56] * 256 + byteArray[55];
            int real_temper_8_value = byteArray[58] * 256 + byteArray[57];

            value = (Int16)up_threshold_8_value;
            up_threshold_8.Text = (value.ToString() + "℃");
            value = (Int16)down_threshold_8_value;
            down_threshold_8.Text = (value.ToString() + "℃");
            value = (Int16)real_temper_8_value;
            if (real_temper_8_value < 1000)
                temper_state_8.Text = (value.ToString() + "℃");
            else
                temper_state_8.Text = ("未接入");
        }


        /// <summary>
        /// once has date in. we should show it on the txb.(找到了bug的原因，就是有数据来了之后首先主动去读取了一次数据，然后又通过这个服务去被动读取了一次，所以会出现问题。)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///



    private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] byte_buff = new byte[1000];

                int i = 0;
                int len = 0;

                while (true)
                {
                    Thread.Sleep(10);

                    len += serialPort1.Read(byte_buff, len, 1);

                    if ( (byte_buff[len-1] == 0x0a) && (byte_buff[len - 2] == 0x0d) )
                        break;

                    if (i > 300)
                        break;

                    i++;
                }

                if (byte_buff[0] == 0xAA)
                {

                    byte_printf_hex(byte_buff, len);

                    if (byte_buff[2] == 0xF0)
                    {

                        config_printf(byte_buff);

                    }

                }
                else
                {

                    tbx_show.AppendText("非0xAA\r\n");

                    byte_printf_hex(byte_buff, len);

                    string ss = System.Text.Encoding.Default.GetString(byte_buff);

                   // tbx_show.AppendText(ss);
                }


            }
            catch
            {
                 MessageBox.Show("串口出现故障");
            }
        }


        /// <summary>
        /// A thread to update firmware.
        /// </summary>
        private void updateFileThread()
        {


            YmodemUpdateFile(txb_FilePath.Text);

        }


        /// <summary>
        /// upload the firmware when the app is runing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Click(object sender, EventArgs e)
        {

            if ( !File.Exists(@txb_FilePath.Text) || (Path.GetExtension(@txb_FilePath.Text) != ".bin"))
            {
                MessageBox.Show("请选择有效的bin文件", "提示");
                return;
            }


            FileStream file_stream = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
            int file_stream_len = (int)file_stream.Length;

            tbx_show.AppendText("\r\n\r\n文件大小: " + file_stream_len.ToString() +"字节"+ " = = 0x" + file_stream_len.ToString("X") + "\r\n");

            text_file_len.Text = "0x" + file_stream_len.ToString("X");

            byte[] file_buff = File.ReadAllBytes(@filePath);

            file_crc32_value = GetCRC32(file_buff);

            tbx_show.AppendText("文件CRC32: 0x" + file_crc32_value.ToString("X") + "\r\n");

            text_file_crc32.Text = "0x" + file_crc32_value.ToString("X");

            file_stream.Close();

            progressBar1.Value = 0;
            textBox_progress_value.Text = "%0";
            this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);

            serialPort1.ReadTimeout = 3000;
            try
            {
                string rec = serialPort1.ReadTo("C");

                tbx_show.AppendText("\r\n\r\n > 开始传输文件.\r\n");

                Thread UploadThread = new Thread(updateFileThread);

                UploadThread.Start();
            }
            catch
            {
                MessageBox.Show("后台下载失败");
            }
            finally
            {
                this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            }
        }


        /// <summary>
        /// erase all flash when the button has checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Erase_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            this.serialPort1.DataReceived -= new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);

            serialPort1.Write("erase\r\n");
            serialPort1.ReadTimeout = 1000;
            try
            {
                string rec = serialPort1.ReadTo("@");
                rec = serialPort1.ReadTo("@");
                progressBar1.Maximum = Convert.ToInt32(rec);
                tbx_show.AppendText("\r\n\n> 需要擦除 " + rec + " 页:\r\n");
                while (true)
                {
                    rec = serialPort1.ReadTo("@");
                    if (rec != "")
                    {
                        int val = Convert.ToInt32(rec);
                        if (val < progressBar1.Maximum)
                        {
                            progressBar1.Value = val;
                            tbx_show.AppendText("> 正在擦除 " + val + " 页.\r\n");
                        }
                        else
                        {
                            progressBar1.Value = progressBar1.Maximum;
                            tbx_show.AppendText("> 正在擦除 " + val + " 页.\r\n");
                            tbx_show.AppendText("> 擦除完成.\r\n");
                            break;
                        }
                    }
                }
            }
            catch (TimeoutException)
            {
                tbx_show.AppendText("> 响应超时.\r\n");
            }
            finally {
                this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            }
        }


        /// <summary>
        /// upload the app file form stm32 to PC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_read_software_version_Click(object sender, EventArgs e)
        {
            serialPort1.Write("$set_read_software_version");
            tbx_show.AppendText("> $set_read_software_version\r\n");
        }


        /// <summary>
        /// into iap menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_run_bootloader_Click(object sender, EventArgs e)
        {
            serialPort1.Write("$set_run_bootloader");
            tbx_show.AppendText("> $set_run_bootloader\r\n");
        }


        private void btn_RunApp_Click(object sender, EventArgs e)
        {
            serialPort1.Write("$set_reset");
            tbx_show.AppendText("> $set_reset\r\n");
        }

        /// <summary>
        /// reset the stm32 when the button has been checkde.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            serialPort1.Write("reset\r\n");
        }


        /// <summary>
        /// clear tbx_show window when the button has been checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbx_show.Text = "";
        }



        /// <summary>
        /// when user is input the key on the tbx_show, it should be send to stm32.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbx_show_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //tbx_show.AppendText("\r\n" + sendCmd + "\r\n");
                switch (sendCmd)
                {
                    case "update":
                        btn_Update_Click(null, null);
                        break;
                    case "erase":
                        btn_Erase_Click(null, null);
                        break;
                    case "runapp":
                        btn_RunApp_Click(null, null);
                        break;
                    default:
                        serialPort1.Write(sendCmd + "\r\n");
                        break;
                }
                sendCmd = "";
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                if(sendCmd.Length > 0)
                    sendCmd = sendCmd.Substring(0, sendCmd.Length - 1);
            }
            else
            {
                sendCmd += e.KeyChar.ToString();
            }
        }

        private byte getPageHead(string text)
        {
            switch (Convert.ToInt32(text))
            {
                //case 8:
                //    return 0xA1;
                //case 16:
                //    return 0xA2;
                case 32:
                    return 0xA3;
                case 64:
                    return 0xA4;
                case 128:
                    return 0xA5;
                case 256:
                    return 0xA6;
                case 512:
                    return 0xA7;
                case 1024:
                    return 0xA8;
                //case 2048:
                //    return 0xA9;
                default:
                    return 2;
            }
        }
        private bool YmodemUpdateFile(string filePath)
        {
            const byte SOH = 1;  // Start Of Head

            const byte EOT = 4;  // End Of Transmission
            const byte ACK = 6;  // Positive ACknowledgement
            const int crcSize = 2;

            int dataSize = 1024;
            STX = 0xA8;

            /* header: 3 bytes */
            int proprassVal = 0;
            int packetNumber = 0;
            int invertedPacketNumber = 255;
            /* data: 1024 bytes */
            byte[] data = new byte[dataSize];
            /* footer: 2 bytes */
            byte[] CRC = new byte[crcSize];

            /* get the file */
            FileStream fileStream = new FileStream(@filePath, FileMode.Open, FileAccess.Read);
            int packetCnt = (fileStream.Length % dataSize) == 0 ? (int)(fileStream.Length / dataSize) : (int)(fileStream.Length / dataSize) + 1;
            progressBar1.Maximum = packetCnt;

            try
            {
                if (!sendYmodemInitialPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, filePath, fileStream, CRC, crcSize)) return false;

                if (serialPort1.ReadByte() != ACK)
                {
                    Console.WriteLine("first ymodem data, no rx ack.");
                    return false;
                }

                if (serialPort1.ReadByte() != C)
                    return false;

                /* send packets with a cycle until we send the last byte */
                int fileReadCount;
                do
                {
                    /* if this is the last packet fill the remaining bytes with 0 */
                    fileReadCount = fileStream.Read(data, 0, dataSize);
                    if (fileReadCount == 0) break;
                    if (fileReadCount != dataSize)
                        for (int i = fileReadCount; i < dataSize; i++)
                            data[i] = 0;

                    /* calculate packetNumber */
                    packetNumber++;
                    if (packetNumber > 255)
                        packetNumber -= 256;
                    Console.WriteLine(packetNumber);

                    /* calculate invertedPacketNumber */
                    invertedPacketNumber = 255 - packetNumber;

                    /* calculate CRC */
                    Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
                    CRC = crc16Ccitt.ComputeChecksumBytes(data);

                    /* send the packet */
                    if (!sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize)) return false;
                    progressBar1.Value = ++proprassVal;

                    int percentage_value = (100*progressBar1.Value) / progressBar1.Maximum;

                    textBox_progress_value.Text = "%" + percentage_value.ToString("D");

                    /* wait for ACK */
                    if (serialPort1.ReadByte() != ACK)
                    {
                        Console.WriteLine("no rx ACK, Couldn't send a packet.");
                        return false;
                    }
                } while (dataSize == fileReadCount);

                /* send EOT (tell the downloader we are finished) */
                serialPort1.Write(new byte[] { EOT }, 0, 1);
                /* send closing packet */
                packetNumber = 0;
                invertedPacketNumber = 255;
                data = new byte[dataSize];
                CRC = new byte[crcSize];
                if (!sendYmodemClosingPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize)) return false;
                { 
                
                }

                tbx_show.AppendText(" > 文件传输完成。\r\n\r\n");

            }
            catch (TimeoutException)
            {
                progressBar1.Value = 0;
                textBox_progress_value.Text = "%0";
                MessageBox.Show("数据传输超时");
            }
            catch (InvalidOperationException)
            {
                progressBar1.Value = 0;
                textBox_progress_value.Text = "%0";
                MessageBox.Show("端口打开失败");
            }
            catch (IOException)
            {
                progressBar1.Value = 0;
                textBox_progress_value.Text = "%0";
                MessageBox.Show("端口被中断，请检查连接");
            }
            finally
            {
                fileStream.Close();
            }

            Console.WriteLine("File transfer is succesful");
            return true;
        }


        private bool sendYmodemPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            try
            {
                serialPort1.Write(new byte[] { STX }, 0, 1);
                serialPort1.Write(new byte[] { (byte)packetNumber }, 0, 1);
                serialPort1.Write(new byte[] { (byte)invertedPacketNumber }, 0, 1);
                serialPort1.Write(data, 0, dataSize);
                serialPort1.Write(CRC, 0, crcSize);
                return true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("端口打开失败");
                return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("数据传输超时");
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("端口被中断，请检查连接");
                return false;
            }

        }


        private bool sendYmodemInitialPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, string path, FileStream fileStream, byte[] CRC, int crcSize)
        {
            string fileName = System.IO.Path.GetFileName(path);
            string fileSize = fileStream.Length.ToString();


            /* add filename to data */
            int i;
            for (i = 0; i < fileName.Length && (fileName.ToCharArray()[i] != 0); i++)
            {
                data[i] = (byte)fileName.ToCharArray()[i];
            }
            data[i] = 0;

            /* add filesize to data */
            int j;
            for (j = 0; j < fileSize.Length && (fileSize.ToCharArray()[j] != 0); j++)
            {
                data[(i + 1) + j] = (byte)fileSize.ToCharArray()[j];
            }
            data[(i + 1) + j] = 0;

            /* fill the remaining data bytes with 0 */
            for (int k = ((i + 1) + j) + 1; k < dataSize; k++)
            {
                data[k] = 0;
            }

            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            if (!sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize)) return false;
            return true;
        }


        private bool sendYmodemClosingPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            if (!sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize)) return false;

            return true;
        }

        private void cbx_PageSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_show_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (txb_send.Text.Length > 0)
            {
                serialPort1.Write(txb_send.Text);
                tbx_show.AppendText(">"+ txb_send.Text+"\r\n");
            }
            else
                MessageBox.Show("数据无效，无法发送");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer_progress_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 消息头 0xAA 0x55
            // 命令字节 02 代表 查询
            byte[] set_cmd_buff = new byte[3];

            // 消息头 0xAA 0x55
            set_cmd_buff[0] = 0xAA;
            set_cmd_buff[1] = 0x55;

            // 命令字节 02 代表 查询
            set_cmd_buff[2] = 0x02;

            byte_printf_hex(set_cmd_buff, set_cmd_buff.Length);
            serialPort1.Write(set_cmd_buff, 0, set_cmd_buff.Length);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 消息头 0xAA 0x55
            // 命令字节 01 代表 设置
            // 通道编号 
            // 开关状态
            // 上限阈值
            // 下限阈值
            //  0x0D 0x0A
            byte[] set_cmd_buff = new byte[11];

            // 消息头 0xAA 0x55
            set_cmd_buff[0] = 0xAA;
            set_cmd_buff[1] = 0x55;
            set_cmd_buff[9]  = 0x0D;
            set_cmd_buff[10] = 0x0A;

            // 命令字节 01 代表 设置
            set_cmd_buff[2] = 0x01;

            // 1 通道编号 
            set_cmd_buff[3] = (byte)Convert.ToInt32(channel_number.Text);

            // 开关状态
            if( "开"  == switch_state.Text )
                set_cmd_buff[4] = 0x01;
            else
                set_cmd_buff[4] = 0x00;


            Int16 up_threshold_value = 0;
            if(up_threshold.TextLength > 0)
                 up_threshold_value = Convert.ToInt16(up_threshold.Text);
            Int16 down_threshold_value = 0;
            if (down_threshold.TextLength > 0)
                down_threshold_value = Convert.ToInt16(down_threshold.Text);

            if (( up_threshold_value > -60) && (up_threshold_value < 200 ))
            {

                if ((down_threshold_value > -60) && (down_threshold_value < 200))
                {
                    if (up_threshold_value > down_threshold_value )
                    {

                        set_cmd_buff[6] = (byte)(up_threshold_value >> 8);
                        set_cmd_buff[5] = (byte)up_threshold_value;

                        set_cmd_buff[8] = (byte)(down_threshold_value >> 8);
                        set_cmd_buff[7] = (byte)down_threshold_value;

                        byte_printf_hex(set_cmd_buff, set_cmd_buff.Length);

                        serialPort1.Write( set_cmd_buff, 0, set_cmd_buff.Length );
                    }
                    else
                        MessageBox.Show("上限阈值 应该 > 下限阈值");

                }
                else
                        MessageBox.Show("下限阈值 不在 -60℃-200℃ 范围内");
            }
            else
                MessageBox.Show("上限阈值 不在 -60℃-200℃ 范围内");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void temper_state_6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
