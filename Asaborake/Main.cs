using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreTweet;

namespace Asaborake
{
    public partial class Main : Form
    {
        private OAuth.OAuthSession _session;
        private Tokens _tokens;
        private string _authedScreenName;
        private string _tweet_text;
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void current_account_label_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            String consumer_key = ConfigurationManager.AppSettings["consumer_key"];
            String consumer_secret = ConfigurationManager.AppSettings["consumer_secret"];
            _session = OAuth.Authorize(consumer_key, consumer_secret);
            System.Diagnostics.Process.Start(_session.AuthorizeUri.AbsoluteUri);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pin = pin_textbox.Text;
            if (pin != null)
            {
                _tokens = OAuth.GetTokens(_session, pin);
                if (_tokens != null)
                {
                    auth_button.Enabled = false;
                    pin_input_button.Enabled = false;
                    _authedScreenName = _tokens.ScreenName;
                    auth_complete_label.Visible = true;
                    authed_account_label.Text = "@" + _authedScreenName;
                    authed_account_label.Visible = true;

                }
            }
        }

        private void tweet_button_Click(object sender, EventArgs e)
        {
            if (_tokens != null)
            {
                _tweet_text = tweet_textbox.Text;
                _tokens.Statuses.Update(new { status = _tweet_text });
                tweet_textbox.Text = "";
            }
        }
    }
}
