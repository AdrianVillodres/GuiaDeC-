using System;
namespace GuiaDeComandos
{
    public class GuiaDeComandos
    {
        public static void Main()
        {
            // / -> division 6/2 -> 3
            // % -> resto 6%2 -> 0

            int r = 6;
            Console.WriteLine("valor r: " + r++);
            Console.WriteLine("valor de r despues : " + r);

            int s = 2;
            Console.WriteLine("valor s: " + ++s);
            Console.WriteLine("valor de s despues : " + s);

            int num = 4;
            num++; // <- num + 1
            num = num + 4;

            num = num / 5;
            num /= 5;

            num = num + 3;
            num += 3;

            Console.WriteLine(3 > 5);
            bool isCorrect = (4 > 5 && 10 != 2);
            Console.WriteLine($"el valor es {isCorrect}");
            Console.WriteLine((4 > 5 && 10 != 2) || (num <= 2));

            //salida por pantalla
            Console.WriteLine("Hola!");
            Console.WriteLine($"Tu num {num} y el bool {isCorrect}");
            Console.WriteLine("Tu num {0} y el bool {1}", num, isCorrect);

            char letter = 'A';
            int numASCII = letter;

            Console.WriteLine($"El valor decimal de {numASCII} es {letter}");


            double valor = 10.99;
            int valorS = (int)valor;

            Console.WriteLine($"valor double : {valor} - valor int {valorS}");


            int numerito = Convert.ToInt32(valor);

            int numerazo = int.Parse(Console.ReadLine());

            Console.WriteLine("Dame un numero");
            int luckyNumber;

            bool isNumber = Int32.TryParse(Console.ReadLine(), out luckyNumber);

            if (Int32.TryParse(Console.ReadLine(), out luckyNumber))
            {
                Console.WriteLine($"Tu numero es {luckyNumber}");
            }
            else
            {
                Console.WriteLine("Error");
            }

            int number = (4 > 5) ? 4 : 2;
            int numerio = ((5 > 5) ? (2 < 2) ? 2 : 1 : 4);

            if (4 > 5)
            {
                if (2 < 2)
                {
                    numerio = 2;
                }
                else
                {
                    numerio = 1;
                }
            }
            else
            {
                numerio = 4;
            }

            string pokemon = "Charizard";
            string attack = "";
            Console.WriteLine("Selecciona el ataque");
            switch (pokemon)
            {
                case "Charizard":
                    attack = Console.ReadLine();
                    if(attack == "Llamarada")
                    {
                        Console.WriteLine("Lanzo llamarada");
                    }else if(attack == "Lanzallamas")
                    {
                        Console.WriteLine("Lanzo lanzallamas");
                    }
                    else
                    {
                        Console.WriteLine("No reconozco el ataque");
                    }
                    break;
                case "Bulbasaur":
                    Console.WriteLine("Selecciona el ataque");
                    Console.WriteLine("1 - Danza petalo");
                    Console.WriteLine("2 - Drenadoras");
                    attack = Console.ReadLine();
                    switch (Convert.ToInt32(attack))
                    {
                        case 1:
                            Console.WriteLine("Has lanzado danza petalo");
                            break;
                        case 2:
                            Console.WriteLine("Has lanzado drenadoras");
                            break;
                        default:
                            Console.WriteLine("No reconozco el ataque");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("No conozco al pokemon");
                    break;
            }

        }
    }
}
