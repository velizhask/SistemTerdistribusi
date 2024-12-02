
namespace client1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPortS = new System.Windows.Forms.TextBox();
            this.txtIPS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPortC = new System.Windows.Forms.TextBox();
            this.txtIPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtPesan = new System.Windows.Forms.TextBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.txtPortS);
            this.groupBox1.Controls.Add(this.txtIPS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // txtPortS
            // 
            this.txtPortS.Location = new System.Drawing.Point(106, 77);
            this.txtPortS.Name = "txtPortS";
            this.txtPortS.Size = new System.Drawing.Size(230, 22);
            this.txtPortS.TabIndex = 3;
            // 
            // txtIPS
            // 
            this.txtIPS.Location = new System.Drawing.Point(106, 34);
            this.txtIPS.Name = "txtIPS";
            this.txtIPS.Size = new System.Drawing.Size(230, 22);
            this.txtIPS.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.txtPortC);
            this.groupBox2.Controls.Add(this.txtIPC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(32, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // txtPortC
            // 
            this.txtPortC.Location = new System.Drawing.Point(106, 74);
            this.txtPortC.Name = "txtPortC";
            this.txtPortC.Size = new System.Drawing.Size(230, 22);
            this.txtPortC.TabIndex = 5;
            // 
            // txtIPC
            // 
            this.txtIPC.Location = new System.Drawing.Point(106, 32);
            this.txtIPC.Name = "txtIPC";
            this.txtIPC.Size = new System.Drawing.Size(230, 22);
            this.txtIPC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStart.Location = new System.Drawing.Point(258, 164);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 51);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START SERVER";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnect.Location = new System.Drawing.Point(258, 379);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(137, 51);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(723, 467);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(137, 51);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtPesan
            // 
            this.txtPesan.Location = new System.Drawing.Point(32, 483);
            this.txtPesan.Name = "txtPesan";
            this.txtPesan.Size = new System.Drawing.Size(640, 22);
            this.txtPesan.TabIndex = 5;
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(428, 35);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(457, 22);
            this.txtChat.TabIndex = 6;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(921, 563);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.txtPesan);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHAT APPLICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortS;
        private System.Windows.Forms.TextBox txtIPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPortC;
        private System.Windows.Forms.TextBox txtIPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtPesan;
        private System.Windows.Forms.TextBox txtChat;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

