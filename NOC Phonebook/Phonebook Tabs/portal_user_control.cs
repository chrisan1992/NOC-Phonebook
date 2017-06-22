﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook.Phonebook_Tabs
{
    public partial class portal_user_control : UserControl
    {
        private static LyncCall call;

        public portal_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            GaryGlasspool_contact.MobileButtonClick += new EventHandler(GaryGlasspool_mobile);
            GaryGlasspool_contact.SkypeButtonClick += new EventHandler(GaryGlasspool_skype);

            GilderLopez_contact.MobileButtonClick += new EventHandler(GilderLopez_mobile);
            GilderLopez_contact.SkypeButtonClick += new EventHandler(Gilderlopez_skype);

            LilliamXu_contact.MobileButtonClick += new EventHandler(LillianXu_mobile);
            LilliamXu_contact.SkypeButtonClick += new EventHandler(LillianXu_skype);

            alexDekman_contact.MobileButtonClick += new EventHandler(AlexDekman_mobile);
            alexDekman_contact.SkypeButtonClick += new EventHandler(AlexDekman_skype);

            JumanaKass_contact.MobileButtonClick += new EventHandler(JumanaKass_mobile);
            JumanaKass_contact.SkypeButtonClick += new EventHandler(JumanaKass_skype);

            VadimWaisman_contact.MobileButtonClick += new EventHandler(VadimWaisman_mobile);
            VadimWaisman_contact.SkypeButtonClick += new EventHandler(VadimWaisman_skype);

            AmirGabay_contact.MobileButtonClick += new EventHandler(AmirGabay_mobile);
            AmirGabay_contact.SkypeButtonClick += new EventHandler(AmirGabay_skype);
        }

        private void AmirGabay_skype(object sender, EventArgs e)
        {
            
        }

        private void AmirGabay_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 548301016");
        }

        private void VadimWaisman_skype(object sender, EventArgs e)
        {
            
        }

        private void VadimWaisman_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972525759368");
        }

        private void JumanaKass_skype(object sender, EventArgs e)
        {
            
        }

        private void JumanaKass_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972547665782");
        }

        private void AlexDekman_skype(object sender, EventArgs e)
        {
            
        }

        private void AlexDekman_mobile(object sender, EventArgs e)
        {
            call.makeCall("+972 547854455");
        }

        private void LillianXu_skype(object sender, EventArgs e)
        {
            
        }

        private void LillianXu_mobile(object sender, EventArgs e)
        {
            call.makeCall("+408 799 0092");
        }

        private void Gilderlopez_skype(object sender, EventArgs e)
        {
            
        }

        private void GilderLopez_mobile(object sender, EventArgs e)
        {
            call.makeCall("+506 60030690");
        }

        private void GaryGlasspool_skype(object sender, EventArgs e)
        {
            
        }

        private void GaryGlasspool_mobile(object sender, EventArgs e)
        {
            call.makeCall("+1 4082036412");
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