namespace ArduinoLabKit
{
    partial class CircuitViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CircuitViewer));
            this.pnImage = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnImage
            // 
            this.pnImage.AutoScroll = true;
            this.pnImage.AutoSize = true;
            this.pnImage.BackColor = System.Drawing.Color.White;
            this.pnImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnImage.BackgroundImage")));
            this.pnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnImage.Location = new System.Drawing.Point(0, 0);
            this.pnImage.Name = "pnImage";
            this.pnImage.Padding = new System.Windows.Forms.Padding(5);
            this.pnImage.Size = new System.Drawing.Size(584, 461);
            this.pnImage.TabIndex = 0;
            // 
            // CircuitViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pnImage);
            this.Name = "CircuitViewer";
            this.Text = "Wiring";
            this.Load += new System.EventHandler(this.CircuitViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnImage;
    }
}