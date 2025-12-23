using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GrebenschikovAA.Sprint1.Task6.V3.Lib
{
    public class DataService: ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            value = value.ToLower();
            value = Regex.Replace(value, "[-.?!)(,:;'[0-9\\]]", "");
            string[] words = value.Split(' ');
            string res = new string("");
            foreach (string word in words)
            {
                res = res + word[word.Length - 1];
            }
            return res;
        }
    }
}
