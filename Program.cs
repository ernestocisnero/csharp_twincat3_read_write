using System;
using TwinCAT.Ads;

namespace TCADStut
{
    class Program
    {
        public static void Main()
        {
            AdsClient myClient = new AdsClient();
            myClient.Connect(AmsNetId.Local, 851);
            System.Console.WriteLine("ADS Client has been started.");

            var bCSharpTest = myClient.CreateVariableHandle("MAIN.bCSharpTest");

            System.Console.WriteLine("Before");
            var resp = myClient.ReadAny(bCSharpTest, typeof(bool));
            System.Console.WriteLine(resp);

            System.Console.WriteLine("After");
            myClient.WriteAny(bCSharpTest, false);
            
            resp = myClient.ReadAny(bCSharpTest, typeof(bool));
            System.Console.WriteLine(resp);
        }
    }
}
