using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaçan_Buton
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

      
        private void btnevet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AALLLLLLAAHIIIMMMMM GOOOOLLLL", "<3");
            
        }

        private void btnyok_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(0, this.ClientSize.Width - btnyok.Width);
            int newY = random.Next(0, this.ClientSize.Height - btnyok.Height);

            btnyok.Location = new Point(newX, newY);
           


        }

        private void btnyok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayıp Oluyo Ama" , "Formu Küçültmek Yasakk!!");
        }

      

        private void btnyok_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(0, this.ClientSize.Width - btnyok.Width);
            int newY = random.Next(0, this.ClientSize.Height - btnyok.Height);
            btnyok.Location = new Point(newX, newY);
        }

       
    }
}
