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
    public partial class alm_qc_user_control : UserControl
    {
        private static LyncCall call;

        public alm_qc_user_control()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {

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
