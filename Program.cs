using System;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
              //Task1------------------------------------------------------------------------------------------//

                Number();
                int num = int.Parse(Console.ReadLine()!);

                int sing = 0;

                if (num < 0) {
                    sing = -1;
                    num = -num;
                    }

                else {
                    sing = 1;
                    }

                int phantom = 0;

                while(num > 0)
                {
                    int digit = num % 10;
                    phantom = phantom * 10 + digit;
                    num /= 10;
                }
            Console.WriteLine(phantom * sing);

            //Task2--------------------------------------------------------------------------------------------------//

            Text();
            string text = Console.ReadLine();
            string[] word = text.Split();
            int wordLen = word.Length;
            Number();
            int nums = Convert.ToInt32(Console.ReadLine());
            if(nums <= 0 || nums > wordLen) {
                Console.WriteLine("Невірне число");
                }
                else {
                    string[] suma = word[nums..wordLen];
                    string info = string.Join(" ", suma);
                    Console.WriteLine(info);
                }

            //Task3--------------------------------------------------------------------------------------------------------//
            Console.Write("Якої площи фігури ви хочете отрмати?\n"+
                            "1.Квадрат\n"+
                            "2.Круг\n"+
                            "3.Прямокутник\n"+
                            "4.Трикутник\n"+
                            "Введіть номер фігури: ");
            int textCase = int.Parse(Console.ReadLine());
        double infoCase;
        double infoTwoCase;
        float Pi = 3.14159f;
        switch(textCase){
            case 1:  
                Console.Write("Введіть розмір сторін: ");
                infoCase = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Площа квадрата: {infoCase * infoCase}");
                break;

            case 2:
                Console.Write("Введіть радіус круга: ");
                infoCase = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Площа круга: {Pi * infoCase * infoCase}");
                break;

            case 3:
                Console.Write("Введіть розмір першої сторони: ");
                infoCase = double.Parse(Console.ReadLine());
                Console.Write("Введіть розмір Другої сторони: ");
                infoTwoCase = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площа: {infoCase * infoTwoCase}");
                break;


            case 4:
                Console.Write("Введіть основу  трикутника: ");
                infoCase = double.Parse(Console.ReadLine());
                Console.Write("Введіть висоту трикутника: ");
                infoTwoCase = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площа трикутника: {infoCase * infoTwoCase / 2}");
                break;

            default:
            Console.WriteLine("Не вірний варіант: ");
            break;
                }
                
            
            //Task4--------------------------------------------------------------------------------------------------------//

             Text();
                string texText = Console.ReadLine();
                char[] textList = texText.ToCharArray();
                for (int i = 0; i < textList.Length; i ++)
                    {
                        int pos = i + 1;
                        if (pos % 15 == 0)
                            {
                                textList[i] = '?';
                            }
                        else if (pos % 3 == 0)
                            {
                                textList[i] = 'X';
                            }
                        else if (pos % 5 == 0)
                            {
                                textList[i] = '9';
                            }
                    }
                string res = new string(textList);
                Console.Write(res);
            }









            //Створив функцію чисто для зручності
            static void Text()
        {
            Console.Write("Введіть текст: ");

        }
        static void Number()
        {
            Console.Write("Введіть число: ");
        }
}


