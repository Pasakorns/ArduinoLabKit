namespace ArduinoLabKit
{
    partial class uscLab01
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLab01 = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.trbPower = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorUpload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPower)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLab01
            // 
            this.lblLab01.AutoSize = true;
            this.lblLab01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLab01.Location = new System.Drawing.Point(103, 9);
            this.lblLab01.Name = "lblLab01";
            this.lblLab01.Size = new System.Drawing.Size(95, 17);
            this.lblLab01.TabIndex = 0;
            this.lblLab01.Text = "LED Control";
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.White;
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Location = new System.Drawing.Point(50, 37);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(82, 61);
            this.pnlColor.TabIndex = 1;
            this.pnlColor.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(20, 34);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbRed.Size = new System.Drawing.Size(45, 120);
            this.trbRed.SmallChange = 10;
            this.trbRed.TabIndex = 1;
            this.trbRed.TickFrequency = 64;
            this.trbRed.Value = 255;
            this.trbRed.Scroll += new System.EventHandler(this.trbRGB_Scroll);
            // 
            // txtRed
            // 
            this.txtRed.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtRed.Font = new System.Drawing.Font("Let\'s go Digital", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.ForeColor = System.Drawing.Color.Lime;
            this.txtRed.Location = new System.Drawing.Point(11, 160);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(40, 23);
            this.txtRed.TabIndex = 2;
            this.txtRed.Text = "255";
            this.txtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RED";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trbBlue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBlue);
            this.groupBox1.Controls.Add(this.trbGreen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGreen);
            this.groupBox1.Controls.Add(this.trbRed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRed);
            this.groupBox1.Location = new System.Drawing.Point(11, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(145, 34);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbBlue.Size = new System.Drawing.Size(45, 120);
            this.trbBlue.SmallChange = 10;
            this.trbBlue.TabIndex = 7;
            this.trbBlue.TickFrequency = 64;
            this.trbBlue.Value = 255;
            this.trbBlue.Scroll += new System.EventHandler(this.trbRGB_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "BLUE";
            // 
            // txtBlue
            // 
            this.txtBlue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBlue.Font = new System.Drawing.Font("Let\'s go Digital", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlue.ForeColor = System.Drawing.Color.Lime;
            this.txtBlue.Location = new System.Drawing.Point(136, 160);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(40, 23);
            this.txtBlue.TabIndex = 8;
            this.txtBlue.Text = "255";
            this.txtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(82, 34);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbGreen.Size = new System.Drawing.Size(45, 120);
            this.trbGreen.SmallChange = 10;
            this.trbGreen.TabIndex = 4;
            this.trbGreen.TickFrequency = 64;
            this.trbGreen.Value = 255;
            this.trbGreen.Scroll += new System.EventHandler(this.trbRGB_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GREEN";
            // 
            // txtGreen
            // 
            this.txtGreen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGreen.Font = new System.Drawing.Font("Let\'s go Digital", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGreen.ForeColor = System.Drawing.Color.Lime;
            this.txtGreen.Location = new System.Drawing.Point(73, 160);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(40, 23);
            this.txtGreen.TabIndex = 5;
            this.txtGreen.Text = "255";
            this.txtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trbPower
            // 
            this.trbPower.Location = new System.Drawing.Point(23, 34);
            this.trbPower.Maximum = 255;
            this.trbPower.Name = "trbPower";
            this.trbPower.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbPower.Size = new System.Drawing.Size(45, 120);
            this.trbPower.SmallChange = 10;
            this.trbPower.TabIndex = 10;
            this.trbPower.TickFrequency = 64;
            this.trbPower.Value = 255;
            this.trbPower.Scroll += new System.EventHandler(this.trbRGB_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "POWER";
            // 
            // txtPower
            // 
            this.txtPower.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPower.Font = new System.Drawing.Font("Let\'s go Digital", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.ForeColor = System.Drawing.Color.Lime;
            this.txtPower.Location = new System.Drawing.Point(14, 160);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(40, 23);
            this.txtPower.TabIndex = 11;
            this.txtPower.Text = "255";
            this.txtPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trbPower);
            this.groupBox2.Controls.Add(this.txtPower);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(216, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(74, 200);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnColorUpload
            // 
            this.btnColorUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorUpload.Location = new System.Drawing.Point(184, 47);
            this.btnColorUpload.Name = "btnColorUpload";
            this.btnColorUpload.Size = new System.Drawing.Size(75, 45);
            this.btnColorUpload.TabIndex = 14;
            this.btnColorUpload.Text = "Upload Color";
            this.btnColorUpload.UseVisualStyleBackColor = true;
            this.btnColorUpload.Click += new System.EventHandler(this.btnColorUpload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "==>";
            // 
            // uscLab01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnColorUpload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.lblLab01);
            this.Name = "uscLab01";
            this.Size = new System.Drawing.Size(300, 330);
            this.Load += new System.EventHandler(this.uscLab01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPower)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLab01;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TrackBar trbPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorUpload;
        private System.Windows.Forms.Label label5;
    }
}
