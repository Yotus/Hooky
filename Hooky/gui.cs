using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hooky
{
    private static readonly HttpClient client = new HttpClient();
    public partial class gui : Form
    {
        public gui()
        {
            InitializeComponent();
        }

        private void gui_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string startme = "{%  \"content\": \"";
            string content = textBox1.Text;
            string endme = "\"%}";
            {
                startme = Text.Replace("%", System.Environment.NewLine);
                content = Text.Replace(System.Environment.NewLine, "\\");
                endme = Text.Replace("%", System.Environment.NewLine);
                {
                    string send = (startme + content + endme);
                    {
                        string sendURL = "https://discordapp.com/api/webhooks/397658716909993984/rtkqIcfZgnGn2jj9eoOrI6tfWp3cvPhbZB0UKBuoYcBFViJScMtrrtxtSGWI6RtIPR_2";

                        var request = new Request();
                        var user = send;

                        var response = (httpresponse)request.Execute<httpresponse>(sendURL, user, "POST");
                    }
                }
            }
            

            textBox1.Text = String.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addNewBot addNewBot = new addNewBot();
            {
                addNewBot.Show();
            }
        }
    }
}
