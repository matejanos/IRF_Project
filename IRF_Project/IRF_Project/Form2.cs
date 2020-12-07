using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_Project
{
    public partial class Form2 : Form
    {
        List<menus> menuList = new List<menus>();
        public Form2()
        {
            InitializeComponent();
            xmlBeolvasas();
            linq();
        }

        private void linq()
        {
            var resultL = from d in menuList
                          where d.ID == 2
                          select d.Leves.ToString();
            textBox1.Text = resultL.FirstOrDefault();

            var resultF = from f in menuList
                          where f.ID == 2
                          select f.Foetel.ToString();
            textBox2.Text = resultF.FirstOrDefault();

            var resultD = from e in menuList
                          where e.ID == 2
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
    }
}
