using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public abstract class Animals
    {
        public string color { get; set; }

        public int age { get; set; }

        public string name { get; set; }

        public string gender { get; set; }

        public string breed { get; set; }

        public virtual string MakeNoise()
        {
            return "Noise";

        }


    }

    
}
