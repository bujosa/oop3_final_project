using System;
using System.Text;

namespace convertidor
{
    class MainClass
    {
        public static int number, choice2, choice, num2;
        public static string num, num1, dato;
        public static char x;

        // Menu de opciones del convertidor de sistema numericos 
        public static void opcion1()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" 1. Decimal a binario\n 2. Octal a binario\n 3. Hexadecimal a binario\n 4. Salir");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:

                        Console.WriteLine("Ingrese el numero decimal\n");
                        number = Convert.ToInt32(Console.ReadLine());
                        if (number > 0)
                        {
                            string xtring = " ";
                            while (number > 0)
                            {
                                if (number % 2 == 0)
                                {
                                    xtring = "0" + xtring;
                                }
                                else
                                {
                                    xtring = "1" + xtring;
                                }
                                number = (int)(number / 2);
                            }
                            Console.WriteLine("El numero binario es " + xtring);
                        }

                        break;
                    case 2:

                        Console.WriteLine("Ingrese el numero octal\n");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        number = Convert.ToInt32(num2.ToString(), 8);
                        num1 = Convert.ToString(number, 2);

                        Console.WriteLine("El numero binario es " + num1);

                        break;
                    case 3:

                        Console.WriteLine("Escribe el numero hexadecimal");
                        num1 = Convert.ToString(Console.ReadLine());
                        num = Convert.ToString(Convert.ToInt32(num1, 16), 2);
                        Console.WriteLine("El numero binario es " + num);

                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Solo eliga una de las opciones establecidads!!");
                        break;
                } 

            
            } while (choice2 != 4);
            return;
        }

        public static void opcion2()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" 1. Binario a decimal \n 2. Octal a decimal\n 3. Hexadecimal a decimal \n 4. Salir ");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:

                        Console.WriteLine("Ingrese el numero binario\n");
                        num1 = Console.ReadLine();
                        number = Convert.ToInt32(num1, 2);
                        Console.WriteLine("El numero decimal es " + number);

                        break;
                    case 2:

                        Console.WriteLine("Ingrese el numero octal");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        number = Convert.ToInt32(num2.ToString(), 8);
                        num1 = Convert.ToString(number, 10);
                        Console.WriteLine("El numero decimal es " + num1);

                        break;
                    case 3:

                        Console.WriteLine("Ingrese el numero hexadecimal\n");
                        num1 = Console.ReadLine();
                        number = Convert.ToInt32(num1, 16);
                        Console.WriteLine("El numero decimal es " + number);

                        break;
                    case 4:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Solo eliga una de las opciones establecidas!!");
                        break;
                }
            
            }while(choice2 != 4);
             return;
        }

        public static void opcion3()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" 1. Binario a octal \n 2. Decimal a octal\n 3. Hexadecimal a octal\n 4. Salir ");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
              
                    Console.WriteLine("Ingrese el numero binario\n");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    number = Convert.ToInt32(num2.ToString(), 2);
                    num1 = Convert.ToString(number, 8);

                    Console.WriteLine("El numero octal es " + num1);
                        break;
                    case 2:
                
                    Console.WriteLine("Ingrese el numero decimal\n");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    number = Convert.ToInt32(num2.ToString(), 10);
                    num1 = Convert.ToString(number, 8);

                    Console.WriteLine("El numero octal es " + num1);
                        break;
                case 3:
                    Console.WriteLine("Ingrese el numero hexadecimal\n");
                    num1 = Convert.ToString(Console.ReadLine());
                    num = Convert.ToString(Convert.ToInt32(num1, 16), 8);

                    Console.WriteLine("El numero octal es " + num);
                    break;
                 case 4:
                        break;
                default:
                        Console.Clear();
                Console.WriteLine("Solo eliga una de las opciones establecidas!!");
                break;
            }
            } while (choice2 != 4);
            return;
        }

        public static void opcion4()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" 1. Binario a hexadecimal \n 2. Decimal a hexadecimal\n 3. Octal a hexadecimal \n 4. Salir");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                
               case 1:
                    Console.WriteLine("Ingrese el numero binario\n");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    number = Convert.ToInt32(num2.ToString(), 2);
                    num1 = Convert.ToString(number, 16);

                    Console.WriteLine("El numero hexadecimal es " + num1);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el numero decimal\n");
                     num2 = Convert.ToInt32(Console.ReadLine());
                    number = Convert.ToInt32(num2.ToString(), 10);
                    num1 = Convert.ToString(number, 16);

                    Console.WriteLine("El numero hexadecimal es " + num1);
                    break;
                case 3:
                    Console.WriteLine("Ingrese el numero octal\n");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    number = Convert.ToInt32(num2.ToString(), 8);
                    num1 = Convert.ToString(number, 16);

                    Console.WriteLine("El numero hexadecimal es " + num1);
                    Console.ReadKey();
                
                break;
                  case 4:
                        break;
                default:
                        Console.Clear();
                Console.WriteLine("Solo eliga una de las opciones establecidas!!");
                break;
            }
            } while (choice2 != 4);
            return;
        }

        public static void Digitar()
        {
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(" 1. Numero a simbolo \n 2. Simbolo a numero \n 3. Salir ");
                choice2 = Convert.ToInt32(Console.ReadLine());

                switch (choice2)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Escriba el numero:");
                        number = Convert.ToInt32(Console.ReadLine());
                        x = (char)number;
                        Console.WriteLine(x);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escriba el simbolo:");
                        dato = (Console.ReadLine());
                        Console.WriteLine(Encoding.ASCII.GetBytes(dato)[0]);
                        break;

                    case 3:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Solo escribi las opciones validas en el sistema!!");
                        break;

                }
               

            } while (choice2 != 3);
            return;

        }

        public static void ascii()
        {
           
            do
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Menu de Ascii\n\n 1. Digitar simbolo\n 2. Salir\n");
                choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        Console.Clear();
                        Digitar();
                        Console.ReadKey();
                        break;
                    case 2:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Solo digitar las opciones validas en el sistema!!");
                        break;
                }
                
            
            } while (choice2 != 2);
            return;
        }

        public static void Main(string[] args)
        {
           
          
            do
            {
                Console.Clear();
                Console.WriteLine("Convertidor de Sistemas Numericos y Sistema Ascii \n");
                Console.WriteLine(" 1. Binario\n 2. Decimal \n 3. Octal \n 4. Hexadecimal \n 5. Sistema Ascii \n 6. Salir");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        opcion1();
                        Console.ReadKey();
                        break;
                    case 2:
                        opcion2();
                        Console.ReadKey();
                        break;
                    case 3:
                        opcion3();
                        Console.ReadKey();
                        break;
                    case 4:
                        opcion4();
                        Console.ReadKey();
                        break;
                    case 5:
                        ascii();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escriba solo una de las opciones validas en el sistema\n\n");
                        break;
                }
            } while (choice != 6);
            Console.Clear();
            Console.WriteLine("Hasta Luego!!");
            return;

        }
    }
}
