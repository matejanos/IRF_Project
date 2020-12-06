using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    public partial class kezdolap : Form
    {
        public kezdolap()
        {
            InitializeComponent();
            int qw = 1;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    daysButton db = new daysButton();
                    db.Left = col * db.Width + (int)(Math.Floor((double)(col / 3)));
                    db.Top = row * db.Height + (int)(Math.Floor((double)(row / 3)));

                    if (qw % 7 == 0)
                    {
                        db.BackColor = Color.Red;
                        db.Name = qw.ToString();
                        db.Click += new EventHandler(this.button_click);
                        panel1.Controls.Add(db);
                    }
                    else if (qw % 6 == 0)
                    {
                        db.BackColor = Color.Blue;
                        db.Name = qw.ToString();
                        db.Click += new EventHandler(this.button_click);
                        panel1.Controls.Add(db);
                    }
                    else
                    {
                        db.Name = qw.ToString();
                        db.Click += new EventHandler(this.button_click);
                        panel1.Controls.Add(db);
                    }
                    qw++;
                }

            }
        }
        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "1")
            {
                Form1 f1 = new Form1();
                f1.Show();
            }
            if (btn.Name == "2")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if (btn.Name == "3")
            {
                Form3 f3 = new Form3();
                f3.Show();
            }
            if (btn.Name == "4")
            {
                Form4 f4 = new Form4();
                f4.Show();
            }
            if (btn.Name == "5")
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
            if (btn.Name == "6")
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
            if (btn.Name == "7")
            {
                Form7 f7 = new Form7();
                f7.Show();
            }
            if (btn.Name == "8")
            {
                Form8 f8 = new Form8();
                f8.Show();
            }
            if (btn.Name == "9")
            {
                Form9 f9 = new Form9();
                f9.Show();
            }
        }
    }
}
