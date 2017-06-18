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

        private void btn_keerthi_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("91  9677181157");
        }

        private void btn_keerthi_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_AnandMamadapur_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("91  9880508508");
        }

        private void btn_Vaasuthevan_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("91 9962537685");
        }

        private void btn_Vaasuthevan_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_DileepPerumal_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("91  9994191448");
        }

        private void btn_DileepPerumal_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_IgalBarboy_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972506380116");
        }

        private void btn_IgalBarboy_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_YossiShpirer_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972525697029");
        }

        private void btn_YossiShpirer_skype_Click(object sender, EventArgs e)
        {

        }
    }
}
