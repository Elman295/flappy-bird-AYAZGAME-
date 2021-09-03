using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYAZgame
{
    public partial class Form1 : Form
    {

        int speed = 20;
        int gravity = 5;
        int s = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            
            bird.Top += gravity;
            tree.Left -= 8;
            cloud.Left -= 8;
            score.Text = "" + s;
            if (tree.Left < -50)
            {
                tree.Left = 300;
                s++;
             
            }
            if (cloud.Left < -30)
            {
                cloud.Left = 200;
                s++;
             
            }
            if(bird.Bounds.IntersectsWith(tree.Bounds)||
                bird.Bounds.IntersectsWith(cloud.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds))
            {
                end();
            }
        }

        private void keydown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }

        }

        private void keyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        public void end()
        {
            timer.Stop();
            MessageBox.Show("end game");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
