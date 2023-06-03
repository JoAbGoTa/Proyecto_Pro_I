using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyecto
{
    public partial class pacont : Form
    {
        public pacont()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmax.Visible = false;
            btnmaxx.Visible = true;
        }

        private void btnmaxx_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnmaxx.Visible = false;
            btnmax.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void abrirformhija(object formhija)
        {
            if (this.panelcont.Controls.Count > 0) 
              this.panelcont.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcont.Controls.Add(fh);
            this.panelcont.Tag = fh;
            fh.Show();
        }
       

        

        private void panelcont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            abrirformhija(new Form3());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelcont_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }
    } 
}

