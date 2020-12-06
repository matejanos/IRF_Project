using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class daysButton : Button
    {
        public daysButton()
        {
            Height = 70;
            Width = Height;
            BackColor = Color.Azure;
            Font = new Font("Segoe MDL2 Assets", 12);
            Text = "\uED56";
        }
    }
}
