using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook
{
    public partial class Contact : UserControl
    {
        public event EventHandler MobileButtonClick;
        public event EventHandler SkypeButtonClick;

        public Contact()
        {
            InitializeComponent();
        }

        public string ContactLabel
        {
            get { return this.contactLbl.Text; }
            set { this.contactLbl.Text = value; }
        }

        protected void btn_X_mobile_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.MobileButtonClick != null)
                this.MobileButtonClick(this, e);
        }

        protected void btn_X_skype_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.SkypeButtonClick != null)
                this.SkypeButtonClick(this, e);
        }
    }
}
