using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook.Phonebook_Tabs
{
    public partial class am_rc_user_control : UserControl
    {
        private static LyncCall call;

        public am_rc_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Keerthi_contact.MobileButtonClick += new EventHandler(Keerthi_mobile);
            Keerthi_contact.SkypeButtonClick += new EventHandler(Keerthi_skype);

            Anand_contact.MobileButtonClick += new EventHandler(Anand_mobile);
            Anand_contact.SkypeButtonClick += new EventHandler(Anand_skype);

            Vaasuthevan_contact.MobileButtonClick += new EventHandler(Vaasuthevan_mobile);
            Vaasuthevan_contact.SkypeButtonClick += new EventHandler(Vaasuthevan_skype);

            Dileep_contact.MobileButtonClick += new EventHandler(Dileep_mobile);
            Dileep_contact.SkypeButtonClick += new EventHandler(Dileep_skype);

            Igal_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            Igal_contact.SkypeButtonClick += new EventHandler(Igal_skype);

            Yossi_contact.MobileButtonClick += new EventHandler(Yossi_mobile);
            Yossi_contact.SkypeButtonClick += new EventHandler(Yossi_skype);
        }

        private void Yossi_skype(object sender, EventArgs e)
        {
            
        }

        private void Yossi_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525697029");
        }

        private void Igal_skype(object sender, EventArgs e)
        {
            
        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972506380116");
        }

        private void Dileep_skype(object sender, EventArgs e)
        {
            
        }

        private void Dileep_mobile(object sender, EventArgs e)
        {
            call.makeCall("+91  9994191448");
        }

        private void Vaasuthevan_skype(object sender, EventArgs e)
        {
            
        }

        private void Vaasuthevan_mobile(object sender, EventArgs e)
        {
            call.makeCall("+91 9962537685");
        }

        private void Anand_skype(object sender, EventArgs e)
        {
            
        }

        private void Anand_mobile(object sender, EventArgs e)
        {
            call.makeCall("+91  9880508508");
        }

        private void Keerthi_skype(object sender, EventArgs e)
        {
            
        }

        private void Keerthi_mobile(object sender, EventArgs e)
        {
            call.makeCall("+91  9677181157");
        }

        // Declare a Name property of type string:
        public LyncCall Call
        {
            get
            {
                return call;
            }
            set
            {
                call = value;
            }
        }
        
    }
}
