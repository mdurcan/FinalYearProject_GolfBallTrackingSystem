namespace CricleDetection
{
    partial class CricleDetection
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
            this.components = new System.ComponentModel.Container();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.ibProcessed = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrResume = new System.Windows.Forms.Button();
            this.txtXTRadius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Location = new System.Drawing.Point(12, 12);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(640, 480);
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // ibProcessed
            // 
            this.ibProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibProcessed.Location = new System.Drawing.Point(658, 12);
            this.ibProcessed.Name = "ibProcessed";
            this.ibProcessed.Size = new System.Drawing.Size(640, 480);
            this.ibProcessed.TabIndex = 2;
            this.ibProcessed.TabStop = false;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.Location = new System.Drawing.Point(121, 535);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(123, 44);
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.UseVisualStyleBackColor = true;
            this.btnPauseOrResume.Click += new System.EventHandler(this.btnPauseOrResume_Click);
            // 
            // txtXTRadius
            // 
            this.txtXTRadius.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXTRadius.Location = new System.Drawing.Point(590, 498);
            this.txtXTRadius.Multiline = true;
            this.txtXTRadius.Name = "txtXTRadius";
            this.txtXTRadius.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXTRadius.Size = new System.Drawing.Size(708, 148);
            this.txtXTRadius.TabIndex = 4;
            // 
            // CricleDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 658);
            this.Controls.Add(this.txtXTRadius);
            this.Controls.Add(this.btnPauseOrResume);
            this.Controls.Add(this.ibProcessed);
            this.Controls.Add(this.ibOriginal);
            this.Name = "CricleDetection";
            this.Text = "CricleDetection";
            this.Load += new System.EventHandler(this.CricleDetection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibProcessed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibProcessed;
        private System.Windows.Forms.Button btnPauseOrResume;
        private System.Windows.Forms.TextBox txtXTRadius;
    }
}