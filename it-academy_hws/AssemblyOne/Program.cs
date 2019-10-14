using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // для поля писать не буду, т.к. принцип такой же
            Motorcycle motorcycle = new Motorcycle();

            motorcycle.StartEngineInternal();
            motorcycle.StartEngineProtectedInternal();
            motorcycle.StartEnginePublic();

            motorcycle.internalSpeed = 200;
            motorcycle.protectedInternalSpeed = 200;
            motorcycle.publicSpeed = 200;

            NeSportBike neSport = new NeSportBike();

            neSport.StartEngineInternal();
            neSport.StartEngineProtectedInternal();
            neSport.StartEnginePublic();

            neSport.internalSpeed = 200;
            neSport.protectedInternalSpeed = 200;
            neSport.publicSpeed = 200;


            //neSport.StartEnginePrivateProtected();
            //neSport.StartEngineProtected();
            //neSport.protectedSpeed = 200;
            //neSport.privateProtectedSpeed = 200;
            // но смотрим ниже
            neSport.GetProtectedMethodsFromParent(200,200);

        }
    }
}
