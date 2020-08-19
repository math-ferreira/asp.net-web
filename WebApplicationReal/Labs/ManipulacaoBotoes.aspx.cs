using java.nio.file;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.IO;
using System.Web.Caching;

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

        public void btn_Baixar(Object sender, EventArgs e)
        {
            teste_arquivo("testeMath", DateTime.Now);
        }

        public void teste_arquivo(String textoCache, DateTime dateTime)
        {
            string path = HttpContext.Current.Server.MapPath("~//files");
            IEnumerable<string> filesIni = System.IO.Directory.EnumerateFiles(path,
                                                  "*.*",
                                                   System.IO.SearchOption.AllDirectories);

            for (int i = 0; i < filesIni.OfType<String>().Count(); i++)
            {
                Debug.WriteLine("Aqui: " + filesIni.ElementAt(i));
            }

            try
            {
                var files = from file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories)
                            from line in File.ReadLines(file)

                            select new
                            {
                                File = file,
                                Line = line
                            };

                foreach (var f in files)
                {
                    Debug.WriteLine("Aqui 01:" + $"{f.File}\t{f.Line}");
                }
                Debug.WriteLine("Aqui 02:" + $"{files.Count().ToString()} files found.");
            }
            catch (UnauthorizedAccessException uAEx)
            {
                Debug.WriteLine(uAEx.Message);
            }
            catch (PathTooLongException pathEx)
            {
                Debug.WriteLine(pathEx.Message);
            }

            // Verifica se ja existe o arquivo em path
            path = HttpContext.Current.Server.MapPath("~//files//cache.txt");
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                string createText = "ARQUIVO COMEÇA AQUI:  ";
                File.WriteAllText(path, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "Texto: " + textoCache + " e dateTime: " + dateTime + " - ";
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            String console = "console.log('" + readText + "');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", console, true);
            Console.WriteLine(readText);
        }

        public void btn_Session(Object sender, EventArgs e)
        {
            string firstName, lastName, city;
            if (Session["FirstName"] == null)
            {
                firstName = "Jeff";
                Session["FirstName"] = firstName;
            }
            if (Session["LastName"] == null)
            {
                lastName = "Smith";
                Session["LastName"] = lastName;
            }
            if (Session["City"] == null)
            {
                city = "Seattle";
                Session["City"] = city;
            }

            firstName = (string)(Session["FirstName"]);
            lastName = (string)(Session["LastName"]);
            city = (string)(Session["City"]);
        }

        public void btn_Cache_HTTPContext(Object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;

            string cachedString = (string)context.Cache["chave1"];
            if (cachedString == null)
            {
                var objetoCacheado = "Objeto no Cache 1";
                //Absolute Expiration
                Cache.Insert("chave1", objetoCacheado, null, DateTime.Now.AddMinutes(2),
                            System.Web.Caching.Cache.NoSlidingExpiration);
            }

            Debug.WriteLine("Aqui a chave 1: " + (string)context.Cache["chave1"]);

        }
        public void btn_Cache_HTTPRuntime(Object sender, EventArgs e)
        {
            
            var cachedString = HttpRuntime.Cache.Get("chave2");
            if (cachedString == null)
            {
                HttpRuntime.Cache.Insert("chave2", "Objeto no Cache 2");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "console.log('NÃO tem cache');", true);

            } else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "ErrorAlert", "console.log('TEM cache');", true);
            }

            Debug.WriteLine("Aqui a chave 2: " + HttpRuntime.Cache.Get("chave2"));
        }
    }
}