using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Misc
{
    public class Bicycle
    {
        public Bicycle() 
        { 
            _wheelCount = 2;
        }
        public Bicycle(int wheelcount)
        {
            _wheelCount = wheelcount;
        }
        private int _wheelCount;

        public int WheelCount 
        {
            get => _wheelCount; 
            set => _wheelCount = value; 
        }
    }
}
