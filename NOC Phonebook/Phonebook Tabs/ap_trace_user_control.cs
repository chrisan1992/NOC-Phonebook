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
    public partial class ap_trace_user_control : UserControl
    {

        private static LyncCall call;

        public ap_trace_user_control()
        {
            InitializeComponent();
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

        private void btn_EdwinPerez_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 87029212");
        }

        private void btn_EdwinPerez_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_GhassanIbrahim_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972523055944");
        }

        private void btn_GhassanIbrahim_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_FadiTuma_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972 545416840");
        }

        private void btn_FadiTuma_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_YesGonzales_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 60507776");
        }

        private void btn_YesGonzales_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_ItayLaxer_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972 54 4497019");
        }

        private void btn_ItayLaxer_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_TalTalmon_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972 545597074");
        }

        private void btn_TalTalmon_skype_Click(object sender, EventArgs e)
        {

        }
    }
}
