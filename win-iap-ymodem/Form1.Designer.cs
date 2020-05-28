namespace win_iap_ymodem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Port = new System.Windows.Forms.Button();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Bps = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.cbx_Port = new System.Windows.Forms.ComboBox();
            this.cbx_Baud = new System.Windows.Forms.ComboBox();
            this.txb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txb_send = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tbx_show = new System.Windows.Forms.TextBox();
            this.btn_Erase = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_RunApp = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_run_bootloader = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_file_crc32 = new System.Windows.Forms.TextBox();
            this.text_file_len = new System.Windows.Forms.TextBox();
            this.cbx_PageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_progress_value = new System.Windows.Forms.TextBox();
            this.up_threshold_1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.down_threshold_1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.switch_state_1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.temper_state_1 = new System.Windows.Forms.TextBox();
            this.temper_state_2 = new System.Windows.Forms.TextBox();
            this.switch_state_2 = new System.Windows.Forms.TextBox();
            this.down_threshold_2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.up_threshold_2 = new System.Windows.Forms.TextBox();
            this.temper_state_3 = new System.Windows.Forms.TextBox();
            this.switch_state_3 = new System.Windows.Forms.TextBox();
            this.down_threshold_3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.up_threshold_3 = new System.Windows.Forms.TextBox();
            this.temper_state_4 = new System.Windows.Forms.TextBox();
            this.switch_state_4 = new System.Windows.Forms.TextBox();
            this.down_threshold_4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.up_threshold_4 = new System.Windows.Forms.TextBox();
            this.temper_state_5 = new System.Windows.Forms.TextBox();
            this.switch_state_5 = new System.Windows.Forms.TextBox();
            this.down_threshold_5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.up_threshold_5 = new System.Windows.Forms.TextBox();
            this.temper_state_6 = new System.Windows.Forms.TextBox();
            this.switch_state_6 = new System.Windows.Forms.TextBox();
            this.down_threshold_6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.up_threshold_6 = new System.Windows.Forms.TextBox();
            this.temper_state_7 = new System.Windows.Forms.TextBox();
            this.switch_state_7 = new System.Windows.Forms.TextBox();
            this.down_threshold_7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.up_threshold_7 = new System.Windows.Forms.TextBox();
            this.temper_state_8 = new System.Windows.Forms.TextBox();
            this.switch_state_8 = new System.Windows.Forms.TextBox();
            this.down_threshold_8 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.up_threshold_8 = new System.Windows.Forms.TextBox();
            this.query_config = new System.Windows.Forms.Button();
            this.channel_number = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.up_threshold = new System.Windows.Forms.TextBox();
            this.down_threshold = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.switch_state = new System.Windows.Forms.ComboBox();
            this.set = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Port
            // 
            this.btn_Port.Location = new System.Drawing.Point(22, 120);
            this.btn_Port.Name = "btn_Port";
            this.btn_Port.Size = new System.Drawing.Size(155, 32);
            this.btn_Port.TabIndex = 0;
            this.btn_Port.Text = "打开";
            this.btn_Port.UseVisualStyleBackColor = true;
            this.btn_Port.Click += new System.EventHandler(this.btn_Port_Click);
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(20, 41);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(53, 12);
            this.lbl_Port.TabIndex = 1;
            this.lbl_Port.Text = "串口号：";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar1.Location = new System.Drawing.Point(12, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(715, 22);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "bin文件(*.bin)|*.bin|hex文件(*.hex)|*.hex";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lbl_Bps
            // 
            this.lbl_Bps.AutoSize = true;
            this.lbl_Bps.Location = new System.Drawing.Point(20, 81);
            this.lbl_Bps.Name = "lbl_Bps";
            this.lbl_Bps.Size = new System.Drawing.Size(53, 12);
            this.lbl_Bps.TabIndex = 3;
            this.lbl_Bps.Text = "波特率：";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(19, 30);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(65, 12);
            this.lbl_Pass.TabIndex = 4;
            this.lbl_Pass.Text = "文件路径：";
            // 
            // cbx_Port
            // 
            this.cbx_Port.FormattingEnabled = true;
            this.cbx_Port.Location = new System.Drawing.Point(79, 38);
            this.cbx_Port.Name = "cbx_Port";
            this.cbx_Port.Size = new System.Drawing.Size(98, 20);
            this.cbx_Port.TabIndex = 5;
            this.cbx_Port.DropDown += new System.EventHandler(this.cbx_Port_DropDown);
            // 
            // cbx_Baud
            // 
            this.cbx_Baud.FormattingEnabled = true;
            this.cbx_Baud.Items.AddRange(new object[] {
            "Custom",
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.cbx_Baud.Location = new System.Drawing.Point(79, 78);
            this.cbx_Baud.Name = "cbx_Baud";
            this.cbx_Baud.Size = new System.Drawing.Size(98, 20);
            this.cbx_Baud.TabIndex = 6;
            // 
            // txb_FilePath
            // 
            this.txb_FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txb_FilePath.Location = new System.Drawing.Point(21, 54);
            this.txb_FilePath.Name = "txb_FilePath";
            this.txb_FilePath.Size = new System.Drawing.Size(155, 21);
            this.txb_FilePath.TabIndex = 7;
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(112, 25);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(64, 23);
            this.btn_SelectFile.TabIndex = 8;
            this.btn_SelectFile.Text = "选择文件";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Port);
            this.groupBox1.Controls.Add(this.lbl_Bps);
            this.groupBox1.Controls.Add(this.lbl_Port);
            this.groupBox1.Controls.Add(this.cbx_Port);
            this.groupBox1.Controls.Add(this.cbx_Baud);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 173);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.txb_send);
            this.groupBox2.Controls.Add(this.btn_Clear);
            this.groupBox2.Controls.Add(this.tbx_show);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 306);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息视窗";
            // 
            // btn_send
            // 
            this.btn_send.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_send.Location = new System.Drawing.Point(548, 279);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 18;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txb_send
            // 
            this.txb_send.BackColor = System.Drawing.SystemColors.Window;
            this.txb_send.Location = new System.Drawing.Point(81, 279);
            this.txb_send.Name = "txb_send";
            this.txb_send.Size = new System.Drawing.Size(461, 21);
            this.txb_send.TabIndex = 17;
            this.txb_send.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(0, 276);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "清除窗口";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tbx_show
            // 
            this.tbx_show.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbx_show.Location = new System.Drawing.Point(1, 20);
            this.tbx_show.Multiline = true;
            this.tbx_show.Name = "tbx_show";
            this.tbx_show.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_show.Size = new System.Drawing.Size(690, 255);
            this.tbx_show.TabIndex = 9;
            this.tbx_show.TextChanged += new System.EventHandler(this.tbx_show_TextChanged);
            this.tbx_show.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_show_KeyPress);
            // 
            // btn_Erase
            // 
            this.btn_Erase.Location = new System.Drawing.Point(638, 336);
            this.btn_Erase.Name = "btn_Erase";
            this.btn_Erase.Size = new System.Drawing.Size(69, 28);
            this.btn_Erase.TabIndex = 12;
            this.btn_Erase.Text = "未用到";
            this.btn_Erase.UseVisualStyleBackColor = true;
            this.btn_Erase.Click += new System.EventHandler(this.btn_Erase_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(230, 336);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(99, 28);
            this.btn_Upload.TabIndex = 13;
            this.btn_Upload.Text = "未用到";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_read_software_version_Click);
            // 
            // btn_RunApp
            // 
            this.btn_RunApp.Location = new System.Drawing.Point(566, 336);
            this.btn_RunApp.Name = "btn_RunApp";
            this.btn_RunApp.Size = new System.Drawing.Size(66, 28);
            this.btn_RunApp.TabIndex = 14;
            this.btn_RunApp.Text = "重启设备";
            this.btn_RunApp.UseVisualStyleBackColor = true;
            this.btn_RunApp.Click += new System.EventHandler(this.btn_RunApp_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Update.Location = new System.Drawing.Point(458, 336);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(98, 28);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "开始更新固件";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_run_bootloader
            // 
            this.btn_run_bootloader.Location = new System.Drawing.Point(335, 336);
            this.btn_run_bootloader.Name = "btn_run_bootloader";
            this.btn_run_bootloader.Size = new System.Drawing.Size(117, 28);
            this.btn_run_bootloader.TabIndex = 16;
            this.btn_run_bootloader.Text = "进入BootLoader";
            this.btn_run_bootloader.UseVisualStyleBackColor = true;
            this.btn_run_bootloader.Click += new System.EventHandler(this.btn_run_bootloader_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.text_file_crc32);
            this.groupBox3.Controls.Add(this.text_file_len);
            this.groupBox3.Controls.Add(this.cbx_PageSize);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_Pass);
            this.groupBox3.Controls.Add(this.btn_SelectFile);
            this.groupBox3.Controls.Add(this.txb_FilePath);
            this.groupBox3.Location = new System.Drawing.Point(13, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 173);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "文件crc32";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "文件长度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_file_crc32
            // 
            this.text_file_crc32.BackColor = System.Drawing.SystemColors.Window;
            this.text_file_crc32.Location = new System.Drawing.Point(67, 108);
            this.text_file_crc32.Name = "text_file_crc32";
            this.text_file_crc32.Size = new System.Drawing.Size(109, 21);
            this.text_file_crc32.TabIndex = 19;
            // 
            // text_file_len
            // 
            this.text_file_len.BackColor = System.Drawing.SystemColors.Window;
            this.text_file_len.Location = new System.Drawing.Point(67, 81);
            this.text_file_len.Name = "text_file_len";
            this.text_file_len.Size = new System.Drawing.Size(109, 21);
            this.text_file_len.TabIndex = 18;
            // 
            // cbx_PageSize
            // 
            this.cbx_PageSize.FormattingEnabled = true;
            this.cbx_PageSize.Items.AddRange(new object[] {
            "1024"});
            this.cbx_PageSize.Location = new System.Drawing.Point(67, 137);
            this.cbx_PageSize.Name = "cbx_PageSize";
            this.cbx_PageSize.Size = new System.Drawing.Size(98, 20);
            this.cbx_PageSize.TabIndex = 10;
            this.cbx_PageSize.SelectedIndexChanged += new System.EventHandler(this.cbx_PageSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "包长度：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_progress_value
            // 
            this.textBox_progress_value.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_progress_value.Location = new System.Drawing.Point(733, 381);
            this.textBox_progress_value.Name = "textBox_progress_value";
            this.textBox_progress_value.Size = new System.Drawing.Size(56, 21);
            this.textBox_progress_value.TabIndex = 20;
            this.textBox_progress_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_progress_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // up_threshold_1
            // 
            this.up_threshold_1.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_1.Location = new System.Drawing.Point(994, 133);
            this.up_threshold_1.Name = "up_threshold_1";
            this.up_threshold_1.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_1.TabIndex = 21;
            this.up_threshold_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "通道一";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "上限阈值";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1058, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "下限阈值";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // down_threshold_1
            // 
            this.down_threshold_1.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_1.Location = new System.Drawing.Point(1060, 133);
            this.down_threshold_1.Name = "down_threshold_1";
            this.down_threshold_1.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_1.TabIndex = 24;
            this.down_threshold_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1128, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "开关状态";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // switch_state_1
            // 
            this.switch_state_1.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_1.Location = new System.Drawing.Point(1130, 133);
            this.switch_state_1.Name = "switch_state_1";
            this.switch_state_1.Size = new System.Drawing.Size(51, 21);
            this.switch_state_1.TabIndex = 26;
            this.switch_state_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1195, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "实时温度";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // temper_state_1
            // 
            this.temper_state_1.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_1.Location = new System.Drawing.Point(1197, 133);
            this.temper_state_1.Name = "temper_state_1";
            this.temper_state_1.Size = new System.Drawing.Size(51, 21);
            this.temper_state_1.TabIndex = 28;
            this.temper_state_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temper_state_1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // temper_state_2
            // 
            this.temper_state_2.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_2.Location = new System.Drawing.Point(1197, 160);
            this.temper_state_2.Name = "temper_state_2";
            this.temper_state_2.Size = new System.Drawing.Size(51, 21);
            this.temper_state_2.TabIndex = 34;
            this.temper_state_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_2
            // 
            this.switch_state_2.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_2.Location = new System.Drawing.Point(1130, 160);
            this.switch_state_2.Name = "switch_state_2";
            this.switch_state_2.Size = new System.Drawing.Size(51, 21);
            this.switch_state_2.TabIndex = 33;
            this.switch_state_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_2
            // 
            this.down_threshold_2.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_2.Location = new System.Drawing.Point(1060, 160);
            this.down_threshold_2.Name = "down_threshold_2";
            this.down_threshold_2.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_2.TabIndex = 32;
            this.down_threshold_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(947, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "通道二";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // up_threshold_2
            // 
            this.up_threshold_2.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_2.Location = new System.Drawing.Point(994, 160);
            this.up_threshold_2.Name = "up_threshold_2";
            this.up_threshold_2.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_2.TabIndex = 30;
            this.up_threshold_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_3
            // 
            this.temper_state_3.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_3.Location = new System.Drawing.Point(1197, 187);
            this.temper_state_3.Name = "temper_state_3";
            this.temper_state_3.Size = new System.Drawing.Size(51, 21);
            this.temper_state_3.TabIndex = 39;
            this.temper_state_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_3
            // 
            this.switch_state_3.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_3.Location = new System.Drawing.Point(1130, 187);
            this.switch_state_3.Name = "switch_state_3";
            this.switch_state_3.Size = new System.Drawing.Size(51, 21);
            this.switch_state_3.TabIndex = 38;
            this.switch_state_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_3
            // 
            this.down_threshold_3.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_3.Location = new System.Drawing.Point(1060, 187);
            this.down_threshold_3.Name = "down_threshold_3";
            this.down_threshold_3.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_3.TabIndex = 37;
            this.down_threshold_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(947, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "通道三";
            // 
            // up_threshold_3
            // 
            this.up_threshold_3.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_3.Location = new System.Drawing.Point(994, 187);
            this.up_threshold_3.Name = "up_threshold_3";
            this.up_threshold_3.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_3.TabIndex = 35;
            this.up_threshold_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_4
            // 
            this.temper_state_4.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_4.Location = new System.Drawing.Point(1197, 214);
            this.temper_state_4.Name = "temper_state_4";
            this.temper_state_4.Size = new System.Drawing.Size(51, 21);
            this.temper_state_4.TabIndex = 44;
            this.temper_state_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_4
            // 
            this.switch_state_4.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_4.Location = new System.Drawing.Point(1130, 214);
            this.switch_state_4.Name = "switch_state_4";
            this.switch_state_4.Size = new System.Drawing.Size(51, 21);
            this.switch_state_4.TabIndex = 43;
            this.switch_state_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_4
            // 
            this.down_threshold_4.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_4.Location = new System.Drawing.Point(1060, 214);
            this.down_threshold_4.Name = "down_threshold_4";
            this.down_threshold_4.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_4.TabIndex = 42;
            this.down_threshold_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(947, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 41;
            this.label11.Text = "通道四";
            // 
            // up_threshold_4
            // 
            this.up_threshold_4.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_4.Location = new System.Drawing.Point(994, 214);
            this.up_threshold_4.Name = "up_threshold_4";
            this.up_threshold_4.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_4.TabIndex = 40;
            this.up_threshold_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_5
            // 
            this.temper_state_5.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_5.Location = new System.Drawing.Point(1197, 241);
            this.temper_state_5.Name = "temper_state_5";
            this.temper_state_5.Size = new System.Drawing.Size(51, 21);
            this.temper_state_5.TabIndex = 49;
            this.temper_state_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_5
            // 
            this.switch_state_5.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_5.Location = new System.Drawing.Point(1130, 241);
            this.switch_state_5.Name = "switch_state_5";
            this.switch_state_5.Size = new System.Drawing.Size(51, 21);
            this.switch_state_5.TabIndex = 48;
            this.switch_state_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_5
            // 
            this.down_threshold_5.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_5.Location = new System.Drawing.Point(1060, 241);
            this.down_threshold_5.Name = "down_threshold_5";
            this.down_threshold_5.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_5.TabIndex = 47;
            this.down_threshold_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(947, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 46;
            this.label12.Text = "通道五";
            // 
            // up_threshold_5
            // 
            this.up_threshold_5.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_5.Location = new System.Drawing.Point(994, 241);
            this.up_threshold_5.Name = "up_threshold_5";
            this.up_threshold_5.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_5.TabIndex = 45;
            this.up_threshold_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_6
            // 
            this.temper_state_6.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_6.Location = new System.Drawing.Point(1197, 268);
            this.temper_state_6.Name = "temper_state_6";
            this.temper_state_6.Size = new System.Drawing.Size(51, 21);
            this.temper_state_6.TabIndex = 54;
            this.temper_state_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_6
            // 
            this.switch_state_6.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_6.Location = new System.Drawing.Point(1130, 268);
            this.switch_state_6.Name = "switch_state_6";
            this.switch_state_6.Size = new System.Drawing.Size(51, 21);
            this.switch_state_6.TabIndex = 53;
            this.switch_state_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_6
            // 
            this.down_threshold_6.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_6.Location = new System.Drawing.Point(1060, 268);
            this.down_threshold_6.Name = "down_threshold_6";
            this.down_threshold_6.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_6.TabIndex = 52;
            this.down_threshold_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(947, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 51;
            this.label13.Text = "通道六";
            // 
            // up_threshold_6
            // 
            this.up_threshold_6.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_6.Location = new System.Drawing.Point(994, 268);
            this.up_threshold_6.Name = "up_threshold_6";
            this.up_threshold_6.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_6.TabIndex = 50;
            this.up_threshold_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_7
            // 
            this.temper_state_7.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_7.Location = new System.Drawing.Point(1197, 295);
            this.temper_state_7.Name = "temper_state_7";
            this.temper_state_7.Size = new System.Drawing.Size(51, 21);
            this.temper_state_7.TabIndex = 59;
            this.temper_state_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_7
            // 
            this.switch_state_7.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_7.Location = new System.Drawing.Point(1130, 295);
            this.switch_state_7.Name = "switch_state_7";
            this.switch_state_7.Size = new System.Drawing.Size(51, 21);
            this.switch_state_7.TabIndex = 58;
            this.switch_state_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_7
            // 
            this.down_threshold_7.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_7.Location = new System.Drawing.Point(1060, 295);
            this.down_threshold_7.Name = "down_threshold_7";
            this.down_threshold_7.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_7.TabIndex = 57;
            this.down_threshold_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(947, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 56;
            this.label14.Text = "通道七";
            // 
            // up_threshold_7
            // 
            this.up_threshold_7.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_7.Location = new System.Drawing.Point(994, 295);
            this.up_threshold_7.Name = "up_threshold_7";
            this.up_threshold_7.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_7.TabIndex = 55;
            this.up_threshold_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // temper_state_8
            // 
            this.temper_state_8.BackColor = System.Drawing.SystemColors.Window;
            this.temper_state_8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.temper_state_8.Location = new System.Drawing.Point(1197, 322);
            this.temper_state_8.Name = "temper_state_8";
            this.temper_state_8.Size = new System.Drawing.Size(51, 21);
            this.temper_state_8.TabIndex = 64;
            this.temper_state_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // switch_state_8
            // 
            this.switch_state_8.BackColor = System.Drawing.SystemColors.Window;
            this.switch_state_8.Location = new System.Drawing.Point(1130, 322);
            this.switch_state_8.Name = "switch_state_8";
            this.switch_state_8.Size = new System.Drawing.Size(51, 21);
            this.switch_state_8.TabIndex = 63;
            this.switch_state_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold_8
            // 
            this.down_threshold_8.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold_8.Location = new System.Drawing.Point(1060, 322);
            this.down_threshold_8.Name = "down_threshold_8";
            this.down_threshold_8.Size = new System.Drawing.Size(51, 21);
            this.down_threshold_8.TabIndex = 62;
            this.down_threshold_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(947, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 61;
            this.label15.Text = "通道八";
            // 
            // up_threshold_8
            // 
            this.up_threshold_8.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold_8.Location = new System.Drawing.Point(994, 322);
            this.up_threshold_8.Name = "up_threshold_8";
            this.up_threshold_8.Size = new System.Drawing.Size(51, 21);
            this.up_threshold_8.TabIndex = 60;
            this.up_threshold_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // query_config
            // 
            this.query_config.Location = new System.Drawing.Point(994, 349);
            this.query_config.Name = "query_config";
            this.query_config.Size = new System.Drawing.Size(254, 28);
            this.query_config.TabIndex = 65;
            this.query_config.Text = "查询配置";
            this.query_config.UseVisualStyleBackColor = true;
            this.query_config.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // channel_number
            // 
            this.channel_number.FormattingEnabled = true;
            this.channel_number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.channel_number.Location = new System.Drawing.Point(984, 71);
            this.channel_number.Name = "channel_number";
            this.channel_number.Size = new System.Drawing.Size(51, 20);
            this.channel_number.TabIndex = 66;
            this.channel_number.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(982, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 67;
            this.label16.Text = "通道编号";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1039, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 69;
            this.label17.Text = "上限阈值";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1096, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 71;
            this.label18.Text = "下限阈值";
            // 
            // up_threshold
            // 
            this.up_threshold.BackColor = System.Drawing.SystemColors.Window;
            this.up_threshold.Location = new System.Drawing.Point(1041, 70);
            this.up_threshold.Name = "up_threshold";
            this.up_threshold.Size = new System.Drawing.Size(51, 21);
            this.up_threshold.TabIndex = 72;
            this.up_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // down_threshold
            // 
            this.down_threshold.BackColor = System.Drawing.SystemColors.Window;
            this.down_threshold.Location = new System.Drawing.Point(1098, 70);
            this.down_threshold.Name = "down_threshold";
            this.down_threshold.Size = new System.Drawing.Size(51, 21);
            this.down_threshold.TabIndex = 73;
            this.down_threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1153, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 75;
            this.label19.Text = "开关状态";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // switch_state
            // 
            this.switch_state.FormattingEnabled = true;
            this.switch_state.Items.AddRange(new object[] {
            "开",
            "关",});
            this.switch_state.Location = new System.Drawing.Point(1155, 71);
            this.switch_state.Name = "switch_state";
            this.switch_state.Size = new System.Drawing.Size(51, 20);
            this.switch_state.TabIndex = 74;
            this.switch_state.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // set
            // 
            this.set.Location = new System.Drawing.Point(1212, 65);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(60, 28);
            this.set.TabIndex = 76;
            this.set.Text = "设置";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(930, 74);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 77;
            this.label20.Text = "参数配置";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1306, 416);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.set);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.switch_state);
            this.Controls.Add(this.down_threshold);
            this.Controls.Add(this.up_threshold);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.channel_number);
            this.Controls.Add(this.query_config);
            this.Controls.Add(this.temper_state_8);
            this.Controls.Add(this.switch_state_8);
            this.Controls.Add(this.down_threshold_8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.up_threshold_8);
            this.Controls.Add(this.temper_state_7);
            this.Controls.Add(this.switch_state_7);
            this.Controls.Add(this.down_threshold_7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.up_threshold_7);
            this.Controls.Add(this.temper_state_6);
            this.Controls.Add(this.switch_state_6);
            this.Controls.Add(this.down_threshold_6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.up_threshold_6);
            this.Controls.Add(this.temper_state_5);
            this.Controls.Add(this.switch_state_5);
            this.Controls.Add(this.down_threshold_5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.up_threshold_5);
            this.Controls.Add(this.temper_state_4);
            this.Controls.Add(this.switch_state_4);
            this.Controls.Add(this.down_threshold_4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.up_threshold_4);
            this.Controls.Add(this.temper_state_3);
            this.Controls.Add(this.switch_state_3);
            this.Controls.Add(this.down_threshold_3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.up_threshold_3);
            this.Controls.Add(this.temper_state_2);
            this.Controls.Add(this.switch_state_2);
            this.Controls.Add(this.down_threshold_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.up_threshold_2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.temper_state_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.switch_state_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.down_threshold_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.up_threshold_1);
            this.Controls.Add(this.textBox_progress_value);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_run_bootloader);
            this.Controls.Add(this.btn_RunApp);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Erase);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "温度检测设备参数配置工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Port;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_Bps;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.ComboBox cbx_Port;
        private System.Windows.Forms.ComboBox cbx_Baud;
        private System.Windows.Forms.TextBox txb_FilePath;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Erase;
        private System.Windows.Forms.Button btn_RunApp;
        private System.Windows.Forms.TextBox tbx_show;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_run_bootloader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbx_PageSize;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txb_send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_file_crc32;
        private System.Windows.Forms.TextBox text_file_len;
        private System.Windows.Forms.TextBox textBox_progress_value;
        private System.Windows.Forms.TextBox up_threshold_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox down_threshold_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox switch_state_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox temper_state_1;
        private System.Windows.Forms.TextBox temper_state_2;
        private System.Windows.Forms.TextBox switch_state_2;
        private System.Windows.Forms.TextBox down_threshold_2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox up_threshold_2;
        private System.Windows.Forms.TextBox temper_state_3;
        private System.Windows.Forms.TextBox switch_state_3;
        private System.Windows.Forms.TextBox down_threshold_3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox up_threshold_3;
        private System.Windows.Forms.TextBox temper_state_4;
        private System.Windows.Forms.TextBox switch_state_4;
        private System.Windows.Forms.TextBox down_threshold_4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox up_threshold_4;
        private System.Windows.Forms.TextBox temper_state_5;
        private System.Windows.Forms.TextBox switch_state_5;
        private System.Windows.Forms.TextBox down_threshold_5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox up_threshold_5;
        private System.Windows.Forms.TextBox temper_state_6;
        private System.Windows.Forms.TextBox switch_state_6;
        private System.Windows.Forms.TextBox down_threshold_6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox up_threshold_6;
        private System.Windows.Forms.TextBox temper_state_7;
        private System.Windows.Forms.TextBox switch_state_7;
        private System.Windows.Forms.TextBox down_threshold_7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox up_threshold_7;
        private System.Windows.Forms.TextBox temper_state_8;
        private System.Windows.Forms.TextBox switch_state_8;
        private System.Windows.Forms.TextBox down_threshold_8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox up_threshold_8;
        private System.Windows.Forms.Button query_config;
        private System.Windows.Forms.ComboBox channel_number;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox up_threshold;
        private System.Windows.Forms.TextBox down_threshold;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox switch_state;
        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Label label20;
    }
}

