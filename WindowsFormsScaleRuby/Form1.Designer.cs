namespace WindowsFormsScaleRuby
{
    partial class Form1
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
            this.btnTestComunication = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.txtNdest = new System.Windows.Forms.TextBox();
            this.txtInireg = new System.Windows.Forms.TextBox();
            this.txtFireg = new System.Windows.Forms.TextBox();
            this.txtBuf = new System.Windows.Forms.TextBox();
            this.txtBorrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.checkOpenConnection = new System.Windows.Forms.CheckBox();
            this.checkCloseConnection = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnTestComunication
            // 
            this.btnTestComunication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestComunication.Location = new System.Drawing.Point(660, 503);
            this.btnTestComunication.Name = "btnTestComunication";
            this.btnTestComunication.Size = new System.Drawing.Size(110, 38);
            this.btnTestComunication.TabIndex = 0;
            this.btnTestComunication.Text = "Comunicar";
            this.btnTestComunication.UseVisualStyleBackColor = true;
            this.btnTestComunication.Click += new System.EventHandler(this.BtnTestComunication_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 191);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(758, 306);
            this.txtLog.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(12, 38);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(140, 22);
            this.txtDest.TabIndex = 2;
            // 
            // txtNdest
            // 
            this.txtNdest.Location = new System.Drawing.Point(166, 38);
            this.txtNdest.Name = "txtNdest";
            this.txtNdest.Size = new System.Drawing.Size(140, 22);
            this.txtNdest.TabIndex = 3;
            // 
            // txtInireg
            // 
            this.txtInireg.Location = new System.Drawing.Point(320, 38);
            this.txtInireg.Name = "txtInireg";
            this.txtInireg.Size = new System.Drawing.Size(140, 22);
            this.txtInireg.TabIndex = 4;
            // 
            // txtFireg
            // 
            this.txtFireg.Location = new System.Drawing.Point(474, 38);
            this.txtFireg.Name = "txtFireg";
            this.txtFireg.Size = new System.Drawing.Size(140, 22);
            this.txtFireg.TabIndex = 5;
            // 
            // txtBuf
            // 
            this.txtBuf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuf.Location = new System.Drawing.Point(12, 83);
            this.txtBuf.Name = "txtBuf";
            this.txtBuf.Size = new System.Drawing.Size(758, 22);
            this.txtBuf.TabIndex = 6;
            this.txtBuf.Click += new System.EventHandler(this.TxtBuf_Click);
            // 
            // txtBorrado
            // 
            this.txtBorrado.Location = new System.Drawing.Point(628, 38);
            this.txtBorrado.Name = "txtBorrado";
            this.txtBorrado.Size = new System.Drawing.Size(140, 22);
            this.txtBorrado.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "dest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ndest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "inireg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "fireg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "buf";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "borrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "log";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReadFile.Location = new System.Drawing.Point(544, 503);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(110, 38);
            this.btnReadFile.TabIndex = 15;
            this.btnReadFile.Text = "Ler ficheiro";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 131);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(140, 22);
            this.txtIP.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "ip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "porta";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(162, 131);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(140, 22);
            this.txtPort.TabIndex = 18;
            // 
            // checkOpenConnection
            // 
            this.checkOpenConnection.AutoSize = true;
            this.checkOpenConnection.Location = new System.Drawing.Point(320, 131);
            this.checkOpenConnection.Name = "checkOpenConnection";
            this.checkOpenConnection.Size = new System.Drawing.Size(109, 21);
            this.checkOpenConnection.TabIndex = 20;
            this.checkOpenConnection.Text = "Abrir ligação";
            this.checkOpenConnection.UseVisualStyleBackColor = true;
            // 
            // checkCloseConnection
            // 
            this.checkCloseConnection.AutoSize = true;
            this.checkCloseConnection.Location = new System.Drawing.Point(435, 131);
            this.checkCloseConnection.Name = "checkCloseConnection";
            this.checkCloseConnection.Size = new System.Drawing.Size(123, 21);
            this.checkCloseConnection.TabIndex = 21;
            this.checkCloseConnection.Text = "Fechar ligação";
            this.checkCloseConnection.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.checkCloseConnection);
            this.Controls.Add(this.checkOpenConnection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBorrado);
            this.Controls.Add(this.txtBuf);
            this.Controls.Add(this.txtFireg);
            this.Controls.Add(this.txtInireg);
            this.Controls.Add(this.txtNdest);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnTestComunication);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comunicação Ruby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestComunication;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.TextBox txtNdest;
        private System.Windows.Forms.TextBox txtInireg;
        private System.Windows.Forms.TextBox txtFireg;
        private System.Windows.Forms.TextBox txtBuf;
        private System.Windows.Forms.TextBox txtBorrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox checkOpenConnection;
        private System.Windows.Forms.CheckBox checkCloseConnection;
    }
}

