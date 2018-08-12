using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class UserControl3 : UserControl
    {

        private Boolean color;
        private Boolean nombre;
        private Boolean lugar;

        public UserControl3()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (e.Equals(true)) color=true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (e.Equals(true)) nombre = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (e.Equals(true)) lugar = true;
        }
    }
}
