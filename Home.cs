using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietAttic
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.ShowDialog();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            Staff form = new Staff();
            form.ShowDialog();
        }

        private void staffTypeBtn_Click(object sender, EventArgs e)
        {
            StaffType form = new StaffType();
            form.ShowDialog();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            Location form = new Location();
            form.ShowDialog();
        }

        private void propertyBtn_Click(object sender, EventArgs e)
        {
            Property form = new Property();
            form.ShowDialog();
        }

        private void propertyTypeBtn_Click(object sender, EventArgs e)
        {
            PropertyType form = new PropertyType();
            form.ShowDialog();
        }
    }
}
