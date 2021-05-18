/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje Ödevi
**				ÖĞRENCİ ADI............: Muhammed Furkan Balek
**				ÖĞRENCİ NUMARASI.......: G191210069
**              DERSİN ALINDIĞI GRUP...: D Grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;
        private int counter = 60;

        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            start_btn.Enabled = false;
            solidFruit_btn.Enabled = true;
            squeezableFruit_btn.Enabled = true;


            //Timer Started
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            countDown.Text = counter.ToString();

            game.StartGame();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();

                solidFruit_btn.Enabled = false;
                squeezableFruit_btn.Enabled = false;
                start_btn.Enabled = true;
                MessageBox.Show("Süreniz Doldu.");
            }
            countDown.Text = counter.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void solidFruit_btn_Click(object sender, EventArgs e)
        {
            game.SolidButton();
        }

        private void squeezableFruit_btn_Click(object sender, EventArgs e)
        {
            game.SqueezableButton();
        }

    }

}
