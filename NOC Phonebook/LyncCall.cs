using Microsoft.Lync.Model;
using Microsoft.Lync.Model.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NOC_Phonebook
{
    public class LyncCall
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public LyncCall()
        {

        }

        /// <summary>
        /// Makes a call to the number in the parameter
        /// </summary>
        /// <param name="number">number to call</param>
        public void makeCall(String phoneNumber)
        {
            // Create a generic List object to contain the URI to call.
            // Edit this to provide a valid URI.
            List<string> participantUri = new List<string>();
            //participantUri.Add("506 72944567");
            //participantUri.Add("+972 3 5396852");
            participantUri.Add(phoneNumber);

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
