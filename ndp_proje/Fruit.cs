using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ndp_proje
{

    class Fruit 
    {
        public IFruit _fruit;

        //Constraction
        public Fruit(IFruit fruit)
        {
            _fruit = fruit;

        }
    }
}
