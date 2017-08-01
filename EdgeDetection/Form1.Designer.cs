namespace CircleDetection
{
    partial class tlpContent
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
            this.tplImages = new System.Windows.Forms.TableLayoutPanel();
            this.lbOrginal = new System.Windows.Forms.Label();
            this.lbGray = new System.Windows.Forms.Label();
            this.lbCircles = new System.Windows.Forms.Label();
            this.ibOrginal = new Emgu.CV.UI.ImageBox();
            this.ibGray = new Emgu.CV.UI.ImageBox();
            this.ibCircles = new Emgu.CV.UI.ImageBox();
            this.btnPausePlay = new System.Windows.Forms.Button();
            this.chkCirclesOnOrginal = new System.Windows.Forms.CheckBox();
            this.tplImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCircles)).BeginInit();
            this.SuspendLayout();
            // 
            // tplImages
            // 
            this.tplImages.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tplImages.ColumnCount = 3;
            this.tplImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.tplImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tplImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tplImages.Controls.Add(this.lbOrginal, 0, 0);
            this.tplImages.Controls.Add(this.lbGray, 1, 0);
            this.tplImages.Controls.Add(this.lbCircles, 2, 0);
            this.tplImages.Controls.Add(this.ibOrginal, 0, 1);
            this.tplImages.Controls.Add(this.ibGray, 1, 1);
            this.tplImages.Controls.Add(this.ibCircles, 2, 1);
            this.tplImages.Enabled = false;
            this.tplImages.Location = new System.Drawing.Point(12, 27);
            this.tplImages.Name = "tplImages";
            this.tplImages.RowCount = 2;
            this.tplImages.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tplImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplImages.Size = new System.Drawing.Size(766, 267);
            this.tplImages.TabIndex = 0;
            // 
            // lbOrginal
            // 
            this.lbOrginal.AutoSize = true;
            this.lbOrginal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrginal.Location = new System.Drawing.Point(4, 1);
            this.lbOrginal.Name = "lbOrginal";
            this.lbOrginal.Size = new System.Drawing.Size(64, 16);
            this.lbOrginal.TabIndex = 0;
            this.lbOrginal.Text = "Orginal";
            // 
            // lbGray
            // 
            this.lbGray.AutoSize = true;
            this.lbGray.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGray.Location = new System.Drawing.Point(259, 1);
            this.lbGray.Name = "lbGray";
            this.lbGray.Size = new System.Drawing.Size(40, 16);
            this.lbGray.TabIndex = 1;
            this.lbGray.Text = "Edge";
            // 
            // lbCircles
            // 
            this.lbCircles.AutoSize = true;
            this.lbCircles.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCircles.Location = new System.Drawing.Point(513, 1);
            this.lbCircles.Name = "lbCircles";
            this.lbCircles.Size = new System.Drawing.Size(64, 16);
            this.lbCircles.TabIndex = 2;
            this.lbCircles.Text = "Circles";
            // 
            // ibOrginal
            // 
            this.ibOrginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOrginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOrginal.Enabled = false;
            this.ibOrginal.Location = new System.Drawing.Point(4, 21);
            this.ibOrginal.Name = "ibOrginal";
            this.ibOrginal.Size = new System.Drawing.Size(248, 242);
            this.ibOrginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOrginal.TabIndex = 2;
            this.ibOrginal.TabStop = false;
            // 
            // ibGray
            // 
            this.ibGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibGray.Enabled = false;
            this.ibGray.Location = new System.Drawing.Point(259, 21);
            this.ibGray.Name = "ibGray";
            this.ibGray.Size = new System.Drawing.Size(247, 242);
            this.ibGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibGray.TabIndex = 2;
            this.ibGray.TabStop = false;
            // 
            // ibCircles
            // 
            this.ibCircles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibCircles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibCircles.Enabled = false;
            this.ibCircles.Location = new System.Drawing.Point(513, 21);
            this.ibCircles.Name = "ibCircles";
            this.ibCircles.Size = new System.Drawing.Size(249, 242);
            this.ibCircles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibCircles.TabIndex = 2;
            this.ibCircles.TabStop = false;
            // 
            // btnPausePlay
            // 
            this.btnPausePlay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPausePlay.AutoSize = true;
            this.btnPausePlay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausePlay.Location = new System.Drawing.Point(805, 50);
            this.btnPausePlay.Name = "btnPausePlay";
            this.btnPausePlay.Size = new System.Drawing.Size(78, 45);
            this.btnPausePlay.TabIndex = 1;
            this.btnPausePlay.Text = "Pause";
            this.btnPausePlay.UseVisualStyleBackColor = true;
            this.btnPausePlay.Click += new System.EventHandler(this.btnPausePlay_Click);
            // 
            // chkCirclesOnOrginal
            // 
            this.chkCirclesOnOrginal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkCirclesOnOrginal.AutoSize = true;
            this.chkCirclesOnOrginal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCirclesOnOrginal.Location = new System.Drawing.Point(796, 120);
            this.chkCirclesOnOrginal.Name = "chkCirclesOnOrginal";
            this.chkCirclesOnOrginal.Size = new System.Drawing.Size(211, 20);
            this.chkCirclesOnOrginal.TabIndex = 2;
            this.chkCirclesOnOrginal.Text = "Show Circles on orginal";
            this.chkCirclesOnOrginal.UseVisualStyleBackColor = true;
            this.chkCirclesOnOrginal.CheckedChanged += new System.EventHandler(this.chkCirclesOnOrginal_CheckedChanged);
            // 
            // tlpContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 309);
            this.Controls.Add(this.chkCirclesOnOrginal);
            this.Controls.Add(this.btnPausePlay);
            this.Controls.Add(this.tplImages);
            this.Name = "tlpContent";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.tlpContent_Resize);
            this.tplImages.ResumeLayout(false);
            this.tplImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOrginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibCircles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplImages;
        private System.Windows.Forms.Label lbOrginal;
        private System.Windows.Forms.Label lbGray;
        private System.Windows.Forms.Label lbCircles;
        private Emgu.CV.UI.ImageBox ibOrginal;
        private Emgu.CV.UI.ImageBox ibGray;
        private Emgu.CV.UI.ImageBox ibCircles;
        private System.Windows.Forms.Button btnPausePlay;
        private System.Windows.Forms.CheckBox chkCirclesOnOrginal;
    }
}

