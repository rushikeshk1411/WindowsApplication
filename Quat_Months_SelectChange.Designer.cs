namespace Windows_Form_Project
{
    partial class Quat_Months_SelectChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quat_Months_SelectChange));
            label1 = new Label();
            label2 = new Label();
            lblCalender = new Label();
            cbQuarter = new ComboBox();
            cbMonths = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // lblCalender
            // 
            resources.ApplyResources(lblCalender, "lblCalender");
            lblCalender.Name = "lblCalender";
            // 
            // cbQuarter
            // 
            cbQuarter.FormattingEnabled = true;
            resources.ApplyResources(cbQuarter, "cbQuarter");
            cbQuarter.Name = "cbQuarter";
            cbQuarter.SelectedIndexChanged += cbQuarter_SelectedIndexChanged;
            // 
            // cbMonths
            // 
            cbMonths.FormattingEnabled = true;
            resources.ApplyResources(cbMonths, "cbMonths");
            cbMonths.Name = "cbMonths";
            // 
            // Quat_Months_SelectChange
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbMonths);
            Controls.Add(cbQuarter);
            Controls.Add(lblCalender);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Quat_Months_SelectChange";
            Load += Quat_Months_SelectChange_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblCalender;
        private ComboBox cbQuarter;
        private ComboBox cbMonths;
    }
}
