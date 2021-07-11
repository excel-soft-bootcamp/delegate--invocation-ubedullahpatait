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

        void Update(int newNumber)
        {
            System.Console.WriteLine(newNumber);
        }

        void Delete(string key)
        {

        }


        void Task1()
        {

        }
        //void Task2(string data1)
        //{

        //}
        int Task2(int A)
        {
            return A;
        }
        bool Task3(string x, string y)
        {
            return true;
        }

        static void FunctionsAsAnArguments(Func<int, double, double> obj1, Action<int> obj2, Action<string> obj3, Action obj4, Func<int, int> obj5, Func<string, string, bool> obj6)
        {
            double calculation = obj1.Invoke(7, 8.2); //calculate
            obj2.Invoke(12);//update
            obj3.Invoke("ubed");//delete
            obj4.Invoke();//Task1
            int parameter = obj5.Invoke(10);//task2
            bool result = obj6.Invoke("ubed", "patait");//Task3
            Console.WriteLine(calculation);
            Console.WriteLine(intparameter);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Program _instance = new Program();

            Func<int, double, double> _calculator = new Func<int, double, double>(Program.Calculate);
            Action<int> _update = new Action<int>(_instance.Update);
            Action<string> _delete = new Action<string>(_instance.Delete);
            Action _task1 = new Action(_instance.Task1);
            Func<int, int> _task2 = new Func<int, int>(_instance.Task2);
            Func<string, string, bool> _task3 = new Func<string, string, bool>(_instance.Task3);
            FunctionsAsAnArguments(_calculator, _update, _delete, _task1, _task2, _task3);

            Console.ReadKey();



        }
    }
    }
}
