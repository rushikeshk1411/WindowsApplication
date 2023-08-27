namespace Windows_Form_Project
{
    partial class ComboBox_ListBox_CheckBox
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
            StateList = new ListBox();
            CountryList = new CheckedListBox();
            CityName = new ComboBox();
            btnComboBox = new Button();
            btnListBox = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // StateList
            // 
            StateList.FormattingEnabled = true;
            StateList.ItemHeight = 15;
            StateList.Location = new Point(134, 39);
            StateList.Name = "StateList";
            StateList.SelectionMode = SelectionMode.MultiSimple;
            StateList.Size = new Size(136, 94);
            StateList.TabIndex = 0;
            StateList.SelectedIndexChanged += StateList_SelectedIndexChanged;
            // 
            // CountryList
            // 
            CountryList.FormattingEnabled = true;
            CountryList.Location = new Point(294, 39);
            CountryList.Name = "CountryList";
            CountryList.Size = new Size(136, 94);
            CountryList.TabIndex = 1;
            // 
            // CityName
            // 
            CityName.FormattingEnabled = true;
            CityName.Location = new Point(5, 39);
            CityName.Name = "CityName";
            CityName.Size = new Size(114, 23);
            CityName.TabIndex = 2;
            CityName.KeyPress += CityName_KeyPress;
            // 
            // btnComboBox
            // 
            btnComboBox.BackColor = Color.IndianRed;
            btnComboBox.Location = new Point(5, 154);
            btnComboBox.Name = "btnComboBox";
            btnComboBox.Size = new Size(114, 45);
            btnComboBox.TabIndex = 3;
            btnComboBox.Text = "City";
            btnComboBox.UseVisualStyleBackColor = false;
            btnComboBox.Click += btnComboBox_Click;
            // 
            // btnListBox
            // 
            btnListBox.BackColor = Color.Brown;
            btnListBox.Location = new Point(134, 154);
            btnListBox.Name = "btnListBox";
            btnListBox.Size = new Size(136, 45);
            btnListBox.TabIndex = 4;
            btnListBox.Text = "State";
            btnListBox.UseVisualStyleBackColor = false;
            btnListBox.Click += btnListBox_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Location = new Point(294, 154);
            button3.Name = "button3";
            button3.Size = new Size(136, 45);
            button3.TabIndex = 5;
            button3.Text = "Country";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // ComboBox_ListBox_CheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 211);
            Controls.Add(button3);
            Controls.Add(btnListBox);
            Controls.Add(btnComboBox);
            Controls.Add(CityName);
            Controls.Add(CountryList);
            Controls.Add(StateList);
            Name = "ComboBox_ListBox_CheckBox";
            Text = "ComboBox_ListBox_CheckBox";
            Load += ComboBox_ListBox_CheckBox_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox StateList;
        private CheckedListBox CountryList;
        private ComboBox CityName;
        private Button btnComboBox;
        private Button btnListBox;
        private Button button3;
    }
}