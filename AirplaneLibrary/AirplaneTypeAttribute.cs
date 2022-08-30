using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneLibrary
{
    public enum AirplaneTypes { SportPlane = 1, CargoPlane, TurboProp, Jet};
    // 1) add enum AirplaneTypes with values SportPlane, CargoPlane, TurboProp, Jet

    // 2) set attribute AttributeUsage with parameters that allow to use class AirplaneTypeAttribute
    // for classes only, disable inheritance and enable multiple using

    // 3) derive class AirplaneTypeAttribute from System.Attribute and protect against inheritance
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       Inherited = false, AllowMultiple = true)  // multiuse attribute  
]
    public sealed class AirplaneTypeAttribute : Attribute
    {
        public AirplaneTypes AirplaneType { get; set; }
        // 4) declare public property Type with type - AirplaneTypes 
        // 5) declare 2 constructors:
        public AirplaneTypeAttribute(AirplaneTypes airplaneType = AirplaneTypes.TurboProp)
        {
            AirplaneType = airplaneType;
        }
        // default - initialize Type  with AirplaneTypes.TurboProp
        // parameter - with type AirplaneTypes
        //add two AirplaneTypeAttribute-s to UniversalAirplane
        //add AirplaneTypeAttribute to CargoAirplane

    }
}
