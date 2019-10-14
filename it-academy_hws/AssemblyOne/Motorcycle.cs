using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
    public class Motorcycle
    {

        ushort maxSpeed = 300;
        string vinNumber = "kakieto cifri i bukvi";
        int odometer = 20_000;

        public ushort publicSpeed = 300;
        private ushort privateSpeed = 300;
        protected ushort protectedSpeed = 300;
        internal ushort internalSpeed = 300;
        protected internal ushort protectedInternalSpeed = 300;
        private protected ushort privateProtectedSpeed = 300;

        void TestingInClass()
        {
            StartEngineInternal();
            StartEngineProtectedInternal();
            StartEnginePublic();

            StartEnginePrivateProtected();
            StartEngineProtected();

            StartEnginePrivate();

            publicSpeed = 200;
            privateSpeed = 200;
            protectedSpeed = 200;
            internalSpeed = 200;
            protectedInternalSpeed = 200;
            privateProtectedSpeed = 200;
        }

        public void StartEnginePublic()
        {

        }
        private void StartEnginePrivate()
        {

        }
        protected void StartEngineProtected()
        {

        }
        internal void StartEngineInternal()
        {

        }
        protected internal void StartEngineProtectedInternal()
        {

        }
        private protected void StartEnginePrivateProtected()
        {

        }


    }
}
