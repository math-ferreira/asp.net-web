using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationReal.Labs
{
    public partial class EstracaoRelatorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void ExportListFromGridView(Object sender, EventArgs e)
        {
 
            if (rbEmAnalise.Checked)
            {
     
            }

            Response.ClearContent();
            Response.AddHeader("content-disposition", "attachment;filename=Contact.xls");
            Response.AddHeader("Content-Type", "application/vnd.ms-excel");
            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                using (System.Web.UI.HtmlTextWriter htw = new System.Web.UI.HtmlTextWriter(sw))
                {
                    GridView grid = new GridView();
                    grid.DataSource = null;
                    grid.DataBind();
                    grid.RenderControl(htw);
                    Response.Write(sw.ToString());
                }
            }

            Response.End();
        }

        public void rbEmAnalise_Click(Object sender, EventArgs e)
        {
            rbEmAnalise.Checked = true;
            rbParaAnalise.Checked = false;
        }
        public void rbParaAnalise_Click(Object sender, EventArgs e)
        {
            rbParaAnalise.Checked = true;
            rbEmAnalise.Checked = false;
        }

    }
}