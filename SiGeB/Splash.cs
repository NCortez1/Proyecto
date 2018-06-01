using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIF
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Cronometro.Start();
            
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            pbCargar.Increment(1);
            if(pbCargar.Value == 100)
            {
                Cronometro.Stop();
                Close();
            }
        }
    }
}
