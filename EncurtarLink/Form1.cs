using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncurtarLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try

            {

                DataSet ds = new DataSet();

                string apiMigreMe = "http://migre.me/api.xml?url=" + txtUrl.Text;

                Application.DoEvents();

                ds.ReadXml(apiMigreMe);

                //O retorno vem em formato XML
                //<? xml version = "1.0" encoding = "ISO-8859-1" ?>
                //    < item >
                //    < error > 0 </ error >
                //    < errormessage > OK </ errormessage >
                //< created_at > 2011 - 04 - 01 20:26:44 </ created_at >
                //    < source > site </ source >
                //    < date > 2011 - 04 - 01 20:26:44 </ date >
                //    < id > 4ahU7 </ id >
                //    < url > http://www.google.com.br/search?hl=pt-BR&q=infopod</url>
                //< migre > http://migre.me/4ahU7</migre>
                //< category > free </ category >
                //    < time > 0.00839495658875 </ time >
                //    </ item >

                txtMigreMe.Text = ds.Tables[0].Rows[0]["migre"].ToString();

            }

            catch (Exception ex)

            {

                throw ex;

            }

        }
    }
}
