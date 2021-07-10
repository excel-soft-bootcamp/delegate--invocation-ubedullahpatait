using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocation
{
    class DelegateInvocationType
    {

        static double Calculate(int x, double y) 
        { 
            return x + y; 
        }

        void Update(int newNumber) { System.Console.WriteLine(newNumber); }

        void Delete(string key) { }

        void obj()
        {
        }

        void obj2(string data) 
        { 
        }

        int obj3(int x)
        {
            return x;
        }

        bool obj4(string name , string adress)
        {
          

        }

        static void FunctionsAsAnArguments(Action obj, Action<string> obj2, Func<int, int> obj3, Func<string, string, bool> obj4)
        {

            //Invoke Delegate objects


        }

    }
}
