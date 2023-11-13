using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            oops op = new oops();
            op.setorderid(11, 300, "02/01/1968", "02/01/1968", "aready", "mohammed");
            oops opps = new oops();
              opps.setorderid(-1, 500, "02/01/1968", "052/01/1968", "aready", "mohsam5med");



            op.getorderid();
            opps.getorderid();


        }
    }
}
