using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFConsumerDec2021
{
    public partial class Tcp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.HelloNameServiceUClient client = new ServiceReference1.HelloNameServiceUClient("NetTcpBinding_IHelloNameServiceU");

            labelResult.Text = client.HelloName(textName.Text);
        }
    }
}