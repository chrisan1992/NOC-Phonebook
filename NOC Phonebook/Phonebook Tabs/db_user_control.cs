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
            AhsanAli_contact.MobileNumber = "+1 8054039930";
            AhsanAli_contact.MobileButtonClick += new EventHandler(AhsanAli_mobile);
            AhsanAli_contact.SkypeButtonClick += new EventHandler(AhsanAli_skype);

            JaydeepDave_contact.MobileNumber = "+1 7788892516";
            JaydeepDave_contact.MobileButtonClick += new EventHandler(JaydeepDave_mobile);
            JaydeepDave_contact.SkypeButtonClick += new EventHandler(JaydeepDave_skype);

            SaumyaMula_contact.MobileNumber = "+1 408 4700263";
            SaumyaMula_contact.MobileButtonClick += new EventHandler(SaumyaMula_mobile);
            SaumyaMula_contact.SkypeButtonClick += new EventHandler(SaumyaMula_skype);

            SharonCastel_contact.MobileNumber = "+972 54 2553113";
            SharonCastel_contact.MobileButtonClick += new EventHandler(SharonCastel_mobile);
            SharonCastel_contact.SkypeButtonClick += new EventHandler(SharonCastel_skype);

            ShirlyCohen_contact.MobileNumber = "+972 52 6194157";
            ShirlyCohen_contact.MobileButtonClick += new EventHandler(ShirlyCohen_mobile);
            ShirlyCohen_contact.SkypeButtonClick += new EventHandler(shirlyCohen_skype);

            EldadKohavi_contact.MobileNumber = "+972544376605";
            EldadKohavi_contact.MobileButtonClick += new EventHandler(EldadKohavi_mobile);
            EldadKohavi_contact.SkypeButtonClick += new EventHandler(EldadKohavi_skype);

            EliranSwisa_contact.MobileNumber = "+972545896009";
            EliranSwisa_contact.MobileButtonClick += new EventHandler(EliranSwisa_mobile);
            EliranSwisa_contact.SkypeButtonClick += new EventHandler(EliranSwisa_skype);

            YamyVissel_contact.MobileNumber = "+972544497263";
            YamyVissel_contact.MobileButtonClick += new EventHandler(YamyVissel_mobile);
            YamyVissel_contact.SkypeButtonClick += new EventHandler(YamyVissel_skype);

            YossiGalazan_contact.MobileNumber = "+972545245606";
            YossiGalazan_contact.MobileButtonClick += new EventHandler(YossiGalazan_mobile);
            YossiGalazan_contact.SkypeButtonClick += new EventHandler(YossiGalazan_skype);
        }

        private void YossiGalazan_skype(object sender, EventArgs e)
        {
            
        }

        private void YossiGalazan_mobile(object sender, EventArgs e)
        {
            call.makeCall(YossiGalazan_contact.MobileNumber);
        }

        private void YamyVissel_skype(object sender, EventArgs e)
        {
            
        }

        private void YamyVissel_mobile(object sender, EventArgs e)
        {
            call.makeCall(YamyVissel_contact.MobileNumber);
        }

        private void EliranSwisa_skype(object sender, EventArgs e)
        {
            
        }

        private void EliranSwisa_mobile(object sender, EventArgs e)
        {
            call.makeCall(EliranSwisa_contact.MobileNumber);
        }

        private void EldadKohavi_skype(object sender, EventArgs e)
        {
            
        }

        private void EldadKohavi_mobile(object sender, EventArgs e)
        {
            call.makeCall(EldadKohavi_contact.MobileNumber);
        }

        private void shirlyCohen_skype(object sender, EventArgs e)
        {
            
        }

        private void ShirlyCohen_mobile(object sender, EventArgs e)
        {
            call.makeCall(ShirlyCohen_contact.MobileNumber);
        }

        private void SharonCastel_skype(object sender, EventArgs e)
        {
            
        }

        private void SharonCastel_mobile(object sender, EventArgs e)
        {
            call.makeCall(SharonCastel_contact.MobileNumber);
        }

        private void SaumyaMula_skype(object sender, EventArgs e)
        {
            
        }

        private void SaumyaMula_mobile(object sender, EventArgs e)
        {
            call.makeCall(SaumyaMula_contact.MobileNumber);
        }

        private void JaydeepDave_skype(object sender, EventArgs e)
        {
            
        }

        private void JaydeepDave_mobile(object sender, EventArgs e)
        {
            call.makeCall(JaydeepDave_contact.MobileNumber);
        }

        private void AhsanAli_skype(object sender, EventArgs e)
        {
            
        }

        private void AhsanAli_mobile(object sender, EventArgs e)
        {
            call.makeCall(AhsanAli_contact.MobileNumber);
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
