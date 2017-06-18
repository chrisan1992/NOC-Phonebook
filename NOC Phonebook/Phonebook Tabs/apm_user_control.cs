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
    public partial class apm_user_control : UserControl
    {
        private static LyncCall call;

        public apm_user_control()
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

        private void btn_JavierMora_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 70126952");
        }

        private void btn_JavierMora_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_Joseiby_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 8888213");
        }

        private void btn_Joseiby_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_KarvinGraham_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 89692626");
        }

        private void btn_KarvinGraham_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_ErikaMadrigal_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 86354271");
        }

        private void btn_ErikaMadrigal_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alexfurman_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972546620319");
        }

        private void btn_AlexFurman_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_ZhakerShalah_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972546335263");
        }

        private void btn_ZhakerShalah_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_KfirYogev_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972549955674");
        }

        private void btn_KfirYogev_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_IgalBarboy_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+972506380116");
        }

        private void btn_IgalBarboy_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_DiegoClachar_mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("+506 88634118");
        }

        private void btn_DiegoClachar_skype_Click(object sender, EventArgs e)
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
