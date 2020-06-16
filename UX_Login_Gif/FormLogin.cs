using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UX_Login_tenis
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetColorButtom(Button btn)
        {

            btn.BackColor = (btn.BackColor.Equals(Color.Black)) 
                ? Color.DarkRed :
                Color.Black;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimizar_MouseHover(object sender, EventArgs e)
        {
            SetColorButtom(btnMinimizar);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            SetColorButtom(btnMinimizar);
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            SetColorButtom(btnLogin);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            SetColorButtom(btnLogin);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            SetColorButtom(btnExit);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            SetColorButtom(btnExit);
        }

        /* START movement FORM */
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();

            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm(sender, e);
        }
        /* END movement FORM */


       
    }
}
