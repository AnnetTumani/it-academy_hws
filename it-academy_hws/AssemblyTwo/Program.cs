using AssemblyOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle motorcycle = new Motorcycle();

            //motorcycle.StartEngineProtected();
            //motorcycle.StartEngineProtectedInternal();
            motorcycle.StartEnginePublic();
            

            SportBike sport = new SportBike();

            sport.StartEnginePublic();
            //neSport.StartEngineProtected();
            //neSport.StartEngineProtectedInternal();
            //neSport.protectedSpeed = 200;
            //neSport.protectedInternalSpeed = 200;
            // однако мы можем вызвать его через открытые для этой области видимости модификаторы доступа
            sport.GetProtectedMethodsFromParent(200,200);
        }
    }
}
