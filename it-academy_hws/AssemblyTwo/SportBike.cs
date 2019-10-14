using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyOne;

namespace AssemblyTwo
{
    public class SportBike : Motorcycle
    {
        void TestingInClass()
        {
            StartEngineProtectedInternal();
            StartEnginePublic();
            StartEngineProtected();

            //StartEngineInternal();

            //StartEnginePrivate();
            //StartEnginePrivateProtected();

            //-----------------------------------------//

            protectedInternalSpeed = 200;
            publicSpeed = 200;
            protectedSpeed = 200;

            //internalSpeed = 200;

            //privateProtectedSpeed = 200;
            //privateSpeed = 200;

        }
        public void GetProtectedMethodsFromParent(ushort _protected, ushort _privateProtected)
        {
            StartEngineProtectedInternal();
            StartEngineProtected();
            protectedSpeed = 200;
            protectedInternalSpeed = 200;
        }
    }
}
