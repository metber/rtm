using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace rtm
{
    public partial class rtm : Form
    {

        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        int a = 0;

        //object[] C = new object[] { "a1", "a2", "a3", "a4", "a5", "a7", "a7", "a8", "a9", "a10", "a11", "a12", "a13", "a14", "a15", "a16" };
        //object[] OH = new object[] { "b1", "b2", "b3", "b4", "b5", "b7", "b7", "b8", "b9", "b10", "b11", "b12", "b13", "b14", "b15", "b16" };
        //object[] CH = new object[] { "c1", "c2", "c3", "c4", "c5", "c6", "c7", "c8", "c9", "c10", "c11", "c12", "c13", "c14", "c15", "c16" };
        //object[] S = new object[] { "d1", "d2", "d3", "d4", "d5", "d6", "d7", "d8", "d9", "d10", "d11", "d12", "d13", "d14", "d15", "d16" };
        //object[] K = new object[] { "e1", "e2", "e3", "e4", "e5", "e6", "e7", "e8", "e9", "e10", "e11", "e12", "e13", "e14", "e15", "e16" };

        //object[] TC1 = new object[] { "tc1a", "tc2a", "tc3a", "tc4a", "tc5a", "tc6a", "tc7a", "tc8a", "tc9a", "tc10a", "tc11a", "tc12a", "tc13a", "tc14a", "tc15a", "tc16a" };
        //object[] TOH1 = new object[] { "toh1a", "toh2a", "toh3a", "toh4a", "toh5a", "toh6a", "toh7a", "toh8a", "toh9a", "toh10a", "toh11a", "toh12a", "toh13a", "toh14a", "toh15a", "toh16a" };
        //object[] TCH1 = new object[] { "tch1a", "tch2a", "tch3a", "tch4a", "tch5a", "tch6a", "tch7a", "tch8a", "tch9a", "tch10a", "tch11a", "tch12a", "tch13a", "tch14a", "tch15a", "tch16a" };
        //object[] TS1 = new object[] { "ts1a", "ts2a", "ts3a", "ts4a", "ts5a", "ts6a", "ts7a", "ts8a", "ts9a", "ts10a", "ts11a", "ts12a", "ts13a", "ts14a", "ts15a", "ts16a" };
        //object[] TK1 = new object[] { "tk1a", "tk2a", "tk3a", "tk4a", "tk5a", "tk6a", "tk7a", "tk8a", "tk9a", "tk10a", "tk11a", "tk12a", "tk13a", "tk14a", "tk15a", "tk16a" };

        //object[] TC2 = new object[] { "tc1b", "tc2b", "tc3b", "tc4b", "tc5b", "tc6b", "tc7b", "tc8b", "tc9b", "tc10b", "tc11b", "tc12b", "tc13b", "tc14b", "tc15b", "tc16b" };
        //object[] TOH2 = new object[] { "toh1b", "toh2b", "toh3b", "toh4b", "toh5b", "toh6b", "toh7b", "toh8b", "toh9b", "toh10b", "toh11b", "toh12b", "toh13b", "toh14b", "toh15b", "toh16b" };
        //object[] TCH2 = new object[] { "tch1b", "tch2b", "tch3b", "tch4b", "tch5b", "tch6b", "tch7b", "tch8b", "tch9b", "tch10b", "tch11b", "tch12b", "tch13b", "tch14b", "tch15b", "tch16b" };
        //object[] TS2 = new object[] { "ts1b", "ts2b", "ts3b", "ts4b", "ts5b", "ts6b", "ts7b", "ts8b", "ts9b", "ts10b", "ts11b", "ts12b", "ts13b", "ts14b", "ts15b", "ts16b" };
        //object[] TK2 = new object[] { "tk1b", "tk2b", "tk3b", "tk4b", "tk5b", "tk6b", "tk7b", "tk8b", "tk9b", "tk10b", "tk11b", "tk12b", "tk13b", "tk14b", "tk15b", "tk16b" };

        //object[] DC = new object[] { "dc1", "dc2", "dc3", "dc4", "dc5", "dc6", "dc7", "dc8", "dc9", "dc10", "dc11", "dc12", "dc13", "dc14", "dc15", "dc16" };
        //object[] DOH = new object[] { "doh1", "doh2", "doh3", "doh4", "doh5", "doh6", "doh7", "doh8", "doh9", "doh10", "doh11", "doh12", "doh13", "doh14", "doh15", "doh16" };
        //object[] DCH = new object[] { "dch1", "dch2", "dch3", "dch4", "dch5", "dch6", "dch7", "dch8", "dch9", "dch10", "dch11", "dch12", "dch13", "dch14", "dch15", "dch16" };
        //object[] DS = new object[] { "ds1", "ds2", "ds3", "ds4", "ds5", "ds6", "ds7", "ds8", "ds9", "ds10", "ds11", "ds12", "ds13", "ds14", "ds15", "ds16" };
        //object[] DK = new object[] { "dk1", "dk2", "dk3", "dk4", "dk5", "dk6", "dk7", "dk8", "dk9", "dk10", "dk11", "dk12", "dk13", "dk14", "dk15", "dk16" };


        void Crash()
        {
            hit_crash.Visible = true;
            mciSendString(@"open Crash.wav type waveaudio alias Crash" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Crash" + a, null, 0, IntPtr.Zero);
            a++;

        }

        void Ride()
        {
            hit_ride.Visible = true;
            mciSendString(@"open Ride.wav type waveaudio alias Ride" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Ride" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void RideBell()
        {
            hit_bell.Visible = true;
            mciSendString(@"open RideBell.wav type waveaudio alias RideBell" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play RideBell" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Tom1()
        {
            hit_tom1.Visible = true;
            mciSendString(@"open Tom1.wav type waveaudio alias Tom1" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Tom1" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Tom2()
        {
            hit_tom2.Visible = true;
            mciSendString(@"open Tom2.wav type waveaudio alias Tom2" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Tom2" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Tom3()
        {
            hit_tom3.Visible = true;
            mciSendString(@"open Tom3.wav type waveaudio alias Tom3" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Tom3" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void OpHihat()
        {
            hit_o_hihat.Visible = true;
            mciSendString(@"open Open.wav type waveaudio alias Open" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Open" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void ClHihat()
        {
            hit_c_hihat.Visible=true;
            mciSendString(@"open Closed.wav type waveaudio alias Closed" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Closed" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Snare()
        {
            hit_snare.Visible = true;
            mciSendString(@"open Snare.wav type waveaudio alias Snare" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Snare" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Kick()
        {
            hit_kick.Visible = true;
            mciSendString(@"open Kick.wav type waveaudio alias Kick" + a, null, 0, IntPtr.Zero);
            mciSendString(@"play Kick" + a, null, 0, IntPtr.Zero);
            a++;
        }

        void Clear()
        {
            foreach (CheckBox c in cgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in ohgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in chgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in sgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in kgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in rgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in rbgr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in t1gr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in t2gr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }
            foreach (CheckBox c in t3gr.Controls.OfType<CheckBox>())
            {
                c.Checked = false;
            }

            if (tr.Text == "on")
            {
                foreach (CheckBox c in ctgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in ohtgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in chtgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in stgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in ktgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in rtgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in rbtgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t1tgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t2tgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t3tgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
            }

            if (db.Text == "on")
            {
                foreach (CheckBox c in cdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in ohdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in chdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in sdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in kdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in rdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in rbdgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t1dgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t2dgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
                foreach (CheckBox c in t3dgr.Controls.OfType<CheckBox>())
                {
                    c.Checked = false;
                }
            }
        }

        public rtm()
        {
            InitializeComponent();

            cgr.Location = new Point(90, 70); cgr.Size = new Size(800, 50);
            rgr.Location = new Point(90, 125); rgr.Size = new Size(800, 50);
            rbgr.Location = new Point(90, 180); rbgr.Size = new Size(800, 50);
            t1gr.Location = new Point(90, 235); t1gr.Size = new Size(800, 50);
            t2gr.Location = new Point(90, 290); t2gr.Size = new Size(800, 50);
            t3gr.Location = new Point(90, 345); t3gr.Size = new Size(800, 50);
            ohgr.Location = new Point(90, 400); ohgr.Size = new Size(800, 50);
            chgr.Location = new Point(90, 455); chgr.Size = new Size(800, 50);
            sgr.Location = new Point(90, 510); sgr.Size = new Size(800, 50);
            kgr.Location = new Point(90, 565); kgr.Size = new Size(800, 50);

            ctgr.Visible = false;
            rtgr.Visible = false;
            rbtgr.Visible = false;
            t1tgr.Visible = false;
            t2tgr.Visible = false;
            t3tgr.Visible = false;
            ohtgr.Visible = false;
            chtgr.Visible = false;
            stgr.Visible = false;
            ktgr.Visible = false;

            cdgr.Visible = false;
            rdgr.Visible = false;
            rbdgr.Visible = false;
            t1dgr.Visible = false;
            t2dgr.Visible = false;
            t3dgr.Visible = false;
            ohdgr.Visible = false;
            chdgr.Visible = false;
            sdgr.Visible = false;
            kdgr.Visible = false;

            tr.Text = "off";
            db.Text = "off";


        }

        
        private void rtm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1480, 700);

            stop.Visible = false;
            c1.Checked = true;
            c2.Checked = true;
            c3.Checked = true;
            c4.Checked = true;
            c5.Checked = true;
            c6.Checked = true;
            c7.Checked = true;
            c8.Checked = true;
            c9.Checked = true;
            c10.Checked = true;
            c11.Checked = true;
            c12.Checked = true;
            c13.Checked = true;
            c14.Checked = true;
            c15.Checked = true;
            c16.Checked = true;

            e1.Checked = true;
            e5.Checked = true;
            e6.Checked = true;
            e9.Checked = true;
            e13.Checked = true;
            e14.Checked = true;

            d3.Checked = true;
            d7.Checked = true;
            d11.Checked = true;
            d15.Checked = true;

            bpm_cmb.Text = "2.Level";

        }

        int sayac = -4;
        int sayac_db = -4;
        


        private void start_Click(object sender, EventArgs e)
        {
            if (tr.Text == "off" && db.Text == "off")
            {
                timer2.Start();
                start.Visible = false;
                stop.Visible = true;
            }

            if (tr.Text == "on")
            {
                start.Visible = false;
                timer1.Start();
                stop.Visible = true;
            }

            if (db.Text == "on")
            {
                start.Visible = false;
                timer2.Start();
                stop.Visible = true;
            }

        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Visible = false;
            label5.Text = "-4";
            sayac = int.Parse(label5.Text);
            label6.Text = "-4";
            sayac_db = int.Parse(label6.Text);
            timer1.Stop();
            timer2.Stop();
            start.Visible = true;
        }



        void Bounce()
        {
            hit_crash.Visible = false;
            hit_ride.Visible = false;
            hit_bell.Visible = false;
            hit_o_hihat.Visible = false;
            hit_c_hihat.Visible = false;
            hit_tom1.Visible = false;
            hit_tom2.Visible = false;
            hit_tom3.Visible = false;
            hit_snare.Visible = false;
            hit_kick.Visible = false;
        }


        //          DOUBLE TIMER TICKS
        private void timer2_Tick(object sender, EventArgs e)
        {
            Bounce();
            sayac_db++;
            label6.Text = sayac_db.ToString();

            if (sayac_db == 64)
            {   sayac_db = 0;   }

            if (sayac_db == 0)
            {
                if (a1.Checked)         {   Crash();    }
                if (f1.Checked)         {   Ride();     }
                if (g1.Checked)         {   RideBell(); }
                if (h1.Checked)         {   Tom1();     }
                if (i1.Checked)         {   Tom2();     }
                if (j1.Checked)         {   Tom3();     }
                if (b1.Checked)         {   OpHihat();  }
                if (c1.Checked)         {   ClHihat();  }
                if (d1.Checked)         {   Snare();    }
                if (e1.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 2)
                {
                    if (dc1.Checked)    {   Crash();    }
                    if (dr1.Checked)    {   Ride();     }
                    if (drb1.Checked)   {   RideBell(); }
                    if (dt11.Checked)   {   Tom1();     }
                    if (dt21.Checked)   {   Tom2();     }
                    if (dt31.Checked)   {   Tom3();     }
                    if (doh1.Checked)   {   OpHihat();  }
                    if (dch1.Checked)   {   ClHihat();  }
                    if (ds1.Checked)    {   Snare();    }
                    if (dk1.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 4)
            {
                if (a2.Checked)         {   Crash();    }
                if (f2.Checked)         {   Ride();     }
                if (g2.Checked)         {   RideBell(); }
                if (h2.Checked)         {   Tom1();     }
                if (i2.Checked)         {   Tom2();     }
                if (j2.Checked)         {   Tom3();     }
                if (b2.Checked)         {   OpHihat();  }
                if (c2.Checked)         {   ClHihat();  }
                if (d2.Checked)         {   Snare();    }
                if (e2.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 6)
                {
                    if (dc2.Checked)    {   Crash();    }
                    if (dr2.Checked)    {   Ride();     }
                    if (drb2.Checked)   {   RideBell(); }
                    if (dt12.Checked)   {   Tom1();     }
                    if (dt22.Checked)   {   Tom2();     }
                    if (dt32.Checked)   {   Tom3();     }
                    if (doh2.Checked)   {   OpHihat();  }
                    if (dch2.Checked)   {   ClHihat();  }
                    if (ds2.Checked)    {   Snare();    }
                    if (dk2.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 8)
            {
                if (a3.Checked)         {   Crash();    }
                if (f3.Checked)         {   Ride();     }
                if (g3.Checked)         {   RideBell(); }
                if (h3.Checked)         {   Tom1();     }
                if (i3.Checked)         {   Tom2();     }
                if (j3.Checked)         {   Tom3();     }
                if (b3.Checked)         {   OpHihat();  }
                if (c3.Checked)         {   ClHihat();  }
                if (d3.Checked)         {   Snare();    }
                if (e3.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 10)
                {
                    if (dc3.Checked)    {   Crash();    }
                    if (dr3.Checked)    {   Ride();     }
                    if (drb3.Checked)   {   RideBell(); }
                    if (dt13.Checked)   {   Tom1();     }
                    if (dt23.Checked)   {   Tom2();     }
                    if (dt33.Checked)   {   Tom3();     }
                    if (doh3.Checked)   {   OpHihat();  }
                    if (dch3.Checked)   {   ClHihat();  }
                    if (ds3.Checked)    {   Snare();    }
                    if (dk3.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 12)
            {
                if (a4.Checked)         {   Crash();    }
                if (f4.Checked)         {   Ride();     }
                if (g4.Checked)         {   RideBell(); }
                if (h4.Checked)         {   Tom1();     }
                if (i4.Checked)         {   Tom2();     }
                if (j4.Checked)         {   Tom3();     }
                if (b4.Checked)         {   OpHihat();  }
                if (c4.Checked)         {   ClHihat();  }
                if (d4.Checked)         {   Snare();    }
                if (e4.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 14)
                {
                    if (dc4.Checked)    {   Crash();    }
                    if (dr4.Checked)    {   Ride();     }
                    if (drb4.Checked)   {   RideBell(); }
                    if (dt14.Checked)   {   Tom1();     }
                    if (dt24.Checked)   {   Tom2();     }
                    if (dt34.Checked)   {   Tom3();     }
                    if (doh4.Checked)   {   OpHihat();  }
                    if (dch4.Checked)   {   ClHihat();  }
                    if (ds4.Checked)    {   Snare();    }
                    if (dk4.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 16)
            {
                if (a5.Checked)         {   Crash();    }
                if (f5.Checked)         {   Ride();     }
                if (g5.Checked)         {   RideBell(); }
                if (h5.Checked)         {   Tom1();     }
                if (i5.Checked)         {   Tom2();     }
                if (j5.Checked)         {   Tom3();     }
                if (b5.Checked)         {   OpHihat();  }
                if (c5.Checked)         {   ClHihat();  }
                if (d5.Checked)         {   Snare();    }
                if (e5.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 18)
                {
                    if (dc5.Checked)    {   Crash();    }
                    if (dr5.Checked)    {   Ride();     }
                    if (drb5.Checked)   {   RideBell(); }
                    if (dt15.Checked)   {   Tom1();     }
                    if (dt25.Checked)   {   Tom2();     }
                    if (dt35.Checked)   {   Tom3();     }
                    if (doh5.Checked)   {   OpHihat();  }
                    if (dch5.Checked)   {   ClHihat();  }
                    if (ds5.Checked)    {   Snare();    }
                    if (dk5.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 20)
            {
                if (a6.Checked)         {   Crash();    }
                if (f6.Checked)         {   Ride();     }
                if (g6.Checked)         {   RideBell(); }
                if (h6.Checked)         {   Tom1();     }
                if (i6.Checked)         {   Tom2();     }
                if (j6.Checked)         {   Tom3();     }
                if (b6.Checked)         {   OpHihat();  }
                if (c6.Checked)         {   ClHihat();  }
                if (d6.Checked)         {   Snare();    }
                if (e6.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 22)
                {
                    if (dc6.Checked)    {   Crash();    }
                    if (dr6.Checked)    {   Ride();     }
                    if (drb6.Checked)   {   RideBell(); }
                    if (dt16.Checked)   {   Tom1();     }
                    if (dt26.Checked)   {   Tom2();     }
                    if (dt36.Checked)   {   Tom3();     }
                    if (doh6.Checked)   {   OpHihat();  }
                    if (dch6.Checked)   {   ClHihat();  }
                    if (ds6.Checked)    {   Snare();    }
                    if (dk6.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 24)
            {
                if (a7.Checked)         {    Crash();   }
                if (f7.Checked)         {   Ride();     }
                if (g7.Checked)         {   RideBell(); }
                if (h7.Checked)         {   Tom1();     }
                if (i7.Checked)         {   Tom2();     }
                if (j7.Checked)         {   Tom3();     }
                if (b7.Checked)         {   OpHihat();  }
                if (c7.Checked)         {   ClHihat();  }
                if (d7.Checked)         {   Snare();    }
                if (e7.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 26)
                {
                    if (dc7.Checked)    {   Crash();    }
                    if (dr7.Checked)    {   Ride();     }
                    if (drb7.Checked)   {   RideBell(); }
                    if (dt17.Checked)   {   Tom1();     }
                    if (dt27.Checked)   {   Tom2();     }
                    if (dt37.Checked)   {   Tom3();     }
                    if (doh7.Checked)   {   OpHihat();  }
                    if (dch7.Checked)   {   ClHihat();  }
                    if (ds7.Checked)    {   Snare();    }
                    if (dk7.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 28)
            {
                if (a8.Checked)         {   Crash();    }
                if (f8.Checked)         {   Ride();     }
                if (g8.Checked)         {   RideBell(); }
                if (h8.Checked)         {   Tom1();     }
                if (i8.Checked)         {   Tom2();     }
                if (j8.Checked)         {   Tom3();     }
                if (b8.Checked)         {   OpHihat();  }
                if (c8.Checked)         {   ClHihat();  }
                if (d8.Checked)         {   Snare();    }
                if (e8.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 30)
                {
                    if (dc8.Checked)    {   Crash();    }
                    if (dr8.Checked)    {   Ride();     }
                    if (drb8.Checked)   {   RideBell(); }
                    if (dt18.Checked)   {   Tom1();     }
                    if (dt28.Checked)   {   Tom2();     }
                    if (dt38.Checked)   {   Tom3();     }
                    if (doh8.Checked)   {   OpHihat();  }
                    if (dch8.Checked)   {   ClHihat();  }
                    if (ds8.Checked)    {   Snare();    }
                    if (dk8.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 32)
            {
                if (a9.Checked)         {   Crash();    }
                if (f9.Checked)         {   Ride();     }
                if (g9.Checked)         {   RideBell(); }
                if (h9.Checked)         {   Tom1();     }
                if (i9.Checked)         {   Tom2();     }
                if (j9.Checked)         {   Tom3();     }
                if (b9.Checked)         {   OpHihat();  }
                if (c9.Checked)         {   ClHihat();  }
                if (d9.Checked)         {   Snare();    }
                if (e9.Checked)         {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 34)
                {
                    if (dc9.Checked)    {   Crash();    }
                    if (dr9.Checked)    {   Ride();     }
                    if (drb9.Checked)   {   RideBell(); }
                    if (dt19.Checked)   {   Tom1();     }
                    if (dt29.Checked)   {   Tom2();     }
                    if (dt39.Checked)   {   Tom3();     }
                    if (doh9.Checked)   {   OpHihat();  }
                    if (dch9.Checked)   {   ClHihat();  }
                    if (ds9.Checked)    {   Snare();    }
                    if (dk9.Checked)    {   Kick();     }
                }
            }

            if (sayac_db == 36)
            {
                if (a10.Checked)        {   Crash();    }
                if (f10.Checked)        {   Ride();     }
                if (g10.Checked)        {   RideBell(); }
                if (h10.Checked)        {   Tom1();     }
                if (i10.Checked)        {   Tom2();     }
                if (j10.Checked)        {   Tom3();     }
                if (b10.Checked)        {   OpHihat();  }
                if (c10.Checked)        {   ClHihat();  }
                if (d10.Checked)        {   Snare();    }
                if (e10.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 38)
                {
                    if (dc10.Checked)   {   Crash();    }
                    if (dr10.Checked)   {   Ride();     }
                    if (drb10.Checked)  {   RideBell(); }
                    if (dt110.Checked)  {   Tom1();     }
                    if (dt210.Checked)  {   Tom2();     }
                    if (dt310.Checked)  {   Tom3();     }
                    if (doh10.Checked)  {   OpHihat();  }
                    if (dch10.Checked)  {   ClHihat();  }
                    if (ds10.Checked)   {   Snare();    }
                    if (dk10.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 40)
            {
                if (a11.Checked)        {   Crash();    }
                if (f11.Checked)        {   Ride();     }
                if (g11.Checked)        {   RideBell(); }
                if (h11.Checked)        {   Tom1();     }
                if (i11.Checked)        {   Tom2();     }
                if (j11.Checked)        {   Tom3();     }
                if (b11.Checked)        {   OpHihat();  }
                if (c11.Checked)        {   ClHihat();  }
                if (d11.Checked)        {   Snare();    }
                if (e11.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 42)
                {
                    if (dc11.Checked)   {   Crash();    }
                    if (dr11.Checked)   {   Ride();     }
                    if (drb11.Checked)  {   RideBell(); }
                    if (dt111.Checked)  {   Tom1();     }
                    if (dt211.Checked)  {   Tom2();     }
                    if (dt311.Checked)  {   Tom3();     }
                    if (doh11.Checked)  {   OpHihat();  }
                    if (dch11.Checked)  {   ClHihat();  }
                    if (ds11.Checked)   {   Snare();    }
                    if (dk11.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 44)
            {
                if (a12.Checked)        {   Crash();    }
                if (f12.Checked)        {   Ride();     }
                if (g12.Checked)        {   RideBell(); }
                if (h12.Checked)        {   Tom1();     }
                if (i12.Checked)        {   Tom2();     }
                if (j12.Checked)        {   Tom3();     }
                if (b12.Checked)        {   OpHihat();  }
                if (c12.Checked)        {   ClHihat();  }
                if (d12.Checked)        {   Snare();    }
                if (e12.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 46)
                {
                    if (dc12.Checked)   {   Crash();    }
                    if (dr12.Checked)   {   Ride();     }
                    if (drb12.Checked)  {   RideBell(); }
                    if (dt112.Checked)  {   Tom1();     }
                    if (dt212.Checked)  {   Tom2();     }
                    if (dt312.Checked)  {   Tom3();     }
                    if (doh12.Checked)  {   OpHihat();  }
                    if (dch12.Checked)  {   ClHihat();  }
                    if (ds12.Checked)   {   Snare();    }
                    if (dk12.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 48)
            {
                if (a13.Checked)        {   Crash();    }
                if (f13.Checked)        {   Ride();     }
                if (g13.Checked)        {   RideBell(); }
                if (h13.Checked)        {   Tom1();     }
                if (i13.Checked)        {   Tom2();     }
                if (j13.Checked)        {   Tom3();     }
                if (b13.Checked)        {   OpHihat();  }
                if (c13.Checked)        {   ClHihat();  }
                if (d13.Checked)        {   Snare();    }
                if (e13.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 50)
                {
                    if (dc13.Checked)   {   Crash();    }
                    if (dr13.Checked)   {   Ride();     }
                    if (drb13.Checked)  {   RideBell(); }
                    if (dt113.Checked)  {   Tom1();     }
                    if (dt213.Checked)  {   Tom2();     }
                    if (dt313.Checked)  {   Tom3();     }
                    if (doh13.Checked)  {   OpHihat();  }
                    if (dch13.Checked)  {   ClHihat();  }
                    if (ds13.Checked)   {   Snare();    }
                    if (dk13.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 52)
            {
                if (a14.Checked)        {   Crash();    }
                if (f14.Checked)        {   Ride();     }
                if (g14.Checked)        {   RideBell(); }
                if (h14.Checked)        {   Tom1();     }
                if (i14.Checked)        {   Tom2();     }
                if (j14.Checked)        {   Tom3();     }
                if (b14.Checked)        {   OpHihat();  }
                if (c14.Checked)        {   ClHihat();  }
                if (d14.Checked)        {   Snare();    }
                if (e14.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 54)
                {
                    if (dc14.Checked)   {   Crash();    }
                    if (dr14.Checked)   {   Ride();     }
                    if (drb14.Checked)  {   RideBell(); }
                    if (dt114.Checked)  {   Tom1();     }
                    if (dt214.Checked)  {   Tom2();     }
                    if (dt314.Checked)  {   Tom3();     }
                    if (doh14.Checked)  {   OpHihat();  }
                    if (dch14.Checked)  {   ClHihat();  }
                    if (ds14.Checked)   {   Snare();    }
                    if (dk14.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 56)
            {
                if (a15.Checked)        {   Crash();    }
                if (f15.Checked)        {   Ride();     }
                if (g15.Checked)        {   RideBell(); }
                if (h15.Checked)        {   Tom1();     }
                if (i15.Checked)        {   Tom2();     }
                if (j15.Checked)        {   Tom3();     }
                if (b15.Checked)        {   OpHihat();  }
                if (c15.Checked)        {   ClHihat();  }
                if (d15.Checked)        {   Snare();    }
                if (e15.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 58)
                {
                    if (dc15.Checked)   {   Crash();    }
                    if (dr15.Checked)   {   Ride();     }
                    if (drb15.Checked)  {   RideBell(); }
                    if (dt115.Checked)  {   Tom1();     }
                    if (dt215.Checked)  {   Tom2();     }
                    if (dt315.Checked)  {   Tom3();     }
                    if (doh15.Checked)  {   OpHihat();  }
                    if (dch15.Checked)  {   ClHihat();  }
                    if (ds15.Checked)   {   Snare();    }
                    if (dk15.Checked)   {   Kick();     }
                }
            }

            if (sayac_db == 60)
            {
                if (a16.Checked)        {   Crash();    }
                if (f16.Checked)        {   Ride();     }
                if (g16.Checked)        {   RideBell(); }
                if (h16.Checked)        {   Tom1();     }
                if (i16.Checked)        {   Tom2();     }
                if (j16.Checked)        {   Tom3();     }
                if (b16.Checked)        {   OpHihat();  }
                if (c16.Checked)        {   ClHihat();  }
                if (d16.Checked)        {   Snare();    }
                if (e16.Checked)        {   Kick();     }
            }

            if (db.Text == "on")
            {
                if (sayac_db == 62)
                {
                    if (dc16.Checked)   {   Crash();    }
                    if (dr16.Checked)   {   Ride();     }
                    if (drb16.Checked)  {   RideBell(); }
                    if (dt116.Checked)  {   Tom1();     }
                    if (dt216.Checked)  {   Tom2();     }
                    if (dt316.Checked)  {   Tom3();     }
                    if (doh16.Checked)  {   OpHihat();  }
                    if (dch16.Checked)  {   ClHihat();  }
                    if (ds16.Checked)   {   Snare();    }
                    if (dk16.Checked)   {   Kick();     }
                }
            }
        }


        //          TRIPLE TIMER TICKS
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bounce();
            sayac++;
            label5.Text = sayac.ToString();

            if (sayac == 48)            {   sayac = 0;  }

            if (sayac == 0)
            {
                if (a1.Checked)         {   Crash();    }
                if (f1.Checked)         {   Ride();     }
                if (g1.Checked)         {   RideBell(); }
                if (h1.Checked)         {   Tom1();     }
                if (i1.Checked)         {   Tom2();     }
                if (j1.Checked)         {   Tom3();     }
                if (b1.Checked)         {   OpHihat();  } 
                if (c1.Checked)         {   ClHihat();  } 
                if (d1.Checked)         {   Snare();    } 
                if (e1.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 1)
                {
                    if (tc1a.Checked)   {   Crash();    } 
                    if (tr1a.Checked)   {   Ride();     }
                    if (trb1a.Checked)  {   RideBell(); }
                    if (tt11a.Checked)  {   Tom1();     }
                    if (tt21a.Checked)  {   Tom2();     }
                    if (tt31a.Checked)  {   Tom3();     }
                    if (toh1a.Checked)  {   OpHihat();  } 
                    if (tch1a.Checked)  {   ClHihat();  } 
                    if (ts1a.Checked)   {   Snare();    } 
                    if (tk1a.Checked)   {   Kick();     }
                }

                if (sayac == 2)
                {
                    if (tc1b.Checked)   {   Crash();    } 
                    if (tr1b.Checked)   {   Ride();     }
                    if (trb1b.Checked)  {   RideBell(); }
                    if (tt11b.Checked)  {   Tom1();     }
                    if (tt21b.Checked)  {   Tom2();     }
                    if (tt31b.Checked)  {   Tom3();     }
                    if (toh1b.Checked)  {   OpHihat();  } 
                    if (tch1b.Checked)  {   ClHihat();  } 
                    if (ts1b.Checked)   {   Snare();    } 
                    if (tk1b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 3)
            {
                if (a2.Checked)         {   Crash();    }
                if (f2.Checked)         {   Ride();     }
                if (g2.Checked)         {   RideBell(); }
                if (h2.Checked)         {   Tom1();     }
                if (i2.Checked)         {   Tom2();     }
                if (j2.Checked)         {   Tom3();     }
                if (b2.Checked)         {   OpHihat();  } 
                if (c2.Checked)         {   ClHihat();  } 
                if (d2.Checked)         {   Snare();    } 
                if (e2.Checked)         {   Kick();     } 
            }

            if (tr.Text == "on")
            {
                if (sayac == 4)
                {
                    if (tc2a.Checked)   {   Crash();    } 
                    if (tr2a.Checked)   {   Ride();     }
                    if (trb2a.Checked)  {   RideBell(); }
                    if (tt12a.Checked)  {   Tom1();     }
                    if (tt22a.Checked)  {   Tom2();     }
                    if (tt32a.Checked)  {   Tom3();     }
                    if (toh2a.Checked)  {   OpHihat();  } 
                    if (tch2a.Checked)  {   ClHihat();  } 
                    if (ts2a.Checked)   {   Snare();    } 
                    if (tk2a.Checked)   {   Kick();     }
                }

                if (sayac == 5)
                {
                    if (tc2b.Checked)   {   Crash();    } 
                    if (tr2b.Checked)   {   Ride();     }
                    if (trb2b.Checked)  {   RideBell(); }
                    if (tt12b.Checked)  {   Tom1();     }
                    if (tt22b.Checked)  {   Tom2();     }
                    if (tt32b.Checked)  {   Tom3();     }
                    if (toh2b.Checked)  {   OpHihat();  } 
                    if (tch2b.Checked)  {   ClHihat();  } 
                    if (ts2b.Checked)   {   Snare();    } 
                    if (tk2b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 6)
            {
                if (a3.Checked)         {   Crash();    } 
                if (f3.Checked)         {   Ride();     }
                if (g3.Checked)         {   RideBell(); }
                if (h3.Checked)         {   Tom1();     }
                if (i3.Checked)         {   Tom2();     }
                if (j3.Checked)         {   Tom3();     }
                if (b3.Checked)         {   OpHihat();  } 
                if (c3.Checked)         {   ClHihat();  } 
                if (d3.Checked)         {   Snare();    } 
                if (e3.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 7)
                {
                    if (tc3a.Checked)   {   Crash();    } 
                    if (tr3a.Checked)   {   Ride();     }
                    if (trb3a.Checked)  {   RideBell(); }
                    if (tt13a.Checked)  {   Tom1();     }
                    if (tt23a.Checked)  {   Tom2();     }
                    if (tt33a.Checked)  {   Tom3();     }
                    if (toh3a.Checked)  {   OpHihat();  } 
                    if (tch3a.Checked)  {   ClHihat();  } 
                    if (ts3a.Checked)   {   Snare();    } 
                    if (tk3a.Checked)   {   Kick();     }
                }

                if (sayac == 8)
                {
                    if (tc3b.Checked)   {   Crash();    } 
                    if (tr3b.Checked)   {   Ride();     }
                    if (trb3b.Checked)  {   RideBell(); }
                    if (tt13b.Checked)  {   Tom1();     }
                    if (tt23b.Checked)  {   Tom2();     }
                    if (tt33b.Checked)  {   Tom3();     }
                    if (toh3b.Checked)  {   OpHihat();  } 
                    if (tch3b.Checked)  {   ClHihat();  } 
                    if (ts3b.Checked)   {   Snare();    } 
                    if (tk3b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 9)
            {
                if (a4.Checked)         {   Crash();    } 
                if (f4.Checked)         {   Ride();     }
                if (g4.Checked)         {   RideBell(); }
                if (h4.Checked)         {   Tom1();     }
                if (i4.Checked)         {   Tom2();     }
                if (j4.Checked)         {   Tom3();     }
                if (b4.Checked)         {   OpHihat();  } 
                if (c4.Checked)         {   ClHihat();  } 
                if (d4.Checked)         {   Snare();    } 
                if (e4.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 10)
                {
                    if (tc4a.Checked)   {   Crash();    } 
                    if (tr4a.Checked)   {   Ride();     }
                    if (trb4a.Checked)  {   RideBell(); }
                    if (tt14a.Checked)  {   Tom1();     }
                    if (tt24a.Checked)  {   Tom2();     }
                    if (tt34a.Checked)  {   Tom3();     }
                    if (toh4a.Checked)  {   OpHihat();  } 
                    if (tch4a.Checked)  {   ClHihat();  } 
                    if (ts4a.Checked)   {   Snare();    } 
                    if (tk4a.Checked)   {   Kick();     }
                }

                if (sayac == 11)
                {
                    if (tc4b.Checked)   {   Crash();    } 
                    if (tr4b.Checked)   {   Ride();     }
                    if (trb4b.Checked)  {   RideBell(); }
                    if (tt14b.Checked)  {   Tom1();     }
                    if (tt24b.Checked)  {   Tom2();     }
                    if (tt34b.Checked)  {   Tom3();     }
                    if (toh4b.Checked)  {   OpHihat();  } 
                    if (tch4b.Checked)  {   ClHihat();  } 
                    if (ts4b.Checked)   {   Snare();    } 
                    if (tk4b.Checked)   {   Kick();     }                
                }
            }

            if (sayac == 12)
            {
                if (a5.Checked)         {   Crash();    } 
                if (f5.Checked)         {   Ride();     }
                if (g5.Checked)         {   RideBell(); }
                if (h5.Checked)         {   Tom1();     }
                if (i5.Checked)         {   Tom2();     }
                if (j5.Checked)         {   Tom3();     }
                if (b5.Checked)         {   OpHihat();  } 
                if (c5.Checked)         {   ClHihat();  } 
                if (d5.Checked)         {   Snare();    } 
                if (e5.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 13)
                {
                    if (tc5a.Checked)   {   Crash();    } 
                    if (tr5a.Checked)   {   Ride();     }
                    if (trb5a.Checked)  {   RideBell(); }
                    if (tt15a.Checked)  {   Tom1();     }
                    if (tt25a.Checked)  {   Tom2();     }
                    if (tt35a.Checked)  {   Tom3();     }
                    if (toh5a.Checked)  {   OpHihat();  } 
                    if (tch5a.Checked)  {   ClHihat();  } 
                    if (ts5a.Checked)   {   Snare();    } 
                    if (tk5a.Checked)   {   Kick();     }
                }

                if (sayac == 14)
                {
                    if (tc5b.Checked)   {   Crash();    } 
                    if (tr5b.Checked)   {   Ride();     }
                    if (trb5b.Checked)  {   RideBell(); }
                    if (tt15b.Checked)  {   Tom1();     }
                    if (tt25b.Checked)  {   Tom2();     }
                    if (tt35b.Checked)  {   Tom3();     }
                    if (toh5b.Checked)  {   OpHihat();  } 
                    if (tch5b.Checked)  {   ClHihat();  } 
                    if (ts5b.Checked)   {   Snare();    } 
                    if (tk5b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 15)
            {
                if (a6.Checked)         {   Crash();    } 
                if (f6.Checked)         {   Ride();     }
                if (g6.Checked)         {   RideBell(); }
                if (h6.Checked)         {   Tom1();     }
                if (i6.Checked)         {   Tom2();     }
                if (j6.Checked)         {   Tom3();     }
                if (b6.Checked)         {   OpHihat();  } 
                if (c6.Checked)         {   ClHihat();  } 
                if (d6.Checked)         {   Snare();    } 
                if (e6.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 16)
                {
                    if (tc6a.Checked)   {   Crash();    } 
                    if (tr6a.Checked)   {   Ride();     }
                    if (trb6a.Checked)  {   RideBell(); }
                    if (tt16a.Checked)  {   Tom1();     }
                    if (tt26a.Checked)  {   Tom2();     }
                    if (tt36a.Checked)  {   Tom3();     }
                    if (toh6a.Checked)  {   OpHihat();  } 
                    if (tch6a.Checked)  {   ClHihat();  } 
                    if (ts6a.Checked)   {   Snare();    } 
                    if (tk6a.Checked)   {   Kick();     }
                }

                if (sayac == 17)
                {
                    if (tc6b.Checked)   {   Crash();    }
                    if (tr6b.Checked)   {   Ride();     }
                    if (trb6b.Checked)  {   RideBell(); }
                    if (tt16b.Checked)  {   Tom1();     }
                    if (tt26b.Checked)  {   Tom2();     }
                    if (tt36b.Checked)  {   Tom3();     }
                    if (toh6b.Checked)  {   OpHihat();  } 
                    if (tch6b.Checked)  {   ClHihat();  } 
                    if (ts6b.Checked)   {   Snare();    } 
                    if (tk6b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 18)
            {
                if (a7.Checked)         {   Crash();    } 
                if (f7.Checked)         {   Ride();     }
                if (g7.Checked)         {   RideBell(); }
                if (h7.Checked)         {   Tom1();     }
                if (i7.Checked)         {   Tom2();     }
                if (j7.Checked)         {   Tom3();     }
                if (b7.Checked)         {   OpHihat();  } 
                if (c7.Checked)         {   ClHihat();  } 
                if (d7.Checked)         {   Snare();    } 
                if (e7.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 19)
                {
                    if (tc7a.Checked)   {   Crash();    } 
                    if (tr7a.Checked)   {   Ride();     }
                    if (trb7a.Checked)  {   RideBell(); }
                    if (tt17a.Checked)  {   Tom1();     }
                    if (tt27a.Checked)  {   Tom2();     }
                    if (tt37a.Checked)  {   Tom3();     }
                    if (toh7a.Checked)  {   OpHihat();  } 
                    if (tch7a.Checked)  {   ClHihat();  } 
                    if (ts7a.Checked)   {   Snare();    } 
                    if (tk7a.Checked)   {   Kick();     }
                }

                if (sayac == 20)
                {
                    if (tc7b.Checked)   {   Crash();    } 
                    if (tr7b.Checked)   {   Ride();     }
                    if (trb7b.Checked)  {   RideBell(); }
                    if (tt17b.Checked)  {   Tom1();     }
                    if (tt27b.Checked)  {   Tom2();     }
                    if (tt37b.Checked)  {   Tom3();     }
                    if (toh7b.Checked)  {   OpHihat();  } 
                    if (tch7b.Checked)  {   ClHihat();  } 
                    if (ts7b.Checked)   {   Snare();    } 
                    if (tk7b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 21)
            {
                if (a8.Checked)     {   Crash();    } 
                if (f8.Checked)     {   Ride();     }
                if (g8.Checked)     {   RideBell(); }
                if (h8.Checked)     {   Tom1();     }
                if (i8.Checked)     {   Tom2();     }
                if (j8.Checked)     {   Tom3();     }
                if (b8.Checked)     {   OpHihat();  } 
                if (c8.Checked)     {   ClHihat();  } 
                if (d8.Checked)     {   Snare();    } 
                if (e8.Checked)     {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 22)
                {
                    if (tc8a.Checked)   {   Crash();    } 
                    if (tr8a.Checked)   {   Ride();     }
                    if (trb8a.Checked)  {   RideBell(); }
                    if (tt18a.Checked)  {   Tom1();     }
                    if (tt28a.Checked)  {   Tom2();     }
                    if (tt38a.Checked)  {   Tom3();     }
                    if (toh8a.Checked)  {   OpHihat();  } 
                    if (tch8a.Checked)  {   ClHihat();  } 
                    if (ts8a.Checked)   {   Snare();    } 
                    if (tk8a.Checked)   {   Kick();     }
                }

                if (sayac == 23)
                {
                    if (tc8b.Checked)   {   Crash();    } 
                    if (tr8b.Checked)   {   Ride();     }
                    if (trb8b.Checked)  {   RideBell(); }
                    if (tt18b.Checked)  {   Tom1();     }
                    if (tt28b.Checked)  {   Tom2();     }
                    if (tt38b.Checked)  {   Tom3();     }
                    if (toh8b.Checked)  {   OpHihat();  } 
                    if (tch8b.Checked)  {   ClHihat();  } 
                    if (ts8b.Checked)   {   Snare();    } 
                    if (tk8b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 24)
            {
                if (a9.Checked)         {   Crash();    } 
                if (f9.Checked)         {   Ride();     }
                if (g9.Checked)         {   RideBell(); }
                if (h9.Checked)         {   Tom1();     }
                if (i9.Checked)         {   Tom2();     }
                if (j9.Checked)         {   Tom3();     }
                if (b9.Checked)         {   OpHihat();  } 
                if (c9.Checked)         {   ClHihat();  } 
                if (d9.Checked)         {   Snare();    } 
                if (e9.Checked)         {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 25)
                {
                    if (tc9a.Checked)   {   Crash();    } 
                    if (tr9a.Checked)   {   Ride();     }
                    if (trb9a.Checked)  {   RideBell(); }
                    if (tt19a.Checked)  {   Tom1();     }
                    if (tt29a.Checked)  {   Tom2();     }
                    if (tt39a.Checked)  {   Tom3();     }
                    if (toh9a.Checked)  {   OpHihat();  } 
                    if (tch9a.Checked)  {   ClHihat();  } 
                    if (ts9a.Checked)   {   Snare();    } 
                    if (tk9a.Checked)   {   Kick();     }
                }

                if (sayac == 26)
                {
                    if (tc9b.Checked)   {   Crash();    } 
                    if (tr9b.Checked)   {   Ride();     }
                    if (trb9b.Checked)  {   RideBell(); }
                    if (tt19b.Checked)  {   Tom1();     }
                    if (tt29b.Checked)  {   Tom2();     }
                    if (tt39b.Checked)  {   Tom3();     }
                    if (toh9b.Checked)  {   OpHihat();  } 
                    if (tch9b.Checked)  {   ClHihat();  } 
                    if (ts9b.Checked)   {   Snare();    } 
                    if (tk9b.Checked)   {   Kick();     }
                }
            }

            if (sayac == 27)
            {
                if (a10.Checked)        {   Crash();    } 
                if (f10.Checked)        {   Ride();     }
                if (g10.Checked)        {   RideBell(); }
                if (h10.Checked)        {   Tom1();     }
                if (i10.Checked)        {   Tom2();     }
                if (j10.Checked)        {   Tom3();     }
                if (b10.Checked)        {   OpHihat();  } 
                if (c10.Checked)        {   ClHihat();  } 
                if (d10.Checked)        {   Snare();    } 
                if (e10.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 28)
                {
                    if (tc10a.Checked)  {   Crash();    } 
                    if (tr10a.Checked)  {   Ride();     }
                    if (trb10a.Checked) {   RideBell(); }
                    if (tt110a.Checked) {   Tom1();     }
                    if (tt210a.Checked) {   Tom2();     }
                    if (tt310a.Checked) {   Tom3();     }
                    if (toh10a.Checked) {   OpHihat();  } 
                    if (tch10a.Checked) {   ClHihat();  } 
                    if (ts10a.Checked)  {   Snare();    } 
                    if (tk10a.Checked)  {   Kick();     }
                }

                if (sayac == 29)
                {
                    if (tc10b.Checked)  {   Crash();    } 
                    if (tr10b.Checked)  {   Ride();     }
                    if (trb10b.Checked) {   RideBell(); }
                    if (tt110b.Checked) {   Tom1();     }
                    if (tt210b.Checked) {   Tom2();     }
                    if (tt310b.Checked) {   Tom3();     }
                    if (toh10b.Checked) {   OpHihat();  } 
                    if (tch10b.Checked) {   ClHihat();  } 
                    if (ts10b.Checked)  {   Snare();    } 
                    if (tk10b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 30)
            {
                if (a11.Checked)        {   Crash();    } 
                if (f11.Checked)        {   Ride();     }
                if (g11.Checked)        {   RideBell(); }
                if (h11.Checked)        {   Tom1();     }
                if (i11.Checked)        {   Tom2();     }
                if (j11.Checked)        {   Tom3();     }
                if (b11.Checked)        {   OpHihat();  } 
                if (c11.Checked)        {   ClHihat();  } 
                if (d11.Checked)        {   Snare();    } 
                if (e11.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 31)
                {
                    if (tc11a.Checked)  {   Crash();    } 
                    if (tr11a.Checked)   {   Ride();     }
                    if (trb11a.Checked)  {   RideBell(); }
                    if (tt111a.Checked)  {   Tom1();     }
                    if (tt211a.Checked)  {   Tom2();     }
                    if (tt311a.Checked)  {   Tom3();     }
                    if (toh11a.Checked) {   OpHihat();  } 
                    if (tch11a.Checked) {   ClHihat();  } 
                    if (ts11a.Checked)  {   Snare();    } 
                    if (tk11a.Checked)  {   Kick();     }
                }

                if (sayac == 32)
                {
                    if (tc11b.Checked)  {   Crash();    } 
                    if (tr11b.Checked)  {   Ride();     }
                    if (trb11b.Checked) {   RideBell(); }
                    if (tt111b.Checked) {   Tom1();     }
                    if (tt211b.Checked) {   Tom2();     }
                    if (tt311b.Checked) {   Tom3();     }
                    if (toh11b.Checked) {   OpHihat();  } 
                    if (tch11b.Checked) {   ClHihat();  } 
                    if (ts11b.Checked)  {   Snare();    } 
                    if (tk11b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 33)
            {
                if (a12.Checked)        {   Crash();    } 
                if (f12.Checked)        {   Ride();     }
                if (g12.Checked)        {   RideBell(); }
                if (h12.Checked)        {   Tom1();     }
                if (i12.Checked)        {   Tom2();     }
                if (j12.Checked)        {   Tom3();     }
                if (b12.Checked)        {   OpHihat();  } 
                if (c12.Checked)        {   ClHihat();  } 
                if (d12.Checked)        {   Snare();    } 
                if (e12.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 34)
                {
                    if (tc12a.Checked)  {   Crash();    }
                    if (tr12a.Checked)  {   Ride();     }
                    if (trb12a.Checked) {   RideBell(); }
                    if (tt112a.Checked) {   Tom1();     }
                    if (tt212a.Checked) {   Tom2();     }
                    if (tt312a.Checked) {   Tom3();     }
                    if (toh12a.Checked) {   OpHihat();  } 
                    if (tch12a.Checked) {   ClHihat();  } 
                    if (ts12a.Checked)  {   Snare();    } 
                    if (tk12a.Checked)  {   Kick();     }
                }

                if (sayac == 35)
                {
                    if (tc12b.Checked)  {   Crash();    } 
                    if (tr12b.Checked)  {   Ride();     }
                    if (trb12b.Checked) {   RideBell(); }
                    if (tt112b.Checked) {   Tom1();     }
                    if (tt212b.Checked) {   Tom2();     }
                    if (tt312b.Checked) {   Tom3();     }
                    if (toh12b.Checked) {   OpHihat();  } 
                    if (tch12b.Checked) {   ClHihat();  } 
                    if (ts12b.Checked)  {   Snare();    } 
                    if (tk12b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 36)
            {
                if (a13.Checked)        {   Crash();    } 
                if (f13.Checked)        {   Ride();     }
                if (g13.Checked)        {   RideBell(); }
                if (h13.Checked)        {   Tom1();     }
                if (i13.Checked)        {   Tom2();     }
                if (j13.Checked)        {   Tom3();     }
                if (b13.Checked)        {   OpHihat();  } 
                if (c13.Checked)        {   ClHihat();  } 
                if (d13.Checked)        {   Snare();    } 
                if (e13.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 37)
                {
                    if (tc13a.Checked)  {   Crash();    } 
                    if (tr13a.Checked)  {   Ride();     }
                    if (trb13a.Checked) {   RideBell(); }
                    if (tt113a.Checked) {   Tom1();     }
                    if (tt213a.Checked) {   Tom2();     }
                    if (tt313a.Checked) {   Tom3();     }
                    if (toh13a.Checked) {   OpHihat();  } 
                    if (tch13a.Checked) {   ClHihat();  } 
                    if (ts13a.Checked)  {   Snare();    } 
                    if (tk13a.Checked)  {   Kick();     }
                }

                if (sayac == 38)
                {
                    if (tc13b.Checked)  {   Crash();    } 
                    if (tr13b.Checked)  {   Ride();     }
                    if (trb13b.Checked) {   RideBell(); }
                    if (tt113b.Checked) {   Tom1();     }
                    if (tt213b.Checked) {   Tom2();     }
                    if (tt313b.Checked) {   Tom3();     }
                    if (toh13b.Checked) {   OpHihat();  } 
                    if (tch13b.Checked) {   ClHihat();  } 
                    if (ts13b.Checked)  {   Snare();    } 
                    if (tk13b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 39)
            {
                if (a14.Checked)        {   Crash();    } 
                if (f14.Checked)        {   Ride();     }
                if (g14.Checked)        {   RideBell(); }
                if (h14.Checked)        {   Tom1();     }
                if (i14.Checked)        {   Tom2();     }
                if (j14.Checked)        {   Tom3();     }
                if (b14.Checked)        {   OpHihat();  } 
                if (c14.Checked)        {   ClHihat();  } 
                if (d14.Checked)        {   Snare();    } 
                if (e14.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 40)
                {
                    if (tc14a.Checked)  {   Crash();    } 
                    if (tr14a.Checked)   {   Ride();     }
                    if (trb14a.Checked)  {   RideBell(); }
                    if (tt114a.Checked)  {   Tom1();     }
                    if (tt214a.Checked)  {   Tom2();     }
                    if (tt314a.Checked)  {   Tom3();     }
                    if (toh14a.Checked) {   OpHihat();  } 
                    if (tch14a.Checked) {   ClHihat();  } 
                    if (ts14a.Checked)  {   Snare();    } 
                    if (tk14a.Checked)  {   Kick();     }
                }

                if (sayac == 41)
                {
                    if (tc14b.Checked)  {   Crash();    } 
                    if (tr14b.Checked)  {   Ride();     }
                    if (trb14b.Checked) {   RideBell(); }
                    if (tt114b.Checked) {   Tom1();     }
                    if (tt214b.Checked) {   Tom2();     }
                    if (tt314b.Checked) {   Tom3();     }
                    if (toh14b.Checked) {   OpHihat();  } 
                    if (tch14b.Checked) {   ClHihat();  } 
                    if (ts14b.Checked)  {   Snare();    } 
                    if (tk14b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 42)
            {
                if (a15.Checked)        {   Crash();    } 
                if (f15.Checked)        {   Ride();     }
                if (g15.Checked)        {   RideBell(); }
                if (h15.Checked)        {   Tom1();     }
                if (i15.Checked)        {   Tom2();     }
                if (j15.Checked)        {   Tom3();     }
                if (b15.Checked)        {   OpHihat();  } 
                if (c15.Checked)        {   ClHihat();  } 
                if (d15.Checked)        {   Snare();    } 
                if (e15.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 43)
                {
                    if (tc15a.Checked)  {   Crash();    } 
                    if (tr15a.Checked)   {   Ride();     }
                    if (trb15a.Checked)  {   RideBell(); }
                    if (tt115a.Checked)  {   Tom1();     }
                    if (tt215a.Checked)  {   Tom2();     }
                    if (tt315a.Checked)  {   Tom3();     }
                    if (toh15a.Checked) {   OpHihat();  } 
                    if (tch15a.Checked) {   ClHihat();  } 
                    if (ts15a.Checked)  {   Snare();    } 
                    if (tk15a.Checked)  {   Kick();     }
                }

                if (sayac == 44)
                {
                    if (tc15b.Checked)  {   Crash();    } 
                    if (tr15b.Checked)  {   Ride();     }
                    if (trb15b.Checked) {   RideBell(); }
                    if (tt115b.Checked) {   Tom1();     }
                    if (tt215b.Checked) {   Tom2();     }
                    if (tt315b.Checked) {   Tom3();     }
                    if (toh15b.Checked) {   OpHihat();  } 
                    if (tch15b.Checked) {   ClHihat();  } 
                    if (ts15b.Checked)  {   Snare();    } 
                    if (tk15b.Checked)  {   Kick();     }
                }
            }

            if (sayac == 45)
            {
                if (a16.Checked)        {   Crash();    } 
                if (f16.Checked)        {   Ride();     }
                if (g16.Checked)        {   RideBell(); }
                if (h16.Checked)        {   Tom1();     }
                if (i16.Checked)        {   Tom2();     }
                if (j16.Checked)        {   Tom3();     }
                if (b16.Checked)        {   OpHihat();  } 
                if (c16.Checked)        {   ClHihat();  } 
                if (d16.Checked)        {   Snare();    } 
                if (e16.Checked)        {   Kick();     }
            }

            if (tr.Text == "on")
            {
                if (sayac == 46)
                {
                    if (tc16a.Checked)  {   Crash();    } 
                    if (tr16a.Checked)  {   Ride();     }
                    if (trb16a.Checked) {   RideBell(); }
                    if (tt116a.Checked) {   Tom1();     }
                    if (tt216a.Checked) {   Tom2();     }
                    if (tt316a.Checked) {   Tom3();     }
                    if (toh16a.Checked) {   OpHihat();  } 
                    if (tch16a.Checked) {   ClHihat();  } 
                    if (ts16a.Checked)  {   Snare();    } 
                    if (tk16a.Checked)  {   Kick();     }
                }

                if (sayac == 47)
                {
                    if (tc16b.Checked)  {   Crash();    } 
                    if (tr16b.Checked)  {   Ride();     }
                    if (trb16b.Checked) {   RideBell(); }
                    if (tt116b.Checked) {   Tom1();     }
                    if (tt216b.Checked) {   Tom2();     }
                    if (tt316b.Checked) {   Tom3();     }
                    if (toh16b.Checked) {   OpHihat();  } 
                    if (tch16b.Checked) {   ClHihat();  } 
                    if (ts16b.Checked)  {   Snare();    } 
                    if (tk16b.Checked)  {   Kick();     }
                }
            }
        }


        //                  BPM LEVELS
        private void bpm_ap_Click(object sender, EventArgs e)
        {
            if (bpm_cmb.Text == "1.Level") { timer1.Interval = 120; timer2.Interval = 120; }

            if (bpm_cmb.Text == "2.Level") { timer1.Interval = 100; timer2.Interval = 100; }

            if (bpm_cmb.Text == "3.Level") { timer1.Interval = 80; timer2.Interval = 80; }

            if (bpm_cmb.Text == "4.Level") { timer1.Interval = 60; timer2.Interval = 60; }

            if (bpm_cmb.Text == "5.Level") { timer1.Interval = 40; timer2.Interval = 40; }

            if (bpm_cmb.Text == "6.Level") { timer1.Interval = 20; timer2.Interval = 20; }
        }

        //                  TRIPLET ON
        private void tron_Click(object sender, EventArgs e)
        {
            btn_crash.Location = new Point(30, 80);
            btn_ride.Location = new Point(30, 170);
            btn_bell.Location = new Point(30, 260);
            btn_tom1.Location = new Point(30, 350);
            btn_tom2.Location = new Point(30, 440);
            btn_tom3.Location = new Point(30, 530);
            btn_ohh.Location = new Point(30, 620);
            btn_chh.Location = new Point(30, 710);
            btn_snare.Location = new Point(30, 800);
            btn_kick.Location = new Point(30, 890);

            this.Size = new System.Drawing.Size(1480, 1030);

            cgr.Location = new Point(90, 70);   cgr.Size = new Size(800, 90);
            rgr.Location = new Point(90, 160);  rgr.Size = new Size(800, 90);
            rbgr.Location = new Point(90, 250); rbgr.Size = new Size(800, 90);
            t1gr.Location = new Point(90, 340); t1gr.Size = new Size(800, 90);
            t2gr.Location = new Point(90, 430); t2gr.Size = new Size(800, 90);
            t3gr.Location = new Point(90, 520); t3gr.Size = new Size(800, 90);
            ohgr.Location = new Point(90, 610); ohgr.Size = new Size(800, 90);
            chgr.Location = new Point(90, 700); chgr.Size = new Size(800, 90);
            sgr.Location = new Point(90, 790);  sgr.Size = new Size(800, 90);
            kgr.Location = new Point(90, 880);  kgr.Size = new Size(800, 90);

            ctgr.Location = new Point(40, 32); ctgr.Size = new Size(745, 50);
            rtgr.Location = new Point(40, 32); rtgr.Size = new Size(745, 50);
            rbtgr.Location = new Point(40, 32); rbtgr.Size = new Size(745, 50);
            t1tgr.Location = new Point(40, 32); t1tgr.Size = new Size(745, 50);
            t2tgr.Location = new Point(40, 32); t2tgr.Size = new Size(745, 50);
            t3tgr.Location = new Point(40, 32); t3tgr.Size = new Size(745, 50);
            ohtgr.Location = new Point(40, 32); ohtgr.Size = new Size(745, 50);
            chtgr.Location = new Point(40, 32); chtgr.Size = new Size(745, 50);
            stgr.Location = new Point(40, 32); stgr.Size = new Size(745, 50);
            ktgr.Location = new Point(40, 32); ktgr.Size = new Size(745, 50);

            ctgr.Visible = true;
            rtgr.Visible = true;
            rbtgr.Visible = true;
            t1tgr.Visible = true;
            t2tgr.Visible = true;
            t3tgr.Visible = true;
            ohtgr.Visible = true;
            chtgr.Visible = true;
            stgr.Visible = true;
            ktgr.Visible = true;

            tron.Visible = false;
            troff.Visible = true;

            dbon.Enabled = false;
            dboff.Enabled = false;

            tr.Text = "on";
        }

        //                  TRIPLET OFF
        private void troff_Click(object sender, EventArgs e)
        {
            btn_crash.Location = new Point(30, 75);
            btn_ride.Location = new Point(30, 130);
            btn_bell.Location = new Point(30, 185);
            btn_tom1.Location = new Point(30, 240);
            btn_tom2.Location = new Point(30, 295);
            btn_tom3.Location = new Point(30, 350);
            btn_ohh.Location = new Point(30, 405);
            btn_chh.Location = new Point(30, 460);
            btn_snare.Location = new Point(30, 515);
            btn_kick.Location = new Point(30, 570);

            this.Size = new System.Drawing.Size(1480, 700);

            cgr.Location = new Point(90, 70); cgr.Size = new Size(800, 50);
            rgr.Location = new Point(90, 125); rgr.Size = new Size(800, 50);
            rbgr.Location = new Point(90, 180); rbgr.Size = new Size(800, 50);
            t1gr.Location = new Point(90, 235); t1gr.Size = new Size(800, 50);
            t2gr.Location = new Point(90, 290); t2gr.Size = new Size(800, 50);
            t3gr.Location = new Point(90, 345); t3gr.Size = new Size(800, 50);
            ohgr.Location = new Point(90, 400); ohgr.Size = new Size(800, 50);
            chgr.Location = new Point(90, 455); chgr.Size = new Size(800, 50);
            sgr.Location = new Point(90, 510); sgr.Size = new Size(800, 50);
            kgr.Location = new Point(90, 565); kgr.Size = new Size(800, 50);

            ctgr.Visible = false;
            rtgr.Visible = false;
            rbtgr.Visible = false;
            t1tgr.Visible = false;
            t2tgr.Visible = false;
            t3tgr.Visible = false;
            ohtgr.Visible = false;
            chtgr.Visible = false;
            stgr.Visible = false;
            ktgr.Visible = false;

            tron.Visible = true;
            troff.Visible = false;

            dbon.Enabled = true;
            dboff.Enabled = true;

            tr.Text = "off";
        }

        //                  DOUBLET ON
        private void dbon_Click(object sender, EventArgs e)
        {

            this.Size = new System.Drawing.Size(1480, 900);

            btn_crash.Location = new Point(30, 80);
            btn_ride.Location = new Point(30, 155);
            btn_bell.Location = new Point(30, 230);
            btn_tom1.Location = new Point(30, 305);
            btn_tom2.Location = new Point(30, 380);
            btn_tom3.Location = new Point(30, 455);
            btn_ohh.Location = new Point(30, 530);
            btn_chh.Location = new Point(30, 605);
            btn_snare.Location = new Point(30, 680);
            btn_kick.Location = new Point(30, 755); 

            cgr.Location = new Point(90, 70); cgr.Size = new Size(800, 75);
            rgr.Location = new Point(90, 145); rgr.Size = new Size(800, 75);
            rbgr.Location = new Point(90, 220); rbgr.Size = new Size(800, 75);
            t1gr.Location = new Point(90, 295); t1gr.Size = new Size(800, 75);
            t2gr.Location = new Point(90, 370); t2gr.Size = new Size(800, 75);
            t3gr.Location = new Point(90, 445); t3gr.Size = new Size(800, 75);
            ohgr.Location = new Point(90, 520); ohgr.Size = new Size(800, 75);
            chgr.Location = new Point(90, 595); chgr.Size = new Size(800, 75);
            sgr.Location = new Point(90, 670); sgr.Size = new Size(800, 75);
            kgr.Location = new Point(90, 745); kgr.Size = new Size(800, 75);

            cdgr.Location = new Point(50, 35); cdgr.Size = new Size(745, 35);
            rdgr.Location = new Point(50, 35); rdgr.Size = new Size(745, 35);
            rbdgr.Location = new Point(50, 35); rbdgr.Size = new Size(745, 35);
            t1dgr.Location = new Point(50, 35); t1dgr.Size = new Size(745, 35);
            t2dgr.Location = new Point(50, 35); t2dgr.Size = new Size(745, 35);
            t3dgr.Location = new Point(50, 35); t3dgr.Size = new Size(745, 35);
            ohdgr.Location = new Point(50, 35); ohdgr.Size = new Size(745, 35);
            chdgr.Location = new Point(50, 35); chdgr.Size = new Size(745, 35);
            sdgr.Location = new Point(50, 35); sdgr.Size = new Size(745, 35);
            kdgr.Location = new Point(50, 35); kdgr.Size = new Size(745, 35);

            cdgr.Visible = true;
            rdgr.Visible = true;
            rbdgr.Visible = true;
            t1dgr.Visible = true;
            t2dgr.Visible = true;
            t3dgr.Visible = true;
            ohdgr.Visible = true;
            chdgr.Visible = true;
            sdgr.Visible = true;
            kdgr.Visible = true;

            dbon.Visible = false;
            dboff.Visible = true;

            tron.Enabled = false;
            troff.Enabled = false;

            db.Text = "on";
        }

        //                  DOUBLET OFF
        private void dboff_Click(object sender, EventArgs e)
        {
            btn_crash.Location = new Point(30, 75);
            btn_ride.Location = new Point(30, 130);
            btn_bell.Location = new Point(30, 185);
            btn_tom1.Location = new Point(30, 240);
            btn_tom2.Location = new Point(30, 295);
            btn_tom3.Location = new Point(30, 350);
            btn_ohh.Location = new Point(30, 405);
            btn_chh.Location = new Point(30, 460);
            btn_snare.Location = new Point(30, 515);
            btn_kick.Location = new Point(30, 570);

            this.Size = new System.Drawing.Size(1480, 700);

            cgr.Location = new Point(90, 70); cgr.Size = new Size(800, 50);
            rgr.Location = new Point(90, 125); rgr.Size = new Size(800, 50);
            rbgr.Location = new Point(90, 180); rbgr.Size = new Size(800, 50);
            t1gr.Location = new Point(90, 235); t1gr.Size = new Size(800, 50);
            t2gr.Location = new Point(90, 290); t2gr.Size = new Size(800, 50);
            t3gr.Location = new Point(90, 345); t3gr.Size = new Size(800, 50);
            ohgr.Location = new Point(90, 400); ohgr.Size = new Size(800, 50);
            chgr.Location = new Point(90, 455); chgr.Size = new Size(800, 50);
            sgr.Location = new Point(90, 510); sgr.Size = new Size(800, 50);
            kgr.Location = new Point(90, 565); kgr.Size = new Size(800, 50);

            cdgr.Visible = false;
            rdgr.Visible = false;
            rbdgr.Visible = false;
            t1dgr.Visible = false;
            t2dgr.Visible = false;
            t3dgr.Visible = false;
            ohdgr.Visible = false;
            chdgr.Visible = false;
            sdgr.Visible = false;
            kdgr.Visible = false;

            dbon.Visible = true;
            dboff.Visible = false;

            tron.Enabled = true;
            troff.Enabled = true;

            db.Text = "off";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bring_Click(object sender, EventArgs e)
        {
            if(presets.Text == "Smells Like Teen Spirit - Nirvana")
            {
                if(tr.Text == "on" || db.Text == "on")
                {
                    dboff.PerformClick();
                    troff.PerformClick();
                }

                Clear();
                b1.Checked = true;
                b5.Checked = true;
                b9.Checked = true;
                b13.Checked = true;
                d5.Checked = true;
                d8.Checked = true;
                d10.Checked = true;
                d13.Checked = true;
                e1.Checked = true;
                e4.Checked = true;
                e9.Checked = true;
                e11.Checked = true;
                e12.Checked = true;
                e15.Checked = true;
                bpm_cmb.SelectedIndex = 5;
                bpm_ap.PerformClick();
            }

            if (presets.Text == "Pursuit Of Vikings - Amon Amarth")
            {
                if(tr.Text == "on")
                {
                    troff.PerformClick();
                }

                dbon.PerformClick();
                Clear();
                a1.Checked = true;

                b3.Checked = true;
                b5.Checked = true;
                b7.Checked = true;
                b9.Checked = true;
                b11.Checked = true;
                b13.Checked = true;
                b15.Checked = true;

                d3.Checked = true;
                d7.Checked = true;
                d11.Checked = true;
                d15.Checked = true;

                e1.Checked = true;
                e4.Checked = true;
                e5.Checked = true;
                e9.Checked = true;
                e10.Checked = true;
                e12.Checked = true;
                e13.Checked = true;
                e14.Checked = true;
                e16.Checked = true;

                dk10.Checked = true;
                dk13.Checked = true;
                dk15.Checked = true;

                bpm_cmb.SelectedIndex = 3;
                bpm_ap.PerformClick();
            }

            if (presets.Text == "Cemetery Gates - Pantera")
            {
                if (tr.Text == "on")
                {
                    troff.PerformClick();
                }

                dbon.PerformClick();

                Clear();
                
                e1.Checked = true;
                e4.Checked = true;
                e5.Checked = true;
                e9.Checked = true;

                dk2.Checked = true;
                dk4.Checked = true;
                dk5.Checked = true;
                dk6.Checked = true;
                dk10.Checked = true;
                dk12.Checked = true;
                dk13.Checked = true;
                dk14.Checked = true;

                d3.Checked = true;
                d7.Checked = true;
                d8.Checked = true;
                d11.Checked = true;
                d15.Checked = true;
                d16.Checked = true;

                a1.Checked = true;
                b2.Checked = true;
                b3.Checked = true;
                b4.Checked = true;
                b5.Checked = true;
                b6.Checked = true;
                b7.Checked = true;
                b8.Checked = true;
                b9.Checked = true;
                b10.Checked = true;
                b11.Checked = true;
                b12.Checked = true;
                b13.Checked = true;
                b14.Checked = true;
                b15.Checked = true;
                b16.Checked = true;

                bpm_cmb.SelectedIndex = 1;
                bpm_ap.PerformClick();
            }

            if (presets.Text == "After Midnight - Blink182")
            {
                if (tr.Text == "on")
                {
                    troff.PerformClick();
                }

                dbon.PerformClick();

                Clear();

                e1.Checked = true;
                e10.Checked = true;
                e11.Checked = true;

                c1.Checked = true;
                c2.Checked = true;
                c3.Checked = true;
                c4.Checked = true;
                c5.Checked = true;
                c6.Checked = true;
                c7.Checked = true;
                c9.Checked = true;
                b11.Checked = true;
                c13.Checked = true;
                c15.Checked = true;

                dch1.Checked = true;
                dch3.Checked = true;

                d5.Checked = true;
                d8.Checked = true;
                d13.Checked = true;
                d14.Checked = true;
                d16.Checked = true;

                bpm_cmb.SelectedIndex = 4;
                bpm_ap.PerformClick();

            }

        }

        private void rtm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                btn_chh.PerformClick();
            }

            if (e.KeyCode == Keys.S)
            {
                btn_ohh.PerformClick();
            }

            if (e.KeyCode == Keys.O || e.KeyCode == Keys.D0)
            {
                btn_kick.PerformClick();
            }

            if (e.KeyCode == Keys.M || e.KeyCode == Keys.K)
            {
                btn_snare.PerformClick();
            }

            if (e.KeyCode == Keys.R)
            {
                btn_ride.PerformClick();
            }

            if (e.KeyCode == Keys.F)
            {
                btn_bell.PerformClick();
            }

            if (e.KeyCode == Keys.Q || e.KeyCode == Keys.P)
            {
                btn_crash.PerformClick();
            }

            if (e.KeyCode == Keys.I || e.KeyCode == Keys.D9)
            {
                btn_tom3.PerformClick();
            }

            if (e.KeyCode == Keys.U || e.KeyCode == Keys.D8)
            {
                btn_tom2.PerformClick();
            }

            if (e.KeyCode == Keys.Y || e.KeyCode == Keys.D7)
            {
                btn_tom1.PerformClick();
            }


        }

        private void btn_chh_Click(object sender, EventArgs e)
        {
            ClHihat();
            Bounce();
        }

        private void btn_ohh_Click(object sender, EventArgs e)
        {
            OpHihat();
            Bounce();
        }

        private void btn_kick_Click(object sender, EventArgs e)
        {
            Kick();
            Bounce();
        }

        private void btn_snare_Click(object sender, EventArgs e)
        {
            Snare();
            Bounce();
        }

        private void btn_ride_Click(object sender, EventArgs e)
        {
            Ride();
            Bounce();
        }

        private void btn_bell_Click(object sender, EventArgs e)
        {
            RideBell();
            Bounce();
        }

        private void btn_crash_Click(object sender, EventArgs e)
        {
            Crash();
            Bounce();
        }

        private void btn_tom3_Click(object sender, EventArgs e)
        {
            Tom3();
            Bounce();
        }

        private void btn_tom2_Click(object sender, EventArgs e)
        {
            Tom2();
            Bounce();
        }

        private void btn_tom1_Click(object sender, EventArgs e)
        {
            Tom1();
            Bounce();
        }


    }
}
