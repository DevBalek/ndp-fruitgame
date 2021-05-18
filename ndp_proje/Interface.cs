using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje
{
    public interface IFruit
    {
        int Weight { get; set; }
        double Perform { get; set; }
        double VitaminA { get; set; }
        double VitaminC { get; set; }

        System.Drawing.Image Image { get; }

        
        void CalculatePerform();
        void CreateWeight();

    }

    public interface IGame
    {

    }

    public interface IButton
    {
        void CheckFruit(IFruit fruit);

    }

}