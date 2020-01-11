using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Robot strongRobot = new Robot(roboName);
            List<Robot> robots = new List<Robot>();

            
            Battlefield battlefield = new Battlefield();
            battlefield.GreetUser();

            battlefield.Fight();
        }
    }
}
