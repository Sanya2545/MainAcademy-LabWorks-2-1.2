using System;
using System.Diagnostics;
using AirplaneLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CSharp_Net_module1_5_2_lab
{
    [AirplaneType(AirplaneTypes.SportPlane)]
    public class CheckSaveTrace : IDisposable
    {
        private bool _disposed = false;
        public TraceSource Trace { get; set; }
        public EventLog Log { get; set; }

        //immplement class CheckSaveTrace:IDisposable

        //define  TraceSource and EventLog  fields
        //implement CheckSaveTrace() constructor with two methods calling
        public CheckSaveTrace(string assemblyName = "LabWork_1.2_CheckSaveTrace")
        {
            initTrace(assemblyName);
            initEventLog(assemblyName);
        }
        private void initTrace(string assemblyName)
        {
            Trace = new TraceSource(assemblyName);
        }
        private void initEventLog(string assemblyName)
        {
            Log = new EventLog(assemblyName);
        }
        public void CheckClassAttribute(object obj)
        {
            var arr = typeof(CheckSaveTrace).GetCustomAttributes(true);
            foreach (var attr in arr)
            {
                if (attr is AirplaneTypeAttribute attribute)
                {
                    Console.WriteLine(attribute.AirplaneType);
                }
            }
        }
        public void SaveTrace(object obj)
        {
            Type type = obj.GetType();
            var atributeTraceArray = type.GetCustomAttributes(true);
            var trace = atributeTraceArray.Select(x => x.ToString());
            foreach (var item in atributeTraceArray)
            {
                Console.WriteLine(item.ToString());
            }
            File.WriteAllLines("Traces.txt", trace);
        }
        public void EventLogging(object obj)
        {
            Type type = obj.GetType();
            var atributeLogArray = type.GetCustomAttributes(true);
            var log = atributeLogArray.Select(x => x.ToString());
            foreach (var item in atributeLogArray)
            {
                Console.WriteLine(item.ToString());
            }
            File.WriteAllLines("Logs.txt", log);
        }
        public void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
                Trace = null;
                Log = null;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
        }
        ~CheckSaveTrace()
        {
            Dispose(true);
        }
        //implement Dispose(bool disposing) method
    }



    //implement Dispose() method


    //implement ~CheckSaveTrace()


    //implement initEventLog method with assembly name as argument


    //implement   initTrace  method with assembly name as argument


    //implement  CheckClassAttribute(object obj) method
    //for  attributes output


    //implement SaveTrace(object obj) method
    //for obj attributes tracing


    //implement EventLogging(object obj) method
    //for obj attributes logging

}
