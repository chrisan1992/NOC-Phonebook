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
    public partial class art_user_control : UserControl
    {

        private static LyncCall call;

        public art_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            AlexDekman_contact.ContactLabel = "Alex Dekman";
            AlexDekman_contact.MobileButtonClick += new EventHandler(AlexDekam_mobile);
            AlexDekman_contact.SkypeButtonClick += new EventHandler(AlexDekman_skype);

            AmirGabay_contact.ContactLabel = "Amir Gabay";
            AmirGabay_contact.MobileButtonClick += new EventHandler(AmirGabay_mobile);
            AmirGabay_contact.SkypeButtonClick += new EventHandler(AmirGabay_skype);

            ItayLaxer_contact.ContactLabel = "Itay Laxer";
            ItayLaxer_contact.MobileButtonClick += new EventHandler(ItayLaxer_mobile);
            ItayLaxer_contact.SkypeButtonClick += new EventHandler(ItayLaxer_skype);

            VadimWaisman_contact.ContactLabel = "Vadim Waisman";
            VadimWaisman_contact.MobileButtonClick += new EventHandler(VadimWaisman_mobile);
            VadimWaisman_contact.SkypeButtonClick += new EventHandler(VadimWaisman_skype);
        }

        private void VadimWaisman_skype(object sender, EventArgs e)
        {
            
        }

        private void VadimWaisman_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525759368");
        }

        private void ItayLaxer_skype(object sender, EventArgs e)
        {
            
        }

        private void ItayLaxer_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497019");
        }

        private void AmirGabay_skype(object sender, EventArgs e)
        {
            
        }

        private void AmirGabay_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 548301016");
        }

        private void AlexDekman_skype(object sender, EventArgs e)
        {
            
        }

        private void AlexDekam_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 547854455");
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
