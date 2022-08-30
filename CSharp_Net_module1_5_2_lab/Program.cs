using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirplaneLibrary;

namespace CSharp_Net_module1_5_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //implement  CheckSaveTrace in using block
            using (CheckSaveTrace trace = new CheckSaveTrace())
            {
                const AirplaneTypes airplane = AirplaneTypes.CargoPlane;
                AirplaneTypes universalAirplane = AirplaneTypes.Jet;
                trace.CheckClassAttribute(airplane);
                trace.SaveTrace(airplane);
                trace.EventLogging(airplane);
                trace.CheckClassAttribute(universalAirplane);
                trace.SaveTrace(universalAirplane);
                trace.EventLogging(universalAirplane);
            }
                
                Console.ReadKey();
        }
    }
}
