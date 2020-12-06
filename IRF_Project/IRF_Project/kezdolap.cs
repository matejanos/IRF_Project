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
                        panel1.Controls.Add(db);
                    }
                    if (qw % 6 == 0)
                    {
                        db.BackColor = Color.Blue;
                        db.Name = qw.ToString();
                        panel1.Controls.Add(db);
                    }
                    else
                    {
                        db.Name = qw.ToString();
                        panel1.Controls.Add(db);
                    }
                    qw++;
                }

            }
        }
    }
}
