using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook
{
    public partial class dashboard_user_control : UserControl
    {
        public dashboard_user_control()
        {
            InitializeComponent();
            //Panel[] paneles = new Panel[5];//number of rows from the query
            /*for (int i = 0; i < 5; ++i)
            {
                
            }*/
        }

        /// <summary>
        /// Search from the User controls the one specified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}







/*
 * 
 * 
 * LinkLabel[] arrLbl = new LinkLabel[5];

for (int i = 0; i < 5; i++)
{
   LinkLabel lbl = new LinkLabel();
   lbl.Text = "Label: " + i.ToString();
   arrLbl[i] = lbl;
}

foreach (Control c in arrLbl)
  this.Controls.Add(c);
 * 
 * 
 * */
