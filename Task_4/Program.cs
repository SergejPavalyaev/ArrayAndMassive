namespace Task_4
{
    public class Program
    {
        public static void Main (string [] args){
            // Задайте строку, состоящую
            // из слов, разделенных пробелами. Сформировать строку,
            // в которой слова расположены в обратном порядке. В
            // полученной строке слова должны быть также разделены
            // пробелами.
            System.Console.WriteLine("Input sentence => ");
            string str = System.Console.ReadLine();
            char sep = ' ';
            string [] strAround = CreateArrayFromString (str, sep);
            System.Console.WriteLine("Result => ");
            System.Console.WriteLine(TurnAroundArray(strAround));
        }
        public static string TurnAroundArray (string [] array){
            int size = array.Length;
            string result = string.Empty;
            for (int i = 0; i < size; i++)
            {
                result += array [size - 1 - i] + " ";
            }
            return result;
        }
        public static string [] CreateArrayFromString (string str, char sep){
            string tempStr = string.Empty;
            int size = str.Length;
            int temp = -1;
            int count = 0;
            int h = 0;
            bool flag = false;
            for (int i = 0; i < size; i++)
            {
                if (str[i] == sep) count++;
            }
            string [] result = new string [count + 1];
            for (int i = 0; i < size; i++)
            {
                if (str[i] == sep) {
                    for (int j = temp + 1; j < i; j++)
                    {
                        tempStr += str[j];
                    }
                    result[h] = tempStr;
                    temp = i;
                    h++;
                    tempStr = string.Empty;
                    flag = true;
                }
            }
            if (flag) {
                for (int i = temp + 1; i < size; i++)
                {
                    tempStr += str[i];
                }
                result[h] = tempStr;
            }
            else {
                result[h] = str; 
            }
            return result;
        }
        public static void PrintArrayString (string [] array){
            int size = array.Length;
            for (int i = 0; i < size; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }
    }
}