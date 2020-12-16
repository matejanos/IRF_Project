using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project
{
    class drink : ComboBox
    {
        public drink()
        {
            SelectedText = "Semmi";
            Items.Add("Víz");
            Items.Add("Gyümölcslé");
            Items.Add("Cola");
            Items.Add("Sör");
            Items.Add("Bor");
        }
    }
}
