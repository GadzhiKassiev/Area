using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExample
{
    public class Triangle
    {
        float catheter1;
        float catheter2;

        public float Catheter1
        {
            get { return catheter1; }
            set { if (value > 0)  catheter1 = value; }
        }

        public float Catheter2
        {
            get { return catheter2; }
            set { if (value > 0) catheter2 = value; }
        }

        public float Area()
        {
            return catheter1 * catheter2 / 2;
        }
    }
}
