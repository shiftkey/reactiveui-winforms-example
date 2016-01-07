namespace WindowsFormsApplication1
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
            this.textBoxMyInput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.statusTray = new System.Windows.Forms.StatusStrip();
            this.statusTrayMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusTray.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(3, 3);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxMyInput.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // statusTray
            // 
            this.statusTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTrayMessage});
            this.statusTray.Location = new System.Drawing.Point(0, 900);
            this.statusTray.Name = "statusTray";
            this.statusTray.Size = new System.Drawing.Size(1507, 30);
            this.statusTray.TabIndex = 2;
            this.statusTray.Text = "statusStrip1";
            // 
            // statusTrayMessage
            // 
            this.statusTrayMessage.Name = "statusTrayMessage";
            this.statusTrayMessage.Size = new System.Drawing.Size(135, 25);
            this.statusTrayMessage.Text = "i am a message";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBoxMyInput);
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1483, 885);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 930);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusTray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusTray.ResumeLayout(false);
            this.statusTray.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusTray;
        private System.Windows.Forms.ToolStripStatusLabel statusTrayMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

