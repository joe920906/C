using System;
using System.Drawing;
using System.Windows.Forms;

namespace _13_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblTrafficLight.BackColor = Color.Red;
            lblTrafficLight.Text = "¬õ¿O";
            lblTrafficLight.TextAlign = ContentAlignment.MiddleCenter;
            lblTrafficLight.Dock = DockStyle.Fill;
        }

        private void lblTrafficLight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblTrafficLight.BackColor = Color.Yellow;
                lblTrafficLight.Text = "¶À¿O";
            }
            else if (e.Button == MouseButtons.Right)
            {
                lblTrafficLight.BackColor = Color.Green;
                lblTrafficLight.Text = "ºñ¿O";
            }
        }
    }
}
