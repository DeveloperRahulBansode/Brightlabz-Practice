using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProblems
{
    public class AccessModifiresClassess
    {
        public int publicVariable = 10;
        public void publicMethod()
        {

            Console.WriteLine("This is a public method and Variable="+publicVariable);
        }

        private int privateVariable = 20;
        private void privateMethod()
        {
           
            Console.WriteLine("This is a private method and Cariable="+privateVariable);
        }

        protected int protectedVariable = 30;
        protected void protectedMethod()
        {
            Console.WriteLine("This is a protected method and variable="+protectedVariable);
        }
        internal int internalVariable = 40;
        internal void internalMethod()
        {
            Console.WriteLine("This is a internal method and variable="+internalVariable);
        }

        internal protected int internalProtectedVariable = 50;
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("This is a protected internal method and variable="+internalProtectedVariable);
        }
        private protected int privateProtectedVariable = 60;
        private protected void privateProtectedMethod()
        {
            Console.WriteLine("This is a private protected method and variable="+privateProtectedVariable);
        }





    }
}
