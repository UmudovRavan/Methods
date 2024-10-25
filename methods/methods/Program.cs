using System;
using System.Security.Cryptography;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Bir int parametr qəbul edən və o ədədə qədər bütün cüt 
            // ədədlərin cəmini ekrana yazdıran, həm return type - ı olan bir method, həm də void bir method yazırsız


            

            int sum = sumOfVoidNumberInt(6);
            Console.WriteLine("The sum of even numbers: " + sum);

            sumOfVoidNumberVoid(22);

            Console.WriteLine("=====================================");

            //2.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq 
            //hala gətirən metod.Misal olaraq, name = "  Code  Acacemy   " 
            //deyə bir variable - mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "CodeAcademy" olmalıdır.



            string[] sentence = { " Code Academy   " };
            string fullSentence = removeSpace(sentence);
            Console.WriteLine(fullSentence);
        }

        static string removeSpace(string[] sentence)
        {
            string result = "";

            foreach(string word in sentence)

                if (word != " ")  
                {
                    result += word;
                }
            return result;
        }



        static int sumOfVoidNumberInt (int numbers1)
        {
            int count = 0;
           for (int i = 0; i <= numbers1; i++)
            {
                if (i % 2 == 0)
                {
                    count += i;
                }
                
            }
           return count;
        }

        static void sumOfVoidNumberVoid (int num1)
        {
            int sum = 0;
            for (int i = 0;i <= num1; i++)
            {
                if ((i % 2) == 0)
                {
                    sum += i;
                }
               
            }
            Console.WriteLine("The sum of even numbers " + sum);
        }

        
    }
}
