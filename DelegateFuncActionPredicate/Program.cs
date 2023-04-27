using System;

namespace DelegateFuncActionPredicate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> multiplication = delegate (int param1, int param2)
            {
                return param1 + param2;
            };
            Predicate <int> checkIfMaj =  delegate(int result) {
                if (result > 10) return true;
                else  return false;
            
              
            };

            Action<bool> displayResultMessage = (bool checkResult) => {
                if (checkResult) Console.WriteLine("il prodotto è maggiore di 10 ");
                else Console.WriteLine("il prodotto è minore di 10");
            };

            int result = multiplication(10, 20);

            bool checkResult = checkIfMaj(result);

            displayResultMessage(checkResult);

            



        }
        

    }
}
