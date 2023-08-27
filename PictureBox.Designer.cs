namespace Windows_Form_Project
{
    partial class PictureBox
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
            panel1 = new Panel();
            btnSave = new Button();
            btnLoad = new Button();
            btnFont = new Button();
            BtbChangeColor = new Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(btnFont);
            panel1.Controls.Add(BtbChangeColor);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(387, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 368);
            panel1.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(4, 248);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 52);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Image";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(3, 164);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(154, 63);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load Image";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnFont
            // 
            btnFont.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFont.Location = new Point(3, 85);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(154, 63);
            btnFont.TabIndex = 9;
            btnFont.Text = "Change Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // BtbChangeColor
            // 
            BtbChangeColor.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtbChangeColor.Location = new Point(4, 12);
            BtbChangeColor.Name = "BtbChangeColor";
            BtbChangeColor.Size = new Size(154, 57);
            BtbChangeColor.TabIndex = 8;
            BtbChangeColor.Text = "ChangeColor";
            BtbChangeColor.UseVisualStyleBackColor = true;
            BtbChangeColor.Click += BtbChangeColor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // PictureBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 368);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "PictureBox";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Button btnLoad;
        private Button btnFont;
        private Button BtbChangeColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
