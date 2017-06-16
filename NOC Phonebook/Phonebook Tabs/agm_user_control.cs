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
    public partial class agm_user_control : UserControl
    {

        private static LyncCall call;

        public agm_user_control()
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

        private void btn_SergioMonge_Mobile_Click(object sender, EventArgs e)
        {
            call.makeCall("506 88971861");
        }

        private void btn_SergioMonge_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_BinXu_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_BinXu_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_SophieAlush_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_SophieAlush_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_AminHabash_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_AminHabash_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_GititNevo_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_GititNevo_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_Anatoly_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_Anatoly_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_AvitalKarni_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_AvitalKarni_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_ItayLaxer_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_ItayLaxer_skype_Click(object sender, EventArgs e)
        {

        }

        private void btn_VadimWaisman_mobile_Click(object sender, EventArgs e)
        {

        }

        private void btn_VadimWaisman_skype_Click(object sender, EventArgs e)
        {

        }
    }
}
