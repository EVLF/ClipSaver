using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipSaver.Forms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }


        private async void FadeOut(Form o, int interval = 80)
        {
            await Task.Delay(1000);
            while (o.Opacity > 0.0)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0;
            this.Close();
        }



        private void Splash_Load(object sender, EventArgs e)
        {


            FadeOut(this, 80);
           

        }
    }
}
