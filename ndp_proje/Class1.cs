using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje
{
    class BaseClass
    {
        public IButton _button;
        public IFruit _currentFruit;

        public BaseClass(IButton button,IFruit currentFruit)
        {
            _currentFruit = currentFruit;
            _button = button;
        }

        public bool Controller()
        {
            return _button.CheckFruit(_currentFruit);
        }
    }

    class SolidButton : IButton
    {

        public bool CheckFruit(IFruit fruit)
        {
            if (fruit.GetType() == typeof(Solid))
            {
                return true;
            }
            else return false;
        }
    }

    class SqueezableButton : IButton
    {
        public bool CheckFruit(IFruit fruit)
        {
            if (fruit.GetType() == typeof(Squeezable))
            {
                return true;
            }
            else return false;
        }
    }

}
