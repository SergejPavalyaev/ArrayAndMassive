namespace Task_3
{
    public class Program
    {
        public static void Main (string [] args){
            // Задайте произвольную строку. Выясните, является ли она палиндромом.
            System.Console.Clear();
            System.Console.Write("Input string => ");
            string ? str = System.Console.ReadLine();
            bool flag = CheckPalindrome(str);
            if (flag) System.Console.WriteLine("Yes");
            else System.Console.WriteLine("No");
        }
        public static bool CheckPalindrome (string str){
            int size = str.Length;
            bool flag = false;
            for (int i = 0; i < size / 2; i++)
            {
                if (str[i] == str[size-1-i]) flag = true;
                else flag = false;
            }
            return flag;
        }
    }
}