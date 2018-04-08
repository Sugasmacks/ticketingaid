using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using BadlandsLSPDTicketingAid;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int VersionCheckedToday = 0;
        int months = 0;
        int mCounter = 0;
        int fmCounter = 0;
        int totalMonths = 0;
        int fine = 0;
        int fCounter = 0;
        int ffCounter = 0;
        int totalFines = 0;
        int IV = 0;
        int ImpoundVehicle = 0;
        int SV = 0;
        int SeizeVehicle = 0;
        int SVL = 0;
        int SeizeVehicleLicense = 0;
        int SFL = 0;
        int SeizeFirearmLicense = 0;
        int restitution = 0;
        int restitutiontotal = 0;
        //   private EventHandler trackBar1_ValueChanged;

        //private EventHandler trackBar1_ValueChanged;

        public Form1()
        {
            InitializeComponent();
            trackBar1.ValueChanged += trackBar1_Scroll;
            trackBar2.ValueChanged += trackBar2_Scroll;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //   this.Size = new Size(1147, 786);

        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_Load(object sender, EventArgs e)
        {

            //
            //       Form2 f2 = new Form2();
            //   f2.Show(this);
            //  checkBox27.Click += checkBox27_CheckedChanged;
            //  this.Size = new Size(1147, 786);
            KeyPreview = true;
        }
        // MOVE WINDOW WITH LEFT MOUSE START

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                        int Msg, int wParam, int lParam);
       [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
              //  mouseDown = true;
             //   lastLocation = e.Location;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 1000;
            if (checkBox1.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 1000;
            if (checkBox2.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            months = 5;
            fine = 500;
            if (checkBox3.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 250;
            if (checkBox4.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            months = 3;
            fine = 500;
            if (checkBox5.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 1000;
            if (checkBox6.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            months = 3;
            fine = 1000;
            if (checkBox7.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 750;
            if (checkBox8.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 250;
            if (checkBox9.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 500;
            if (checkBox10.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 250;
            if (checkBox11.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 500;
            if (checkBox12.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            months = 3;
            fine = 600;
            if (checkBox13.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            months = 2;
            fine = 1250;
            if (checkBox14.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 3000;
            if (checkBox15.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            months = 5;
            fine = 2500;
            if (checkBox16.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            months = 6;
            fine = 5000;
            if (checkBox17.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 8000;
            if (checkBox18.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 7500;
            if (checkBox19.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            months = 5;
            fine = 2000;
            if (checkBox20.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 6000;
            SeizeFirearmLicense = 1;
            if (checkBox21.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            months = 6;
            fine = 3500;
            if (checkBox22.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 6500;
            if (checkBox23.Checked)
            {
                monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0");
                checkBox34.Enabled = false;
                allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString();
            }
            else
            {
                allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString();
                if (checkBox24.Checked) { checkBox34.Enabled = false; } else { checkBox34.Enabled = true; }
                monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text =
                (fCounter = fCounter - fine).ToString("C0");
            }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            months = 14;
            fine = 10000;
            if (checkBox24.Checked)
            {
                monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0");
                checkBox34.Enabled = false;
                allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString();
            }
            else
            {
                allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString();
                if (checkBox23.Checked) { checkBox34.Enabled = false; } else { checkBox34.Enabled = true; }
                monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text =
                (fCounter = fCounter - fine).ToString("C0");
            }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 2000;
            if (checkBox25.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            months = 5;
            fine = 8000;
            if (checkBox26.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }
        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 5000;
            if (checkBox27.Checked)
            {
                monthsSum.Text = (mCounter = mCounter + months).ToString();
                fineSum.Text = (fCounter = fCounter + fine).ToString("C0");
                checkBox14.Enabled = false;
                allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString();
            }
            else
            {
                allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString();
                if (checkBox41.Checked) { checkBox14.Enabled = false; checkBox14.Checked = false; checkBox14.Click -= checkBox14_CheckedChanged; }
                monthsSum.Text = (mCounter = mCounter - months).ToString();
                fineSum.Text = (fCounter = fCounter - fine).ToString("C0");
                if (checkBox27.Enabled) { checkBox14.Enabled = true; }
            }
            if (checkBox14.Checked) { checkBox14.Checked = false; checkBox14.Click -= checkBox14_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 6000;
            if (checkBox28.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 6500;
            SeizeVehicleLicense = 1;
            if (checkBox29.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fineSum.Text = (fCounter = fCounter + fine).ToString("C0"); SVLSum.Text = (SVL = SVL + SeizeVehicleLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); } else { allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fineSum.Text = (fCounter = fCounter - fine).ToString("C0"); SVLSum.Text = (SVL = SVL - SeizeVehicleLicense).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            months = 18;
            fine = 16000;
            restitution = 8000;
            if (checkBox30.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); }
            else
            {
                RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString();
                {
                    checkBox31.Enabled = true; checkBox32.Enabled = true; checkBox33.Enabled = true; checkBox34.Enabled = true; checkBox35.Enabled = true; checkBox36.Enabled = true; checkBox37.Enabled = true;
                    monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0");
                }
            }
            if (checkBox30.Checked) { checkBox31.Enabled = false; checkBox31.Checked = false; checkBox31.Click -= checkBox31_CheckedChanged; }
            if (checkBox30.Checked) { checkBox32.Enabled = false; checkBox32.Checked = false; checkBox32.Click -= checkBox32_CheckedChanged; }
            if (checkBox30.Checked) { checkBox33.Enabled = false; checkBox33.Checked = false; checkBox33.Click -= checkBox33_CheckedChanged; }
            if (checkBox30.Checked) { checkBox34.Enabled = false; checkBox34.Checked = false; checkBox34.Click -= checkBox34_CheckedChanged; }
            if (checkBox30.Checked) { checkBox35.Enabled = false; checkBox35.Checked = false; checkBox35.Click -= checkBox35_CheckedChanged; }
            if (checkBox30.Checked) { checkBox36.Enabled = false; checkBox36.Checked = false; checkBox36.Click -= checkBox36_CheckedChanged; }
            if (checkBox30.Checked) { checkBox37.Enabled = false; checkBox37.Checked = false; checkBox37.Click -= checkBox37_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }
        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            months = 20;
            restitution = 10000;
            fine = 20000;
            SeizeFirearmLicense = 1;
            if (checkBox31.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }


        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 10000;
            restitution = 5000;
            SeizeFirearmLicense = 1;
            if (checkBox32.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            months = 20;
            fine = 0;
            restitution = 10000;
            SeizeFirearmLicense = 1;
            if (checkBox33.Checked) { fMonths.Text = (fmCounter = fmCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 8000;
            SeizeVehicle = 1;
            restitution = 0;
            
            if (checkBox34.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SVSum.Text = (SV = SV + SeizeVehicle).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); checkBox23.Enabled = true; checkBox24.Enabled = true; monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SVSum.Text = (SV = SV - SeizeVehicle).ToString(); }
            if (checkBox34.Checked) { checkBox23.Enabled = false; checkBox23.Checked = false; checkBox23.Click -= checkBox23_CheckedChanged; }
            if (checkBox34.Checked) { checkBox24.Enabled = false; checkBox24.Checked = false; checkBox24.Click -= checkBox24_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            months = 20;
            fine = 0;
            restitution = 8500;
            SeizeFirearmLicense = 1;
            if (checkBox35.Checked) { fMonths.Text = (fmCounter = fmCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            months = 30;
            fine = 0;
            restitution = 10000;
            SeizeFirearmLicense = 1;
            if (checkBox36.Checked) { fMonths.Text = (fmCounter = fmCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SFLSum.Text = (SFL = SFL + SeizeFirearmLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SFLSum.Text = (SFL = SFL - SeizeFirearmLicense).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            months = 16;
            fine = 16000;
            restitution = 8000;
            if (checkBox37.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            months = 8;
            fine = 0;
            restitution = 2000;
            SeizeVehicleLicense = 1;
            if (checkBox38.Checked) { fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SVLSum.Text = (SVL = SVL + SeizeVehicleLicense).ToString(); fMonths.Text = (fmCounter = fmCounter + months).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SVLSum.Text = (SVL = SVL - SeizeVehicleLicense).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 0;
            restitution = 5000;
            SeizeVehicleLicense = 1;
            if (checkBox39.Checked) { fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SVLSum.Text = (SVL = SVL + SeizeVehicleLicense).ToString(); fMonths.Text = (fmCounter = fmCounter + months).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SVLSum.Text = (SVL = SVL - SeizeVehicleLicense).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            months = 10;
            fine = 0;
            SeizeVehicleLicense = 1;
            restitution = 5000;
            if (checkBox40.Checked) { fMonths.Text = (fmCounter = fmCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SVLSum.Text = (SVL = SVL + SeizeVehicleLicense).ToString(); allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); }
            else
            {
                RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString();
                { fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SVLSum.Text = (SVL = SVL - SeizeVehicleLicense).ToString(); fMonths.Text = (fmCounter = fmCounter - months).ToString(); }
            }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            months = 12;
            fine = 12000;
            restitution = 6000;
            SeizeVehicleLicense = 1;
            ImpoundVehicle = 1;
            if (checkBox41.Checked) { monthsSum.Text = (mCounter = mCounter + months).ToString(); fFines1.Text = (ffCounter = ffCounter + fine).ToString("C0"); SVLSum.Text = (SVL = SVL + SeizeVehicleLicense).ToString(); IVSum.Text = (IV = IV + ImpoundVehicle).ToString(); checkBox27.Enabled = false; checkBox14.Enabled = false; allFinesSum.Text = (totalFines = fCounter + ffCounter).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter).ToString(); RestitutionTotal.Text = (restitutiontotal = restitutiontotal + restitution).ToString("C0"); } else { RestitutionTotal.Text = (restitutiontotal = restitutiontotal - restitution).ToString("C0"); ; allFinesSum.Text = (totalFines = fCounter + ffCounter - fine).ToString("C0"); nfMonths.Text = (totalMonths = mCounter + fmCounter - months).ToString(); checkBox27.Enabled = true; checkBox14.Enabled = true; monthsSum.Text = (mCounter = mCounter - months).ToString(); fFines1.Text = (ffCounter = ffCounter - fine).ToString("C0"); SVLSum.Text = (SVL = SVL - SeizeVehicleLicense).ToString(); IVSum.Text = (IV = IV - ImpoundVehicle).ToString(); }
            if (checkBox27.Checked) { checkBox27.Checked = false; checkBox27.Click -= checkBox27_CheckedChanged; }
            if (checkBox14.Checked) { checkBox14.Checked = false; checkBox14.Click -= checkBox14_CheckedChanged; }
            if (checkBox500.Checked) { checkBox500.Checked = false; checkBox500.Click += checkBox500_CheckedChanged; } else { checkBox500.Checked = true; checkBox500.Click += checkBox500_CheckedChanged; }

        }

        private void ScrollPerc_Click(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            float value2 = Convert.ToInt32(trackBar1.Value);
            perc2.Text = value2.ToString();
            value2 = (value2 / 100);
            ScrollPercOutput1.Text = value2.ToString("##.###");
            ScrollPerc.Text = value2.ToString("##%");
            ScrollPerc22.Text = value2.ToString("Non-Felony Fine at ##% :");
            decimal value3 = decimal.Parse(fineSum.Text, NumberStyles.Currency);
            float value4 = Convert.ToInt32(value3);
            label5.Text = (value2 * value4).ToString("$#,##0");
            decimal value5 = decimal.Parse(fFines1.Text, NumberStyles.Currency);
            float value6 = Convert.ToInt32(value5);
            allFinesSum.Text = ((value2 * value4) + value6).ToString("$#,##0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox control in panel2.Controls.OfType<CheckBox>())
                foreach (CheckBox control2 in panel6.Controls.OfType<CheckBox>())
                    foreach (CheckBox control3 in panel10.Controls.OfType<CheckBox>())
                    {
                        control.Checked = false;
                        control2.Checked = false;
                        control3.Checked = false;
                    }

            trackBar1.Value = 100;
            trackBar2.Value = 100;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void allMonthsSum_Click(object sender, EventArgs e)
        {

        }

        private void checkBox500_CheckedChanged(object sender, EventArgs e)
        {
            decimal CurrentTicketingAidVer = decimal.Parse(TicketingAidVersion.Text);
            decimal QueriedTicketingAidVer = 0;
            //     Form2 f2 = new Form2();
            if (VersionCheckedToday < 1) {
                {

                    //  label90.Text = webBrowser2.Document.Body.OuterText;
                
                    if (Decimal.TryParse(label90.Text, out QueriedTicketingAidVer))
                    {
                        if (QueriedTicketingAidVer != CurrentTicketingAidVer)
                        {
                            Form2 CF = new Form2();

                            CF.Show();

                            CF.Location = this.Location;


                            // f2.Location = this.Owner.Location;
                            VersionCheckedToday = 1;
                            CF.VersionAid.Text = QueriedTicketingAidVer.ToString();
                            CF.AppVersionAid.Text = CurrentTicketingAidVer.ToString();
                            CF.Show();
                        }
                    }
                }
            }


            int percentage = (Int32.Parse(perc2.Text)); if (trackBar1.Value == 100) { trackBar1.Value = 90; } else { trackBar1.Value = 100; }
            trackBar1.Value = percentage;

            int percentage2 = (Int32.Parse(perc22.Text)); if (trackBar2.Value == 100) { trackBar2.Value = 90; } else { trackBar2.Value = 100; }
            trackBar2.Value = percentage2;

            int sflval = Convert.ToInt32(SFLSum.Text);
            if (sflval < 2) { SFALText.Visible = false; } else { SFALText.Visible = true; }

            int ivval = Convert.ToInt32(IVSum.Text);
            if (ivval < 1) { IVText.Visible = false; } else { IVText.Visible = true; }

            int SVLval = Convert.ToInt32(SVLSum.Text);
            if (SVLval < 1) { SVLText.Visible = false; } else { SVLText.Visible = true; }

            int SVval = Convert.ToInt32(SVSum.Text);
            if (SVval < 1) { SVText.Visible = false; } else { SVText.Visible = true; }

            if (totalFines < 40000) { allFinesSum2.Visible = false; } else { allFinesSum2.Visible = true; }
            if (totalMonths < 30) { nfMonths2.Visible = false; } else { nfMonths2.Visible = true; }
            if (restitutiontotal < 25000) { label91.Visible = false; } else { label91.Visible = true; }


            foreach (CheckBox controlcolor in panel2.Controls.OfType<CheckBox>())
                foreach (CheckBox controlcolor2 in panel6.Controls.OfType<CheckBox>())
                    foreach (CheckBox controlcolor3 in panel10.Controls.OfType<CheckBox>())
                    {
                        if (!controlcolor.Enabled) { controlcolor.BackColor = Color.DimGray; } else { controlcolor.BackColor = Color.DarkGray; }
                        if (!controlcolor2.Enabled) { controlcolor2.BackColor = Color.DimGray; } else { controlcolor2.BackColor = Color.DarkGray; }
                        if (!controlcolor3.Enabled) { controlcolor3.BackColor = Color.DimGray; } else { controlcolor3.BackColor = Color.DarkGray; }
                    }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (CheckBox control in this.Controls.OfType<CheckBox>())
            {
                control.Checked = false;
            }
            trackBar1.Value = 100;
            trackBar2.Value = 100;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void label55_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {

        }

        private void button2_Click_4(object sender, System.EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
        }


        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox42.Checked)
            {
                this.Size = new Size(1283, 690);  // DEFAULT SIZE
                label87.Visible = false;
                label89.Visible = false;
               TicketingAidVersion.Visible = false;
                panel14.Visible = false;
                checkBox42.Text = "Show Notes";
            }
            else
            {
                this.Size = new Size(1493, 690);  // CHANGE TO

               label87.Visible = true;
               label89.Visible = true;
               TicketingAidVersion.Visible = true;
                panel14.Visible = true;
                checkBox42.Text = "Hide Notes";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {


        }

        private void SFLSum_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TicketingAidVersion_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void FormSizes_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox controlcolor in panel2.Controls.OfType<CheckBox>())
                foreach (CheckBox controlcolor2 in panel6.Controls.OfType<CheckBox>())
                    foreach (CheckBox controlcolor3 in panel10.Controls.OfType<CheckBox>())
                        foreach (Label controlcolor4 in panel2.Controls.OfType<Label>())
                            foreach (Label controlcolor5 in panel6.Controls.OfType<Label>())
                                foreach (Label controlcolor6 in panel10.Controls.OfType<Label>())
                                    foreach (Label controlcolor7 in panel4.Controls.OfType<Label>())
                                        foreach (Label controlcolor8 in panel5.Controls.OfType<Label>())
                                        {
                                            if (checkBox43.Checked) { controlcolor.BackColor = Color.Gainsboro; } else { controlcolor.BackColor = Color.DarkGray; }
                                            if (checkBox43.Checked) { controlcolor2.BackColor = Color.Gainsboro; } else { controlcolor2.BackColor = Color.DarkGray; }
                                            if (checkBox43.Checked) { controlcolor3.BackColor = Color.Gainsboro; } else { controlcolor3.BackColor = Color.DarkGray; }
                                            if (checkBox43.Checked) { panel2.BackColor = Color.White; } else { panel2.BackColor = Color.Black; }
                                            if (checkBox43.Checked) { panel6.BackColor = Color.White; } else { panel6.BackColor = Color.Black; }
                                            if (checkBox43.Checked) { panel10.BackColor = Color.White; } else { panel10.BackColor = Color.Black; }
                                            if (checkBox43.Checked) { controlcolor4.ForeColor = Color.Black; } else { controlcolor4.ForeColor = Color.White; }
                                            if (checkBox43.Checked) { controlcolor7.ForeColor = Color.Black; } else { controlcolor7.ForeColor = Color.White; }
                                            if (checkBox43.Checked) { controlcolor8.ForeColor = Color.Black; } else { controlcolor8.ForeColor = Color.White; }

                                        }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RichTextBox notescolor in panel14.Controls.OfType<RichTextBox>())
                if (!checkBox44.Checked) { notescolor.BackColor = Color.Black; notescolor.ForeColor = Color.White; } else { notescolor.BackColor = Color.White; notescolor.ForeColor = Color.Black; }
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Top -= 35;
        }

        private void panel10_M(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked) { this.TopMost = true; } else { this.TopMost = false; }
        }

        private void button7_Click_3(object sender, EventArgs e)
        {
            Form3 CF3 = new Form3();

            CF3.Show();

            CF3.Location = this.Location;
           
        }

        private void ScrollPerc12_Click(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            float value22 = Convert.ToInt32(trackBar2.Value);
            perc22.Text = value22.ToString();
            value22 = (value22 / 100);
            ScrollPercOutput2.Text = value22.ToString("##.###");
            ScrollPerc2.Text = value22.ToString("##%");
            ScrollPercRes.Text = value22.ToString("Restitution at ##% :");
            decimal value33 = decimal.Parse(RestitutionTotal.Text, NumberStyles.Currency);
            float value44 = Convert.ToInt32(value33);
            RestitutionTotalPerc.Text = (value22 * value44).ToString("$#,##0");

        }

        private void ScrollPercRes_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            label90.Text = webBrowser2.Document.Body.OuterText;
            //label90.Text = webBrowser2.Document.GetElementById("html.body.div.div.div.div.div.div.div.div.div.drive-viewer-text-content.drive-viewer-text-page").InnerText;
        }

        private void button2_Click_5(object sender, EventArgs e)
        {
          //  label90.Text = webBrowser2.Document.GetElementById("/html/body/div[2]/div[2]/div[4]/div[2]/div[1]/div/div[2]/div/div/div/pre/drive-viewer-text-page").InnerText;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}