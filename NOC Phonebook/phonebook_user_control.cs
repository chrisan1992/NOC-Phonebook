﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Extensibility;
using NOC_Phonebook.Phonebook_Tabs;

namespace NOC_Phonebook
{

    /*
     * This class is to create a new User Control, in order to fill the main panel
     * */

    public partial class phonebook_user_control : UserControl
    {

        private static LyncCall call;
        private static agm_user_control agm_user_control;
        private static am_rc_user_control am_rc_user_control;
        private static anm_user_control anm_user_control;
        private static apm_user_control apm_user_control;
        private static ap_active_user_control ap_active_user_control;
        private static ap_trace_user_control ap_trace_user_control;
        private static art_user_control art_user_control;
        private static portal_user_control portal_user_control;
        private static db_user_control db_user_control;
        private static ppm_user_control ppm_user_control;
        private static saw_user_control saw_user_control;
        private static srl_user_control srl_user_control;
        private static srf_user_control srf_user_control;
        private static ucmdb_user_control ucmdb_user_control;
        private static crisis_user_control crisis_user_control;

        public phonebook_user_control()
        {
            InitializeComponent();

            //initialize call element
            call = new LyncCall();
            

            //AGM Tab
            agm_user_control = new agm_user_control();
            agm_user_control.Call = call;
            tabAGM.Controls.Clear();
            tabAGM.Controls.Add(agm_user_control);

            //AM RC Tab
            am_rc_user_control = new am_rc_user_control();
            am_rc_user_control.Call = call;
            tabAMRC.Controls.Clear();
            tabAMRC.Controls.Add(am_rc_user_control);

            //AnM Tab
            anm_user_control = new anm_user_control();
            anm_user_control.Call = call;
            tabAnM.Controls.Clear();
            tabAnM.Controls.Add(anm_user_control);

            //tabAPM
            apm_user_control = new apm_user_control();
            apm_user_control.Call = call;
            tabAPM.Controls.Clear();
            tabAPM.Controls.Add(apm_user_control);

            //tabAPActive
            ap_active_user_control = new ap_active_user_control();
            ap_active_user_control.Call = call;
            tabAPActive.Controls.Clear();
            tabAPActive.Controls.Add(ap_active_user_control);

            //tabAPTrace
            ap_trace_user_control = new ap_trace_user_control();
            ap_trace_user_control.Call = call;
            tabAPTrace.Controls.Clear();
            tabAPTrace.Controls.Add(ap_trace_user_control);

            //tabART
            art_user_control = new art_user_control();
            art_user_control.Call = call;
            tabART.Controls.Clear();
            tabART.Controls.Add(art_user_control);

            //tabPortal
            portal_user_control = new portal_user_control();
            portal_user_control.Call = call;
            tabPortal.Controls.Clear();
            tabPortal.Controls.Add(portal_user_control);

            //tabDB
            db_user_control = new db_user_control();
            db_user_control.Call = call;
            tabDB.Controls.Clear();
            tabDB.Controls.Add(db_user_control);

            //tabPPM
            ppm_user_control = new ppm_user_control();
            ppm_user_control.Call = call;
            tabPPM.Controls.Clear();
            tabPPM.Controls.Add(ppm_user_control);

            //tabSAW
            saw_user_control = new saw_user_control();
            saw_user_control.Call = call;
            tabSAW.Controls.Clear();
            tabSAW.Controls.Add(saw_user_control);

            //tabSRL
            srl_user_control = new srl_user_control();
            srl_user_control.Call = call;
            tabSRL.Controls.Clear();
            tabSRL.Controls.Add(srl_user_control);

            //tabSRF
            srf_user_control = new srf_user_control();
            srf_user_control.Call = call;
            tabSRF.Controls.Clear();
            tabSRF.Controls.Add(srf_user_control);

            //tabUCMDB
            ucmdb_user_control = new ucmdb_user_control();
            ucmdb_user_control.Call = call;
            tabUCMDB.Controls.Clear();
            tabUCMDB.Controls.Add(ucmdb_user_control);

            //tabCrisis
            crisis_user_control = new crisis_user_control();
            crisis_user_control.Call = call;
            tabCrisis.Controls.Clear();
            tabCrisis.Controls.Add(crisis_user_control);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a generic List object to contain the URI to call.
            // Edit this to provide a valid URI.
            List<string> participantUri = new List<string>();
            participantUri.Add("+506 72944567");
            //participantUri.Add("+972 3 5396852");

            // Start the conversation.
            LyncClient.GetAutomation().BeginStartConversation(
                AutomationModalities.Audio,
                participantUri,
                null,
                (ar) =>
                {
                    try
                    {
                        ConversationWindow newWindow = LyncClient.GetAutomation().EndStartConversation(ar);
                    }
                    catch (OperationException oe) { MessageBox.Show("Operation exception on start conversation " + oe.Message); };
                },
                null);
        }
    }
}
