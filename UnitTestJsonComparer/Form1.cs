using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UnitTestJsonComparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_Enter(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            if (input.IndexOf("Expected:<{") == -1
                || input.IndexOf("Actual:<{") == -1)
            {
                txtInput.Text =
                    txtActual.Text =
                    txtExpected.Text = "";
                return;
            }

            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"Expected:<(.+?)>\..*?Actual:<(.+?)>\..*",
              RegexOptions.Compiled);

            // Find matches.
            MatchCollection matches = rx.Matches(txtInput.Text);
            
            if (matches.Any())
            {
                var match = matches.First();
                var expected = match.Groups[1].Value;
                var actual = match.Groups[2].Value;

                txtExpected.Text = JToken.Parse(expected).ToString(Formatting.Indented);
                txtActual.Text = JToken.Parse(actual).ToString(Formatting.Indented);
            }
        }
    }
}
