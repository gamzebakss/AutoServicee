using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class IslemEkleForm : Form
    {
        public IslemEkleForm()
        {
            InitializeComponent();
        }

        private void IslemEkleForm_Load(object sender, EventArgs e)
        {
            cmbIslemler.DataSource = IslemControllers.Listele();
            cmbIslemler.DisplayMember = "Ad";
            cmbIslemler.ValueMember = "id";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
