namespace Task_1
{
    public class Program
    {
        public static void Main (string [] args){
        // Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива. 
            System.Console.Clear();
            int row = 3;
            int col = 3;
            char [,] chars = InitCharArray(row, col);
            PrintCharArray(chars);
            System.Console.WriteLine($"Result => {CreateStringFromArray(chars)}");
        }
        public static string CreateStringFromArray (char [,] array){
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            string result = string.Empty;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result += array[i,j];
                }
            }
            return result;
        }
        public static char [,] InitCharArray (int row, int col){
            char [,] array = new char [row,col];
            Random rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array [i,j] = (char)rand.Next('a','z');
                }
            }
            return array;
        }

        public static void PrintCharArray (char [,] array){
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    System.Console.Write(array[i,j] + " ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }
}