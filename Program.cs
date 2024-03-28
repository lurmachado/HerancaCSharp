using System;
using HerancaCSharp.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account);

            //account.Balance = 200.0; // o atributo por ser protect essa classe não tem direito a alteração,
                                       // Tem direito apenas a propria classe e a classe filha 
        }
    }
}
