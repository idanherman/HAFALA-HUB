using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nohal_Zahav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        Bunifu.Framework.UI.Drag moveform = new Bunifu.Framework.UI.Drag();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveform.Grab(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moveform.Release();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            moveform.MoveObject();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Filesystemsautomation_button_Click(object sender, EventArgs e)
        {
            page_FSAuto11.BringToFront();
        }

        private void Tools_Button_Click(object sender, EventArgs e)
        {
            page_Tools1.BringToFront();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            page_Menu1.BringToFront();
        }
    }
}
