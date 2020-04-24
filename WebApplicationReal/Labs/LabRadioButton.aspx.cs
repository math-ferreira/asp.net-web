using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationReal
{
    public partial class LabRadioButton : Page
    {
        private NOMQBS simulaTransacao;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            labelTeste.Visible = false;
        }

        public void btnListao_Click(Object sender, EventArgs e)
        {
            Debug.WriteLine("Entrou no click do botão Listao!");
            labelTeste.Text = "Esse é o Listão";
            labelTeste.Visible = true;
            rbEmAnalise.Visible = false;
            rbParaAnalise.Visible = false;

        }
        public void btnListaoFraude_Click(Object sender, EventArgs e)
        {
            Debug.WriteLine("Entrou no click do botão Listao Fraude!");
            simulaTransacao = new NOMQBS();
            
            rbEmAnalise.Visible = true;
            rbParaAnalise.Visible = true;

        }

        public void rbEmAnalise_Click(Object sender, EventArgs e)
        {
                Debug.WriteLine("Entrou no click do Radio Button 1!");
            rbParaAnalise.Checked = false;

        }

        public void rbParaAnalise_Click(Object sender, EventArgs e)
        {
            //Debug.WriteLine("aqui: " + this.xmlRetorno);
            Debug.WriteLine("Entrou no click do Radio Button 2!");
            rbEmAnalise.Checked = false;





        }
    }
}