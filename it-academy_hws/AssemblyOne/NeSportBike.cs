using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class NeSportBike : Motorcycle
    {
        void TestingInClass()
        {
            StartEngineInternal();
            StartEngineProtectedInternal();
            StartEnginePublic();

            StartEnginePrivateProtected();
            StartEngineProtected();

            //StartEnginePrivate();


            //-----------------------------------------//


            publicSpeed = 200;
            internalSpeed = 200;
            protectedInternalSpeed = 200;

            protectedSpeed = 200;
            privateProtectedSpeed = 200;

            //privateSpeed = 200;
        }

        public void GetProtectedMethodsFromParent(ushort _protected, ushort _privateProtected)
        {
            StartEnginePrivateProtected();
            StartEngineProtected();
            protectedSpeed = 200;
            privateProtectedSpeed = 200;
        }
    }
}
