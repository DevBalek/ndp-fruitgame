using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ndp_proje
{
    class Game :IGame
    {
        private System.Windows.Forms.Timer timer1;

        //For Acces form1 controls
        Label countDown = Application.OpenForms["Form1"].Controls["countDown"] as Label;
        PictureBox pictureBox1 = Application.OpenForms["Form1"].Controls["pictureBox1"] as PictureBox;
        List<Fruit> fruits = new List<Fruit>();

        //Variables
        int index;
        Random random = new Random();
        string selectedButton;


        public void StartGame()
        {
            #region Prep     

            //Solid Fruit Items
            Fruit apple = new Fruit(new Solid(54, 5, FileName("apple.jpg")));
            Fruit pear = new Fruit(new Solid(25, 5, FileName("pear.jpg")));
            Fruit strawberry = new Fruit(new Solid(12, 60, FileName("strawberry.jpg")));

            //Squeezable Fruit Items
            Fruit mandarin = new Fruit(new Squeezable(681, 26, FileName("mandarin.jpg")));
            Fruit orange = new Fruit(new Squeezable(225, 45, FileName("orange.png")));
            Fruit grapefruit = new Fruit(new Squeezable(3, 44, FileName("grapefruit.jpg")));

            //   t.Image = apple._fruit.Image;

            //List
            fruits.Add(apple);
            fruits.Add(pear);
            fruits.Add(strawberry);
            fruits.Add(mandarin);
            fruits.Add(orange);
            fruits.Add(grapefruit);

            #endregion

            #region GAME

            //Timer Started
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            countDown.Text = counter.ToString();

            while (counter==0)
            {
                RandomPhoto();
            }
                endGame();
            
            #endregion
        }

        private Image FileName(string fruitName)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string fruitPath = Path.Combine(dir, @"%filename%".Replace("%filename%", fruitName));

            Image image;

            image = Image.FromFile(fruitPath);

            return image;
        }

        private int counter = 60;
        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timer1.Stop();
            countDown.Text = counter.ToString();
        }

        public void SolidButton()
        {
            selectedButton = "solid";
           
        }

        public void SqueezableButton()
        {
            selectedButton = "squeezable";
        }

        private void RandomPhoto()
        {
           
            index = random.Next(1, 6);

            pictureBox1.Image = fruits[index]._fruit.Image;

        }

        private void endGame()
        {

        }

    }
}
