using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml;

namespace BinaryClock
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


        

        //atklikkelhetove tevo kod.

        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(IntPtr hWnd, GWL nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(IntPtr hWnd, GWL nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte alpha, LWA dwFlags);

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int wl = GetWindowLong(this.Handle, GWL.ExStyle);
            wl = wl | 0x80000 | 0x20;
            SetWindowLong(this.Handle, GWL.ExStyle, wl);
            SetLayeredWindowAttributes(this.Handle, 0, 128, LWA.Alpha);
        }

        //Idaig Tart.

        private void szinValtas(object sender, EventArgs e)
        {

        }

        private void szinValtasOra(object sender, EventArgs e)
        {

        }

        private void szinValtasPerc(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ora = DateTime.Now.Hour;
            int perc = DateTime.Now.Minute;
            int masodperc = DateTime.Now.Second;
            label1.Text = BinaryClock.Program.Binarizalo(ora);
            label2.Text = BinaryClock.Program.Binarizalo(perc);
            label3.Text = BinaryClock.Program.Binarizalo(masodperc);

            if (masodperc % 2 == 1)
                pictureBox13.BackColor = Color.Black;
            else
                pictureBox13.BackColor = Color.Gold;
            if (masodperc % 4 == 2 || masodperc % 4 == 3)
                pictureBox12.BackColor = Color.Black;
            else
                pictureBox12.BackColor = Color.Gold;
            if (masodperc % 8 >= 4 && masodperc % 8 <= 7)
                pictureBox14.BackColor = Color.Black;
            else
                pictureBox14.BackColor = Color.Gold;
            if (masodperc % 16 >= 8 && masodperc%16 <= 15)
                pictureBox15.BackColor = Color.Black;
            else
                pictureBox15.BackColor = Color.Gold;
            if (masodperc % 32 >= 16 && masodperc % 32 <= 31)
                pictureBox16.BackColor = Color.Black;
            else
                pictureBox16.BackColor = Color.Gold;
            if (masodperc >= 32)
                pictureBox17.BackColor = Color.Black;
            else
                pictureBox17.BackColor = Color.Gold;


            if (perc % 2 == 1)
                pictureBox7.BackColor = Color.Black;
            else
                pictureBox7.BackColor = Color.Gold;
            if (perc % 4 == 2 || perc % 4 == 3)
                pictureBox8.BackColor = Color.Black;
            else
                pictureBox8.BackColor = Color.Gold;
            if (perc % 8 >= 4 && perc % 8 <= 7)
                pictureBox9.BackColor = Color.Black;
            else
                pictureBox9.BackColor = Color.Gold;
            if (perc % 16 >= 8 && perc%16 <= 15)
                pictureBox10.BackColor = Color.Black;
            else
                pictureBox10.BackColor = Color.Gold;
            if (perc % 32 >= 16 && perc % 32 <= 31)
                pictureBox2.BackColor = Color.Black;
            else
                pictureBox2.BackColor = Color.Gold;
            if (perc >= 32)
                pictureBox11.BackColor = Color.Black;
            else
                pictureBox11.BackColor = Color.Gold;


            if (ora % 2 == 1)
                pictureBox1.BackColor = Color.Black;
            else
                pictureBox1.BackColor = Color.Gold;
            if (ora % 4 == 2 || ora % 4 == 3)
                pictureBox3.BackColor = Color.Black;
            else
                pictureBox3.BackColor = Color.Gold;
            if (ora % 8 >= 4 && ora % 8 <= 7)
                pictureBox4.BackColor = Color.Black;
            else
                pictureBox4.BackColor = Color.Gold;
            if (ora % 16 >= 8 && ora%16 <= 15)
                pictureBox5.BackColor = Color.Black;
            else
                pictureBox5.BackColor = Color.Gold;
            if (ora % 32 >= 16 && ora % 32 <= 31)
                pictureBox6.BackColor = Color.Black;
            else
                pictureBox6.BackColor = Color.Gold;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.End)
            {
                Application.Exit(); 
            }
        }
    }
}
