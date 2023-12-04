namespace Task_2
{
    public class Program
    {
        public static void Main (string [] args){
            // Задайте строку, содержащую латинские буквы
            // в обоих регистрах. Сформируйте строку, в которой все
            // заглавные буквы заменены на строчные.
            System.Console.Write("Input string =>");
            string ? str = System.Console.ReadLine();
            string newStr = str.ToLower();
            System.Console.WriteLine($"new string => {newStr}");
        }
    }
}