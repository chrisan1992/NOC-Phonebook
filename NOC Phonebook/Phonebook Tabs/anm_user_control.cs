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
    public partial class anm_user_control : UserControl
    {
        private static LyncCall call;

        public anm_user_control()
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

        private void btn_MarioMora_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 83443195");
        }

        private void btn_MarioMora_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_LitalAlon_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972509552021");
        }

        private void btn_LitalAlon_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_MosheBoim_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972-50-3137636");
        }

        private void btn_MosheBoim_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_TalHilzenrat_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972-54-4497009");
        }

        private void btn_TalHilzenrat_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_EliaJahshan_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972503137566");
        }

        private void btn_EliaJahshan_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_MeravMeizler_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972-50-3137633");
        }

        private void btn_MeravMeizler_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_JacobSaleh_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("	+972-546-818525");
        }

        private void btn_JacobSaleh_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_Davidsalkin_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972-54-4497037");
        }

        private void btn_Davidsalkin_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_InasShamsi_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972503137671");
        }

        private void btn_InasShamsi_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_TsahhiSharon_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972506474284");
        }

        private void btn_TsahhiSharon_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_MosheMamia_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972503137667");
        }

        private void btn_MosheMamia_skype_Click(object sender, EventArgs e)
        {

        }
    }
}
