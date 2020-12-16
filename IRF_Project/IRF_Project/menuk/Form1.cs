using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form1 : Form
    {
        List<menus> menuList = new List<menus>();
        public Form1()
        {
            InitializeComponent();
            xmlBeolvasas();
            linq();
            button1.Text = "\uEA5E";
        }

        private void linq()
        {
            var resultL = from d in menuList
                          where d.ID == 1
                          select d.Leves.ToString();
            textBox1.Text = resultL.FirstOrDefault();

            var resultF = from f in menuList
                          where f.ID == 1
                          select f.Foetel.ToString();
            textBox2.Text = resultF.FirstOrDefault();

            var resultD = from e in menuList
                          where e.ID == 1
                          select e.Desszert.ToString();
            textBox3.Text = resultD.FirstOrDefault();
        }

        private void xmlBeolvasas()
        {
            XmlDocument menus = new XmlDocument();
            menus.Load("etlap.xml");
            foreach (XmlElement element in menus.DocumentElement)
            {
                var menu = new menus();
                menuList.Add(menu);
                menu.Leves = element.Attributes["leves"].Value;
                menu.Foetel = element.Attributes["foetel"].Value;
                menu.Desszert = element.Attributes["desszert"].Value;
                menu.ID = int.Parse(element.InnerText);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider();          
        }

        private void errorProvider()
        {
            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Töltsd ki!");
            }
            else if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Töltsd ki!");
            }
            else if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Töltsd ki!");
            }
            else
            {
                errorProvider1.Clear();
                csvWriter();
            }
        }

        private void csvWriter()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Rendelés (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("Leves");
                sw.Write(";");
                sw.Write("Főétel");
                sw.Write(";");
                sw.Write("Desszert");
                sw.Write(";");
                sw.Write("Ital");
                sw.Write(";");
                sw.Write("Város");
                sw.Write(";");
                sw.Write("Utca");
                sw.Write(";");
                sw.Write("Házszám:");
                sw.WriteLine();
                sw.Write(textBox1.Text);
                sw.Write(";");
                sw.Write(textBox2.Text);
                sw.Write(";");
                sw.Write(textBox3.Text);
                sw.Write(";");
                sw.Write(drink1.Text);
                sw.Write(";");
                sw.Write(textBox4.Text);
                sw.Write(";");
                sw.Write(textBox5.Text);
                sw.Write(";");
                sw.Write(textBox6.Text);
            }
        }

    }
}
