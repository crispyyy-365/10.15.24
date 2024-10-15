using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string sen = "    I loVE ProgramINg   ";
               
               

            Console.WriteLine(MakeCorrect(sen));
        }
        public static string MakeCorrect (string str)
        {
            string[] arr = Regex.Split(@"/s+", " ");



            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Append(Char.ToUpper(arr[i][0]));

                for (int j = 1; j < arr[i].Length; j++)
                {
                    arr[i].Append(Char.ToLower(arr[i][j]));
                }
            }

            return string.Join(" ", arr);
        }
    }
}
