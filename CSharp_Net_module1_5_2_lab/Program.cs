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
                UniversalPlane universalPlane = new UniversalPlane(AirplaneTypes.CargoPlane);
                trace.CheckClassAttribute(universalPlane);
                trace.SaveTrace(universalPlane);
                trace.EventLogging(universalPlane);
                var attrs = trace.GetType().GetCustomAttributes(typeof(AirplaneTypeAttribute),true);
                foreach(var item in attrs)
                {

                    Console.WriteLine(item.ToString());
                }
            }
                Console.ReadKey();
        }
    }
}
