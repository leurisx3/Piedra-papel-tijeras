using System;

namespace Piedra_Papel_Tijeras
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string user, pc = "";
            string result = "";
            Random aleatory = new Random();
            num = aleatory.Next(1, 3);

            if (num == 1)
            {
                pc = "piedra";
            }
            if (num == 2)
            {
                pc = "papel";
            }
            if (num == 3)
            {
                pc = "tijeras";
            }

            Console.Write("piedra, papel o tijera? ");
            user = Console.ReadLine();

            if (pc == "piedra")
            {
                if (user == "piedra")
                {
                    result = "empate";
                }
                if (user == "papel")
                {
                    result = "has ganado!";
                }
                if (user == "tijeras")
                    result = "has perdido!";
            }
            if (pc == "papel")
            {
                if (user == "papel")
                {
                    result = "empate";
                }
                if (user == "tijeras")
                {
                    result = "has ganado!";
                }
                if (user == "piedra")
                    result = "has perdido!";
            }
            if (pc == "tijeras")
            {
                if (user == "tijeras")
                {
                    result = "empate";
                }
                if (user == "piedra")
                {
                    result = "has ganado!";
                }
                if (user == "papel")
                    result = "has perdido!";
            }
                Console.WriteLine("{0} vs {1}", user, pc);
                Console.WriteLine(result);
        }
    }
}