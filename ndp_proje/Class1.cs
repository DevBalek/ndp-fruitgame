using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ndp_proje
{
    abstract class BaseClass
    {
        public IButton _button;
        public IFruit _currentFruit;

        protected BaseClass(IButton button,IFruit currentFruit)
        {
            _currentFruit = currentFruit;
            _button = button;
        }

        public void Controller()
        {
            _button.CheckFruit(_currentFruit);
        }
    }

    class SolidButton : IButton
    {

        public void CheckFruit(IFruit fruit)
        {
            if (fruit.GetType() == typeof(Solid))
            {

            }
        }
    }

    class SqueezableButton : IButton
    {
        public void CheckFruit(IFruit fruit)
        {
            if (fruit.GetType() == typeof(Squeezable))
            {

            }
        }
    }

}
