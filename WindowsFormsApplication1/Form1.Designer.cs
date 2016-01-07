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
            this.statusTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMyInput
            // 
            this.textBoxMyInput.Location = new System.Drawing.Point(131, 65);
            this.textBoxMyInput.Name = "textBoxMyInput";
            this.textBoxMyInput.Size = new System.Drawing.Size(100, 26);
            this.textBoxMyInput.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(131, 114);
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
            this.statusTray.Location = new System.Drawing.Point(0, 216);
            this.statusTray.Name = "statusTray";
            this.statusTray.Size = new System.Drawing.Size(278, 28);
            this.statusTray.TabIndex = 2;
            this.statusTray.Text = "statusStrip1";
            // 
            // statusTrayMessage
            // 
            this.statusTrayMessage.Name = "statusTrayMessage";
            this.statusTrayMessage.Size = new System.Drawing.Size(0, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.statusTray);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxMyInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusTray.ResumeLayout(false);
            this.statusTray.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMyInput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.StatusStrip statusTray;
        private System.Windows.Forms.ToolStripStatusLabel statusTrayMessage;
    }
}

