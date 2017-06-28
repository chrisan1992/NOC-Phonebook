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
    public partial class db_user_control : UserControl
    {
        private static LyncCall call;

        public db_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            AhsanAli_contact.MobileButtonClick += new EventHandler(AhsanAli_mobile);
            AhsanAli_contact.SkypeButtonClick += new EventHandler(AhsanAli_skype);

            JaydeepDave_contact.MobileButtonClick += new EventHandler(JaydeepDave_mobile);
            JaydeepDave_contact.SkypeButtonClick += new EventHandler(JaydeepDave_skype);

            SaumyaMula_contact.MobileButtonClick += new EventHandler(SaumyaMula_mobile);
            SaumyaMula_contact.SkypeButtonClick += new EventHandler(SaumyaMula_skype);

            SharonCastel_contact.MobileButtonClick += new EventHandler(SharonCastel_mobile);
            SharonCastel_contact.SkypeButtonClick += new EventHandler(SharonCastel_skype);

            ShirlyCohen_contact.MobileButtonClick += new EventHandler(ShirlyCohen_mobile);
            ShirlyCohen_contact.SkypeButtonClick += new EventHandler(shirlyCohen_skype);

            EldadKohavi_contact.MobileButtonClick += new EventHandler(EldadKohavi_mobile);
            EldadKohavi_contact.SkypeButtonClick += new EventHandler(EldadKohavi_skype);

            EliranSwisa_contact.MobileButtonClick += new EventHandler(EliranSwisa_mobile);
            EliranSwisa_contact.SkypeButtonClick += new EventHandler(EliranSwisa_skype);

            YamyVissel_contact.MobileButtonClick += new EventHandler(YamyVissel_mobile);
            YamyVissel_contact.SkypeButtonClick += new EventHandler(YamyVissel_skype);

            YossiGalazan_contact.MobileButtonClick += new EventHandler(YossiGalazan_mobile);
            YossiGalazan_contact.SkypeButtonClick += new EventHandler(YossiGalazan_skype);
        }

        private void YossiGalazan_skype(object sender, EventArgs e)
        {
            
        }

        private void YossiGalazan_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972545245606");
        }

        private void YamyVissel_skype(object sender, EventArgs e)
        {
            
        }

        private void YamyVissel_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972544497263");
        }

        private void EliranSwisa_skype(object sender, EventArgs e)
        {
            
        }

        private void EliranSwisa_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972545896009");
        }

        private void EldadKohavi_skype(object sender, EventArgs e)
        {
            
        }

        private void EldadKohavi_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972544376605");
        }

        private void shirlyCohen_skype(object sender, EventArgs e)
        {
            
        }

        private void ShirlyCohen_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 52 6194157");
        }

        private void SharonCastel_skype(object sender, EventArgs e)
        {
            
        }

        private void SharonCastel_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 54 2553113");
        }

        private void SaumyaMula_skype(object sender, EventArgs e)
        {
            
        }

        private void SaumyaMula_mobile(object sender, EventArgs e)
        {
            call.makeCall("+1 4084700263");
        }

        private void JaydeepDave_skype(object sender, EventArgs e)
        {
            
        }

        private void JaydeepDave_mobile(object sender, EventArgs e)
        {
            call.makeCall("+1 7788892516");
        }

        private void AhsanAli_skype(object sender, EventArgs e)
        {
            
        }

        private void AhsanAli_mobile(object sender, EventArgs e)
        {
            call.makeCall("+1 8054039930");
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

        /// <summary>
        /// Add contacts to the contact list
        /// </summary>
        /// <param name="contactList"></param>
        public void Fill_list(List<Contact> contactList)
        {
            AddContactToList(contactList, AhsanAli_contact);
            AddContactToList(contactList, JaydeepDave_contact);
            AddContactToList(contactList, SaumyaMula_contact);
            AddContactToList(contactList, SharonCastel_contact);
            AddContactToList(contactList, ShirlyCohen_contact);
            AddContactToList(contactList, EldadKohavi_contact);
            AddContactToList(contactList, EliranSwisa_contact);
            AddContactToList(contactList, YamyVissel_contact);
            AddContactToList(contactList, YossiGalazan_contact);
        }

        /// <summary>
        /// Adding a contact to the list
        /// </summary>
        /// <param name="contactList">list</param>
        /// <param name="contact">contact to add</param>
        private void AddContactToList(List<Contact> contactList, Contact contact)
        {
            if (!contactList.Any(x => x.ContactLabel == contact.ContactLabel))
            {
                contactList.Add(contact);
            }
        }
    }
}
