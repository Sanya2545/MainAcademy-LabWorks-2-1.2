using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneLibrary
{
    [AirplaneType(AirplaneTypes.CargoPlane)]
    public class UniversalPlane
    {
        private AirplaneTypes Type;
        public AirplaneTypes typeOfPlane
        {
            get
            {
                return Type;
            }
            set
            {
                Type = value;
            }
        }
        public UniversalPlane(AirplaneTypes type)
        {
            typeOfPlane = type;
        }
    }
}
