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
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            game.StartGame();
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
