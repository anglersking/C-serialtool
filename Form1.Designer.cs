
namespace Anglersking_Uart_Tools
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.chkRecHex = new System.Windows.Forms.CheckBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.rbResponse = new System.Windows.Forms.RadioButton();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.btnReceive = new System.Windows.Forms.Button();
            this.rbAck = new System.Windows.Forms.RadioButton();
            this.chkSendHex = new System.Windows.Forms.CheckBox();
            this.btn_openport = new System.Windows.Forms.Button();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.cmbStopBits);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbParity);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Controls.Add(this.btn_openport);
            this.groupBox1.Controls.Add(this.cmbBaudRate);
            this.groupBox1.Controls.Add(this.cmbDataBits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 266);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "串口选择";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "检测串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "COM1"});
            this.cmbPort.Location = new System.Drawing.Point(83, 21);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 20);
            this.cmbPort.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSend);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.chkRecHex);
            this.groupBox2.Controls.Add(this.rbResponse);
            this.groupBox2.Controls.Add(this.txtReceive);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.rbAck);
            this.groupBox2.Controls.Add(this.chkSendHex);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 336);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通讯";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Items.AddRange(new object[] {
            "one"});
            this.cmbStopBits.Location = new System.Drawing.Point(83, 138);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 20);
            this.cmbStopBits.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(53, 60);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(324, 68);
            this.txtSend.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(302, 31);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // chkRecHex
            // 
            this.chkRecHex.AutoSize = true;
            this.chkRecHex.Location = new System.Drawing.Point(66, 152);
            this.chkRecHex.Name = "chkRecHex";
            this.chkRecHex.Size = new System.Drawing.Size(66, 16);
            this.chkRecHex.TabIndex = 15;
            this.chkRecHex.Text = "HEX显示";
            this.chkRecHex.UseVisualStyleBackColor = true;
            this.chkRecHex.CheckedChanged += new System.EventHandler(this.chkRecHex_CheckedChanged);
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None"});
            this.cmbParity.Location = new System.Drawing.Point(83, 71);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 20);
            this.cmbParity.TabIndex = 7;
            // 
            // rbResponse
            // 
            this.rbResponse.AutoSize = true;
            this.rbResponse.Location = new System.Drawing.Point(225, 152);
            this.rbResponse.Name = "rbResponse";
            this.rbResponse.Size = new System.Drawing.Size(71, 16);
            this.rbResponse.TabIndex = 17;
            this.rbResponse.TabStop = true;
            this.rbResponse.Text = "响应模式";
            this.rbResponse.UseVisualStyleBackColor = true;
            this.rbResponse.CheckedChanged += new System.EventHandler(this.rbResponse_CheckedChanged);
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Items.AddRange(new object[] {
            "8"});
            this.cmbDataBits.Location = new System.Drawing.Point(296, 71);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 20);
            this.cmbDataBits.TabIndex = 4;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(54, 210);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(323, 120);
            this.txtReceive.TabIndex = 16;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(302, 148);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 11;
            this.btnReceive.Text = "接收";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // rbAck
            // 
            this.rbAck.AutoSize = true;
            this.rbAck.Location = new System.Drawing.Point(138, 152);
            this.rbAck.Name = "rbAck";
            this.rbAck.Size = new System.Drawing.Size(71, 16);
            this.rbAck.TabIndex = 12;
            this.rbAck.TabStop = true;
            this.rbAck.Text = "应答模式";
            this.rbAck.UseVisualStyleBackColor = true;
            // 
            // chkSendHex
            // 
            this.chkSendHex.AutoSize = true;
            this.chkSendHex.Location = new System.Drawing.Point(187, 35);
            this.chkSendHex.Name = "chkSendHex";
            this.chkSendHex.Size = new System.Drawing.Size(66, 16);
            this.chkSendHex.TabIndex = 13;
            this.chkSendHex.Text = "HEX发送";
            this.chkSendHex.UseVisualStyleBackColor = true;
            this.chkSendHex.CheckedChanged += new System.EventHandler(this.chkSendHex_CheckedChanged);
            // 
            // btn_openport
            // 
            this.btn_openport.Location = new System.Drawing.Point(342, 134);
            this.btn_openport.Name = "btn_openport";
            this.btn_openport.Size = new System.Drawing.Size(75, 23);
            this.btn_openport.TabIndex = 24;
            this.btn_openport.Text = "打开串口";
            this.btn_openport.UseVisualStyleBackColor = true;
            this.btn_openport.Click += new System.EventHandler(this.btn_openport_Click);
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600"});
            this.cmbBaudRate.Location = new System.Drawing.Point(296, 20);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 20);
            this.cmbBaudRate.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "波特率设置";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStatus.Location = new System.Drawing.Point(62, 224);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(57, 12);
            this.txtStatus.TabIndex = 26;
            this.txtStatus.Text = "执行状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "奇偶校验位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "停止位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "数据位";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkRecHex;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.RadioButton rbResponse;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.RadioButton rbAck;
        private System.Windows.Forms.CheckBox chkSendHex;
        private System.Windows.Forms.Button btn_openport;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

