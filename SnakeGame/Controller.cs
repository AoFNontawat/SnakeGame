using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Controller
    {
        protected Model model;

        public Controller()
        {
        }

        public void AddModel(Model m)
        {
            model = m;
        }

        // virtual keyword allow the method to be overriden
        public virtual void ActionPerformed(int action)
        {
            throw new NotImplementedException();
        }
    }
}
