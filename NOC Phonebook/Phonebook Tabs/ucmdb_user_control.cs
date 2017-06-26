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
    public partial class ucmdb_user_control : UserControl
    {
        private static LyncCall call;

        public ucmdb_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            Karvin_contact.MobileButtonClick += new EventHandler(Karvin_mobile);
            Karvin_contact.SkypeButtonClick += new EventHandler(Karvin_skype);

            Javier_contact.MobileButtonClick += new EventHandler(Javier_mobile);
            Javier_contact.SkypeButtonClick += new EventHandler(Javier_skype);

            AlexFurman_contact.MobileButtonClick += new EventHandler(Alex_mobile);
            AlexFurman_contact.SkypeButtonClick += new EventHandler(Alex_skype);

            Zakher_contact.MobileButtonClick += new EventHandler(Zakher_mobile);
            Zakher_contact.SkypeButtonClick += new EventHandler(Zakher_skype);

            IgalBarboy_contact.MobileButtonClick += new EventHandler(Igal_mobile);
            IgalBarboy_contact.SkypeButtonClick += new EventHandler(Igal_skype);

            DiegoClachar_contact.MobileButtonClick += new EventHandler(Diego_mobile);
            DiegoClachar_contact.SkypeButtonClick += new EventHandler(Diego_skype);

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

        private void Diego_skype(object sender, EventArgs e)
        {
            
        }

        private void Diego_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 88634118");
        }

        private void Igal_skype(object sender, EventArgs e)
        {
            
        }

        private void Igal_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972506380116");
        }

        private void Zakher_skype(object sender, EventArgs e)
        {
            
        }

        private void Zakher_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972546335263");
        }

        private void Alex_skype(object sender, EventArgs e)
        {
            
        }

        private void Alex_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972546620319");
        }

        private void Javier_skype(object sender, EventArgs e)
        {
            
        }

        private void Javier_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 70126952");
        }

        private void Karvin_skype(object sender, EventArgs e)
        {
            
        }

        private void Karvin_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 89692626");
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
