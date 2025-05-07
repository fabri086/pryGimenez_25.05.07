using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGimenez_25._05._07
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            comboBox1.Items.Add("Heroe");
            comboBox1.Items.Add("heroe");
            comboBox1.Items.Add("antiheroe");

            comboBox1.SelectedIndex = 0;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
