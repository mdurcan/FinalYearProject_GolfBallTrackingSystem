namespace CreateVideo
{
    partial class VideoCreate
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
            this.NextFrame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextFrame
            // 
            this.NextFrame.Location = new System.Drawing.Point(66, 61);
            this.NextFrame.Name = "NextFrame";
            this.NextFrame.Size = new System.Drawing.Size(283, 124);
            this.NextFrame.TabIndex = 0;
            this.NextFrame.Text = "Select next frame";
            this.NextFrame.UseVisualStyleBackColor = true;
            this.NextFrame.Click += new System.EventHandler(this.NextFrame_Click);
            // 
            // VideoCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.NextFrame);
            this.Name = "VideoCreate";
            this.Text = "Create Video";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextFrame;
    }
}

