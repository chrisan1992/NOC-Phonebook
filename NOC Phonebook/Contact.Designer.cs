namespace NOC_Phonebook
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            this.btn_X_skype = new System.Windows.Forms.Button();
            this.btn_X_mobile = new System.Windows.Forms.Button();
            this.contactLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_X_skype
            // 
            this.btn_X_skype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btn_X_skype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_X_skype.BackgroundImage")));
            this.btn_X_skype.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_X_skype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X_skype.Location = new System.Drawing.Point(184, 23);
            this.btn_X_skype.Name = "btn_X_skype";
            this.btn_X_skype.Size = new System.Drawing.Size(27, 23);
            this.btn_X_skype.TabIndex = 6;
            this.btn_X_skype.UseVisualStyleBackColor = false;
            this.btn_X_skype.Click += new System.EventHandler(this.btn_X_skype_Click);
            // 
            // btn_X_mobile
            // 
            this.btn_X_mobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btn_X_mobile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_X_mobile.BackgroundImage")));
            this.btn_X_mobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_X_mobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_X_mobile.Location = new System.Drawing.Point(184, 0);
            this.btn_X_mobile.Name = "btn_X_mobile";
            this.btn_X_mobile.Size = new System.Drawing.Size(27, 23);
            this.btn_X_mobile.TabIndex = 5;
            this.btn_X_mobile.UseVisualStyleBackColor = false;
            this.btn_X_mobile.Click += new System.EventHandler(this.btn_X_mobile_Click);
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLbl.ForeColor = System.Drawing.Color.White;
            this.contactLbl.Location = new System.Drawing.Point(3, 12);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(130, 21);
            this.contactLbl.TabIndex = 7;
            this.contactLbl.Text = "Contact Name";
            // 
            // Contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.btn_X_skype);
            this.Controls.Add(this.btn_X_mobile);
            this.Name = "Contact";
            this.Size = new System.Drawing.Size(211, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_X_skype;
        private System.Windows.Forms.Button btn_X_mobile;
        private System.Windows.Forms.Label contactLbl;
    }
}
