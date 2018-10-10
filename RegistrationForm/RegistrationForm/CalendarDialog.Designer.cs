namespace RegistrationForm
{
    partial class CalendarDialog
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
            this.DateSelection = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // DateSelection
            // 
            this.DateSelection.Location = new System.Drawing.Point(30, 57);
            this.DateSelection.Name = "DateSelection";
            this.DateSelection.TabIndex = 0;
            // 
            // CalendarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DateSelection);
            this.Name = "CalendarDialog";
            this.Text = "CalendarDialog";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.MonthCalendar DateSelection;
    }
}