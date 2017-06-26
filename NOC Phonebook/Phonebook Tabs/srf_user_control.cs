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
    public partial class srf_user_control : UserControl
    {
        private static LyncCall call;

        public srf_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            FCocozza_contact.MobileButtonClick += new EventHandler(Francisco_mobile);
            FCocozza_contact.SkypeButtonClick += new EventHandler(Francisco_skype);

            MarkYevday_contact.MobileButtonClick += new EventHandler(Mark_mobile);
            MarkYevday_contact.SkypeButtonClick += new EventHandler(Mark_skype);

            EfratArad_contact.MobileButtonClick += new EventHandler(Efrat_mobile);
            EfratArad_contact.SkypeButtonClick += new EventHandler(Efrat_skype);

            Amir_contact.MobileButtonClick += new EventHandler(Amir_mobile);
            Amir_contact.SkypeButtonClick += new EventHandler(Amir_skype);

            Vadim_contact.MobileButtonClick += new EventHandler(Vadim_mobile);
            Vadim_contact.SkypeButtonClick += new EventHandler(Vadim_skype);
        }

        private void Vadim_skype(object sender, EventArgs e)
        {
            
        }

        private void Vadim_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525759368");
        }

        private void Amir_skype(object sender, EventArgs e)
        {
            
        }

        private void Amir_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 548301016");
        }

        private void Efrat_skype(object sender, EventArgs e)
        {
            
        }

        private void Efrat_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 3 5398084");
        }

        private void Mark_skype(object sender, EventArgs e)
        {
            
        }

        private void Mark_mobile(object sender, EventArgs e)
        {
            call.makeCall("+97235399375");
        }

        private void Francisco_skype(object sender, EventArgs e)
        {
            
        }

        private void Francisco_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506  88804340");
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
