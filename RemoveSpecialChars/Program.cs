using System;
using System.Text;

namespace RemoveSpecialChars
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Write any phrase or word and I'll return it without Special Characters, keeping '-', '_', and white spaces.");

      string userString = Console.ReadLine();

      Console.WriteLine(RemoveSpecialCharacters(userString));

      Console.Write("Press any key to exit");
      Console.ReadKey();

      static string RemoveSpecialCharacters(string stringWithSpecialChars)
      {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < stringWithSpecialChars.Length; i++)
        {
          if ((stringWithSpecialChars[i] <= '9' && stringWithSpecialChars[i] >= '0') // Digits
              || (stringWithSpecialChars[i] <= 'z' && stringWithSpecialChars[i] >= 'A' // Letters
                  || (stringWithSpecialChars[i] == '-' || stringWithSpecialChars[i] == '_' || stringWithSpecialChars[i] == ' ')))// Allowed chars
          {
            sb.Append(stringWithSpecialChars[i]);
          }
        }

        string stringWithoutSpecialChars = sb.ToString();

        return stringWithoutSpecialChars.Length > 0 ? stringWithoutSpecialChars : "NA";
      }
    }
  }
}
