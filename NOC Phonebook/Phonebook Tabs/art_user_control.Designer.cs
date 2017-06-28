namespace NOC_Phonebook.Phonebook_Tabs
{
    partial class art_user_control
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AlexDekman_contact = new NOC_Phonebook.Contact();
            this.AmirGabay_contact = new NOC_Phonebook.Contact();
            this.ItayLaxer_contact = new NOC_Phonebook.Contact();
            this.VadimWaisman_contact = new NOC_Phonebook.Contact();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(137, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(587, 2);
            this.label12.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "EMEA Engineers";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(144, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 2);
            this.label2.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Managers";
            // 
            // AlexDekman_contact
            // 
            this.AlexDekman_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.AlexDekman_contact.ContactLabel = "Alex Dekman";
            this.AlexDekman_contact.Location = new System.Drawing.Point(30, 40);
            this.AlexDekman_contact.Name = "AlexDekman_contact";
            this.AlexDekman_contact.Size = new System.Drawing.Size(211, 46);
            this.AlexDekman_contact.TabIndex = 32;
            // 
            // AmirGabay_contact
            // 
            this.AmirGabay_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.AmirGabay_contact.ContactLabel = "Amir Gabay";
            this.AmirGabay_contact.Location = new System.Drawing.Point(30, 193);
            this.AmirGabay_contact.Name = "AmirGabay_contact";
            this.AmirGabay_contact.Size = new System.Drawing.Size(211, 46);
            this.AmirGabay_contact.TabIndex = 33;
            // 
            // ItayLaxer_contact
            // 
            this.ItayLaxer_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.ItayLaxer_contact.ContactLabel = "Itay Laxer";
            this.ItayLaxer_contact.Location = new System.Drawing.Point(270, 193);
            this.ItayLaxer_contact.Name = "ItayLaxer_contact";
            this.ItayLaxer_contact.Size = new System.Drawing.Size(211, 46);
            this.ItayLaxer_contact.TabIndex = 34;
            // 
            // VadimWaisman_contact
            // 
            this.VadimWaisman_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.VadimWaisman_contact.ContactLabel = "Vadim Waisman";
            this.VadimWaisman_contact.Location = new System.Drawing.Point(513, 193);
            this.VadimWaisman_contact.Name = "VadimWaisman_contact";
            this.VadimWaisman_contact.Size = new System.Drawing.Size(211, 46);
            this.VadimWaisman_contact.TabIndex = 35;
            // 
            // art_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.VadimWaisman_contact);
            this.Controls.Add(this.ItayLaxer_contact);
            this.Controls.Add(this.AmirGabay_contact);
            this.Controls.Add(this.AlexDekman_contact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Name = "art_user_control";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(743, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Contact AlexDekman_contact;
        private Contact AmirGabay_contact;
        private Contact ItayLaxer_contact;
        private Contact VadimWaisman_contact;
    }
}
