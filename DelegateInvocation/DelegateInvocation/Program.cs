using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateInvocationType DelegateRef = new DelegateInvocationType();

            Func<int, double, double> calculateptr = new Func<int, double, double>(DelegateInvocationType.Calculate);

                Action<int> updateptr = new Action<int>(DelegateRef.update);

            Action<string> Deleteptr = new Action<string>(DelegateRef.Delete);

           FunctionArgument()



        }
    }
}
