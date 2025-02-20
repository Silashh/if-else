using System;

namespace Conditionals
{
    class Program
    {
       
        static void Main(string[] args)
        {
             // 1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)
               Console.WriteLine(" ENTER A NUMBER ");
               double number = Convert.ToDouble(Console.ReadLine());

               if (number < 0) {
                   Console.WriteLine(" The number is negative ");
               }
               else if (number > 0) {
                   Console.WriteLine(" The number is positive ");
               }
               else
               {
                   Console.WriteLine(" The number is zero ");
               }
          
              // 2: Gün İsmi Belirleme (switch-case)

              Console.WriteLine(" ENTER A NUMBER (1-7) ");
              int daynumber = Convert.ToInt32(Console.ReadLine());
              string dayname;



                  switch (daynumber)
                  {
                      case 1:
                      dayname = "MONDAY";
                          break;

                      case 2:
                      dayname = " TUESDAY ";
                          break;

                      case 3:
                          dayname = " WEDNESDAY ";
                          break;

                      case 4:
                          dayname = " THURSDAY ";
                          break;

                      case 5:
                          dayname = " FRIDAY ";
                          break;

                      case 6:
                          dayname = " SATURDAY ";
                          break;

                      case 7:
                          dayname = " SUNDAY ";
                          break;

                      default:
                          dayname = "PLEASE ENTER A VALID NUMBER";
                          break;


                  }
              Console.WriteLine($"{dayname}");  

            //3-Basit Hesap Makinesi (switch-case)

            Console.Write(" PLEASE ENTER THE FIRST NUMBER : ");
            double number1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("PLEASE ENTER THE SECOND NUMBER: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("SELECT THE OPERATION YOU WANT TO PERFORM: ");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.Write("Your choice: ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Result: {number1}+{number2}= {result}");
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"Result: {number1}-{number2}= {result}");
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"Result: {number1}*{number2}= {result}");
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine($"Result: {number1}/{number2}= {result}");
                    break;
                default:
                    Console.WriteLine("PLEASE CHOOSE A VALID OPERATION");
                    break;

            } 

            //4-Üç Sayının En Büyüğünü Bulma (if-else)
            Console.Write(" PLEASE ENTER THE FIRST NUMBER : ");
            double number1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("PLEASE ENTER THE SECOND NUMBER: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" PLEASE ENTER THE THIRD NUMBER : ");
            double number3 = Convert.ToDouble(Console.ReadLine());

            if (number1 >= number2 && number1 >= number3)
            {
                Console.WriteLine($"THE BIGGEST NUMBER IS {number1}");
            }
            else if (number2 >= number1 && number2 >= number3)
            {
                Console.WriteLine($"THE BIGGEST NUMBER IS {number2}");
            }
            else
            {
                Console.WriteLine($"THE BIGGEST NUMBER IS {number3}");
            }
            

            //5-Şifre Güçlülüğünü Kontrol Etme (if-else)

            Console.Write("Please enter a password: ");
            string password = Console.ReadLine();

            bool lengthCheck = password.Length >= 8;
            bool specialCharacterCheck = false;
            bool uppercaseCheck = false;

          
            char[] specialCharacters = { '@', '#', '$', '%' };

            foreach (char c in password)
            {
                if (Array.Exists(specialCharacters, element => element == c))
                {
                    specialCharacterCheck = true;
                }

                if (char.IsUpper(c))
                {
                    uppercaseCheck = true;
                }
            }

            
            if (lengthCheck && specialCharacterCheck && uppercaseCheck)
            {
                Console.WriteLine("Your password is strong.");
            }
            else
            {
                Console.WriteLine("Your password is weak. It must meet the following criteria:");
                if (!lengthCheck)
                {
                    Console.WriteLine("- It must be at least 8 characters long.");
                }
                if (!specialCharacterCheck)
                {
                    Console.WriteLine("- It must contain at least one special character (@, #, $, %).");
                }
                if (!uppercaseCheck)
                {
                    Console.WriteLine("- It must contain at least one uppercase letter.");
                }


            }


        }
    }
}
