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
    class Game
    {
        private System.Windows.Forms.Timer timer1;

        Label countDown;
        Label labelVitA;
        Label labelVitC;
        Label labelPuree;
        Label labelName;
        Label labelnewC;
        Label labelnewA;
        Label labelnewPure;
        PictureBox pictureBox1;

        List<Fruit> fruits = new List<Fruit>();


        //Variables
        int index;
        Random random = new Random();

        double sumVitA;
        double sumVitC;
        double sumPure;

        public void StartGame()
        {

            //For Acces form1 controls
            countDown = Application.OpenForms["Form1"].Controls["countDown"] as Label;
            pictureBox1 = Application.OpenForms["Form1"].Controls["pictureBox1"] as PictureBox;
            labelVitA = Application.OpenForms["Form1"].Controls["labelVitA"] as Label;
            labelVitC = Application.OpenForms["Form1"].Controls["labelVitC"] as Label;
            labelPuree = Application.OpenForms["Form1"].Controls["labelPuree"] as Label;
            labelName = Application.OpenForms["Form1"].Controls["labelName"] as Label;
            labelnewC = Application.OpenForms["Form1"].Controls["labelnewC"] as Label;
            labelnewA = Application.OpenForms["Form1"].Controls["labelnewA"] as Label;
            labelnewPure = Application.OpenForms["Form1"].Controls["labelnewPure"] as Label;



            #region Prep     

            //Solid Fruit Items
            Fruit apple = new Fruit(new Solid(54, 5, FileName("apple.jpg"),"Elma"));
            Fruit pear = new Fruit(new Solid(25, 5, FileName("pear.jpg"),"Armut"));
            Fruit strawberry = new Fruit(new Solid(12, 60, FileName("strawberry.jpg"),"Çilek"));

            //Squeezable Fruit Items
            Fruit mandarin = new Fruit(new Squeezable(681, 26, FileName("mandarin.jpg"),"Mandalina"));
            Fruit orange = new Fruit(new Squeezable(225, 45, FileName("orange.png"),"Portakal"));
            Fruit grapefruit = new Fruit(new Squeezable(3, 44, FileName("grapefruit.jpg"),"Greyfurt"));


            //   t.Image = apple._fruit.Image;

            //List
            fruits.Add(apple);
            fruits.Add(pear);
            fruits.Add(strawberry);
            fruits.Add(mandarin);
            fruits.Add(orange);
            fruits.Add(grapefruit);

            #endregion

            //First Picture
            RandomPhoto();
          
        }

        private Image FileName(string fruitName)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath);
            string fruitPath = Path.Combine(dir, @"%filename%".Replace("%filename%", fruitName));

            Image image;

            image = Image.FromFile(fruitPath);

            return image;
        }

        public void SolidButton()
        {
            BaseClass check = new BaseClass(new SolidButton(), fruits[index]._fruit);

            if(check.Controller() == true)
            {
                 IFruit currentFruit = fruits[index]._fruit;

                double pure = currentFruit.Perform;
                double vitA = currentFruit.VitaminA;
                double vitC = currentFruit.VitaminC;

                sumPure += pure;
                sumVitA += vitA;
                sumVitC += vitC;

                labelVitA.Text = sumVitA.ToString();
                labelVitC.Text = sumVitC.ToString();
                labelPuree.Text = sumPure.ToString();

                labelnewA.Text = "+ " + vitA.ToString();
                labelnewC.Text = "+ " + vitC.ToString();
                labelnewPure.Text = "+ " + pure.ToString();


                RandomPhoto();
            }
           
        }

        public void SqueezableButton()
        {
            BaseClass check = new BaseClass(new SqueezableButton(), fruits[index]._fruit);

            if (check.Controller() == true)
            {
                IFruit currentFruit = fruits[index]._fruit;

                double pure = currentFruit.Perform;
                double vitA = currentFruit.VitaminA;
                double vitC = currentFruit.VitaminC;

                sumPure += pure;
                sumVitA += vitA;
                sumVitC += vitC;

                labelVitA.Text = sumVitA.ToString();
                labelVitC.Text = sumVitC.ToString();
                labelPuree.Text = sumPure.ToString();

                labelnewA.Text = "+ " + vitA.ToString();
                labelnewC.Text = "+ " + vitC.ToString();
                labelnewPure.Text = "+ " + pure.ToString();

                RandomPhoto();
            }
        }

        private void RandomPhoto()
        {
           
            index = random.Next(0, 6);

            pictureBox1.Image = fruits[index]._fruit.Image;
            labelName.Text = fruits[index]._fruit.Name;
        
        }

    }
}
