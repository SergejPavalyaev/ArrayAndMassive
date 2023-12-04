using System.Drawing;

namespace KlassWork
{
    public class Program
    {
        public static void Main (string [] args){
            System.Console.Clear(); //очистка консоли
            // string str = "Hello";
            // char [] chars = CreateChar(str);
            // // System.Console.WriteLine(CreateString(chars));
            // PrintArray(chars);

            // Task 3.
            // Считать строку с консоли, состоящую из латинских
            // букв в нижнем регистре. Выяснить, сколько среди
            // введённых букв гласных.
            System.Console.Write("Input word => ");
            string ? str = System.Console.ReadLine();
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            char [] word = CreateChar(str);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
            char [] item = {'e','y','u','i','o','a'};
            int count = FindCountItem(word, item);
            System.Console.WriteLine($"Count of vowels => {count}");


        }
        public static int FindCountItem (char [] word, char [] item){
            int result = 0;
            int size = word.Length;
            int sizeItem = item.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < sizeItem; j++)
                {
                    if (word[i] == item [j]) result++;
                }
            }
            return result;
        }
        public static char [] CreateChar (string str){
            int size = str.Length;
            char [] chars = new char [size];
            for (int i = 0; i < size; i++)
            {
                chars[i]=str[i];
            }
            return chars;
        }

        public static string CreateString (char [] array){
            int size = array.Length;
            string result = string.Empty;
            for (int i = 0; i < size; i++)
            {
                result += array[i];
            }
            return result;
        }
        public static void PrintArray (char [] array){
            foreach (char item in array)
            {
                System.Console.Write(item + ", ");
            }
            System.Console.WriteLine();
        }
    }
}