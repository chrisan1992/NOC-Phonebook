namespace NOC_Phonebook
{
    partial class dashboard_user_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_user_control));
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.search_result_1 = new NOC_Phonebook.Contact();
            this.search_result_3 = new NOC_Phonebook.Contact();
            this.search_result_2 = new NOC_Phonebook.Contact();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(71)))), ((int)(((byte)(103)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(48, 32);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(215, 42);
            this.panel8.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 20.75F);
            this.txtSearch.Location = new System.Drawing.Point(270, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(375, 41);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(652, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 42);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // search_result_1
            // 
            this.search_result_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.search_result_1.ContactLabel = "Contact Name";
            this.search_result_1.Location = new System.Drawing.Point(48, 158);
            this.search_result_1.MobileNumber = null;
            this.search_result_1.Name = "search_result_1";
            this.search_result_1.Size = new System.Drawing.Size(211, 46);
            this.search_result_1.SkypeNumber = null;
            this.search_result_1.TabIndex = 18;
            this.search_result_1.Visible = false;
            // 
            // search_result_3
            // 
            this.search_result_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.search_result_3.ContactLabel = "Contact Name";
            this.search_result_3.Location = new System.Drawing.Point(497, 158);
            this.search_result_3.MobileNumber = null;
            this.search_result_3.Name = "search_result_3";
            this.search_result_3.Size = new System.Drawing.Size(211, 46);
            this.search_result_3.SkypeNumber = null;
            this.search_result_3.TabIndex = 19;
            this.search_result_3.Visible = false;
            // 
            // search_result_2
            // 
            this.search_result_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(130)))));
            this.search_result_2.ContactLabel = "Contact Name";
            this.search_result_2.Location = new System.Drawing.Point(272, 158);
            this.search_result_2.MobileNumber = null;
            this.search_result_2.Name = "search_result_2";
            this.search_result_2.Size = new System.Drawing.Size(211, 46);
            this.search_result_2.SkypeNumber = null;
            this.search_result_2.TabIndex = 20;
            this.search_result_2.Visible = false;
            // 
            // dashboard_user_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.search_result_2);
            this.Controls.Add(this.search_result_3);
            this.Controls.Add(this.search_result_1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel8);
            this.Name = "dashboard_user_control";
            this.Size = new System.Drawing.Size(754, 431);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private Contact search_result_1;
        private Contact search_result_3;
        private Contact search_result_2;
    }
}
