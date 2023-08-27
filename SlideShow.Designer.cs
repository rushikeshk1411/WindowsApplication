namespace Windows_Form_Project
{
    partial class SlideShow
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnStop = new Button();
            btnNext = new Button();
            btnprev = new Button();
            btnStart = new Button();
            btnLoad = new Button();
            lbImage = new ListBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnStop);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnprev);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(lbImage);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(405, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 450);
            panel1.TabIndex = 10;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStop.Location = new Point(7, 296);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(216, 48);
            btnStop.TabIndex = 14;
            btnStop.Text = "Stop Slide Show";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Red;
            btnNext.FlatStyle = FlatStyle.System;
            btnNext.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(187, 193);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 43);
            btnNext.TabIndex = 13;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnprev
            // 
            btnprev.BackColor = SystemColors.Control;
            btnprev.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnprev.Location = new Point(151, 193);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(36, 43);
            btnprev.TabIndex = 12;
            btnprev.Text = "<";
            btnprev.UseVisualStyleBackColor = false;
            btnprev.Click += btnprev_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.GreenYellow;
            btnStart.Enabled = false;
            btnStart.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(6, 242);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(216, 48);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start Slide Show";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Gainsboro;
            btnLoad.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(7, 193);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(144, 43);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Select Folder";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbImage
            // 
            lbImage.FormattingEnabled = true;
            lbImage.ItemHeight = 15;
            lbImage.Location = new Point(7, 3);
            lbImage.Name = "lbImage";
            lbImage.Size = new Size(216, 184);
            lbImage.TabIndex = 9;
            lbImage.SelectedIndexChanged += lbImage_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1500;
            timer1.Tick += timer1_Tick;
            // 
            // SlideShow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnStop;
            ClientSize = new Size(636, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "SlideShow";
            Text = "SlideShow";
            Load += SlideShow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnStop;
        private Button btnNext;
        private Button btnprev;
        private Button btnStart;
        private Button btnLoad;
        private ListBox lbImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}