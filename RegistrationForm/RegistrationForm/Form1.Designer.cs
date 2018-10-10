namespace RegistrationForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.imgcal = new System.Windows.Forms.PictureBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgcal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(47, 96);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(116, 88);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(100, 20);
            this.txtBirthDate.TabIndex = 3;
            // 
            // imgcal
            // 
            this.imgcal.Image = ((System.Drawing.Image)(resources.GetObject("imgcal.Image")));
            this.imgcal.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgcal.InitialImage")));
            this.imgcal.Location = new System.Drawing.Point(229, 74);
            this.imgcal.Name = "imgcal";
            this.imgcal.Size = new System.Drawing.Size(43, 50);
            this.imgcal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcal.TabIndex = 4;
            this.imgcal.TabStop = false;
            this.imgcal.Click += new System.EventHandler(this.imgcal_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(116, 147);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 23);
            this.btnRegistration.TabIndex = 5;
            this.btnRegistration.Text = "Register";
            this.btnRegistration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.imgcal);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgcal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.PictureBox imgcal;
        private System.Windows.Forms.Button btnRegistration;
    }
}

