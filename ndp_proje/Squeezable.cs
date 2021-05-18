using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje
{
    class Squeezable : IFruit
    {
        //Interface
        public int Weight { get; set; }
        public double Perform { get; set; }
        public double VitaminA { get; set; }
        public double VitaminC { get; set; }
        public Image Image { get; set; }

        //Variables
        int randomNumber;
        Random rand = new Random();

        //Cons
        public Squeezable(double VitaminAper100, double VitaminCper100, Image SqueezablePhoto)
        {
            Image = SqueezablePhoto;

            CreateWeight();
            CalculatePerform();

            VitaminA = Weight * VitaminAper100 / 100;
            VitaminC = Weight * VitaminCper100 / 100;
            
        }

        public void CalculatePerform()
        {
            randomNumber = rand.Next(1, 100);
            
            Perform = Weight * randomNumber / 100;
        }

        public void CreateWeight()
        {
            randomNumber = rand.Next(30, 70);      
            Weight = randomNumber;
        }
    }
}
