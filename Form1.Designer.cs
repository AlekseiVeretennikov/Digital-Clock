﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.Dock = DockStyle.Fill;
            timeLabel.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.Location = new Point(0, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(800, 450);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "00:00:00\r\n";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            timeLabel.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Цифровые часы";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label timeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}
