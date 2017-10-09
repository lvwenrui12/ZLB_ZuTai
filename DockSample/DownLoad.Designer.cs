namespace ZLB_Zutai
{
    partial class DownLoad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.txtSendCmd = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.btnOpenCom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.comStopBit = new System.Windows.Forms.ComboBox();
            this.comDataBit = new System.Windows.Forms.ComboBox();
            this.comBaudRate = new System.Windows.Forms.ComboBox();
            this.comPortName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "发送的指令";
            // 
            // txtSendCmd
            // 
            this.txtSendCmd.Location = new System.Drawing.Point(21, 151);
            this.txtSendCmd.Multiline = true;
            this.txtSendCmd.Name = "txtSendCmd";
            this.txtSendCmd.Size = new System.Drawing.Size(377, 78);
            this.txtSendCmd.TabIndex = 22;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(21, 282);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(377, 93);
            this.txtReceive.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "接收结果";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Enabled = false;
            this.btnDownLoad.Location = new System.Drawing.Point(414, 143);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(75, 34);
            this.btnDownLoad.TabIndex = 19;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            // 
            // btnOpenCom
            // 
            this.btnOpenCom.Location = new System.Drawing.Point(414, 67);
            this.btnOpenCom.Name = "btnOpenCom";
            this.btnOpenCom.Size = new System.Drawing.Size(79, 34);
            this.btnOpenCom.TabIndex = 18;
            this.btnOpenCom.Text = "打开端口";
            this.btnOpenCom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comParity);
            this.groupBox1.Controls.Add(this.comStopBit);
            this.groupBox1.Controls.Add(this.comDataBit);
            this.groupBox1.Controls.Add(this.comBaudRate);
            this.groupBox1.Controls.Add(this.comPortName);
            this.groupBox1.Location = new System.Drawing.Point(21, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "端口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "奇偶校验";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "停止位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "端口选择";
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comParity.Location = new System.Drawing.Point(305, 55);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(57, 20);
            this.comParity.TabIndex = 0;
            this.comParity.Text = "Even";
            // 
            // comStopBit
            // 
            this.comStopBit.FormattingEnabled = true;
            this.comStopBit.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comStopBit.Location = new System.Drawing.Point(232, 55);
            this.comStopBit.Name = "comStopBit";
            this.comStopBit.Size = new System.Drawing.Size(57, 20);
            this.comStopBit.TabIndex = 0;
            this.comStopBit.Text = "1";
            // 
            // comDataBit
            // 
            this.comDataBit.FormattingEnabled = true;
            this.comDataBit.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comDataBit.Location = new System.Drawing.Point(164, 55);
            this.comDataBit.Name = "comDataBit";
            this.comDataBit.Size = new System.Drawing.Size(57, 20);
            this.comDataBit.TabIndex = 0;
            this.comDataBit.Text = "8";
            // 
            // comBaudRate
            // 
            this.comBaudRate.AutoCompleteCustomSource.AddRange(new string[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115200"});
            this.comBaudRate.FormattingEnabled = true;
            this.comBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.comBaudRate.Location = new System.Drawing.Point(94, 55);
            this.comBaudRate.Name = "comBaudRate";
            this.comBaudRate.Size = new System.Drawing.Size(57, 20);
            this.comBaudRate.TabIndex = 0;
            this.comBaudRate.Text = "9600";
            // 
            // comPortName
            // 
            this.comPortName.FormattingEnabled = true;
            this.comPortName.Location = new System.Drawing.Point(16, 55);
            this.comPortName.Name = "comPortName";
            this.comPortName.Size = new System.Drawing.Size(57, 20);
            this.comPortName.TabIndex = 0;
            // 
            // DownLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 385);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSendCmd);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDownLoad);
            this.Controls.Add(this.btnOpenCom);
            this.Controls.Add(this.groupBox1);
            this.Name = "DownLoad";
            this.Text = "DownLoad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSendCmd;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDownLoad;
        private System.Windows.Forms.Button btnOpenCom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.ComboBox comStopBit;
        private System.Windows.Forms.ComboBox comDataBit;
        private System.Windows.Forms.ComboBox comBaudRate;
        private System.Windows.Forms.ComboBox comPortName;
    }
}