using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Wordlookup
{
    public partial class Form1 : Form
    {
        #region stuff
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetAsyncKeyState(int vkey);

        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, uint dwExtraInf);
        //SHIFT +
        //CTRL ^
        //ALT %

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        #endregion

        List<string> words = new List<string>();

        void InvokeKeydown(Keys key)
        {
            byte vk = (byte)key;
            //keybd_event(vk, 0, 0, UIntPtr.Zero);
        }

        void InvokeKeyup(Keys key)
        {
            byte vk = (byte)key;
            //  keybd_event(vk, 0, 2, UIntPtr.Zero);
        }

        public Form1()
        {
            InitializeComponent();
        }

        void sendNewTab()
        {
            SendKeys.Send("^t");
        }
        void sendEnter()
        {
            SendKeys.Send("{ENTER}");
        }

        void getWords()
        {
            words.Clear();

            string[] lines = txtWords.Lines;
            foreach (string s in lines)
            {
                words.Add(s);
            }
        }

        void regSearch()
        {
            getWords();

            foreach (string s in words)
            {
                sendNewTab();
                System.Threading.Thread.Sleep((int)numDelay.Value);
                SendKeys.Send(txtBefore.Text + " " + s + " " + txtAfter.Text);
                System.Threading.Thread.Sleep((int)numDelay.Value);
                sendEnter();
                System.Threading.Thread.Sleep((int)numDelay.Value);
            }

        }

        void specificSearch(string addr)
        {
            getWords();


            foreach (string s in words)
            {
                sendNewTab();
                SendKeys.Send(addr);

                System.Threading.Thread.Sleep((int)numDelay.Value);
                sendEnter();

                System.Threading.Thread.Sleep((int)numPageLoadDealy.Value);
                SendKeys.Send(s);
                System.Threading.Thread.Sleep((int)numDelay.Value);
                sendEnter();
                System.Threading.Thread.Sleep((int)numDelay.Value);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);

            if (!chkSpecific.Checked)
            {
                regSearch();
            }
            else
            {
                if (radWikipedia.Checked)
                {
                    specificSearch("https://www.wikipedia.org/");
                }
                else if (radDict.Checked)
                {
                    specificSearch("http://dictionary.reference.com/");
                }
                else if (radThesarus.Checked)
                {
                    specificSearch("http://www.thesaurus.com/");
                }
            }
        }

        private void chkSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpecific.Checked)
            {
                pnlSpecific.Visible = true;
            }
            else
            {
                pnlSpecific.Visible = false;
            }

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //http://goo.gl/forms/tAw50uQN8D
            Process.Start("http://goo.gl/forms/tAw50uQN8D");
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            string msg = "Instructions: Enter a list of words/phrases in the box, then press go.\n For a more refined search you can use the text before and after\n boxes to add search terms before and after your words \n and/or phrases. Ex: (define *word*).\n Additionally you can use the specific sites box to specify \n where to search. The delays can be used to adjust the time \n waited between pages (in miliseconds). Note that some pages may\n require more time than others.\n";
            MessageBox.Show(msg,"Instructions!");
        }
    }
}
