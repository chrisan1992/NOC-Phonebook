using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetLabels(String contactName, String mobileNumber, String skypeNumber)
        {
            lblContactName.Text = "Contact Name: " + contactName;
            lblMobileNumber.Text = "Mobile Number: " + mobileNumber;
            lblSkypeNumber.Text = "Skype Number: " + skypeNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
