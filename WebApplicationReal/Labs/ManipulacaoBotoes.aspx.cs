using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationReal.Labs
{
    public partial class ManipulacaoBotoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btn1_Click(Object sender, EventArgs e)
        {
            Debug.WriteLine("Clicou botao 1");
            btn1.BackColor = System.Drawing.Color.Red;
            btn2.BackColor = System.Drawing.Color.Gray;
            btn2.Font.Bold = false;
            btn2.ForeColor = System.Drawing.Color.Black;
        }

        public void btn2_Click(Object sender, EventArgs e)
        {
            Debug.WriteLine("Clicou botao 2");
            btn2.Font.Bold = true;
            btn2.ForeColor = System.Drawing.Color.Red;
            btn1.BackColor = System.Drawing.Color.Gray;
        }
        public void btn3_Click(Object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "msg", "<script language=javascript>functionBtn3();</script>");
        }
    }
}