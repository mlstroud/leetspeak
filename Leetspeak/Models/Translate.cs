namespace Leetspeak
{
  public class Translator
  {
    public static string Translate(string input)
    {

      char[] letters = input.ToCharArray();

      for (int i = 0; i < letters.Length; i++)
      {
        if (letters[i] == 'e' || letters[i] == 'E')
        {
          letters[i] = '3';
        }
        else if (letters[i] == 'o' || letters[i] == 'O')
        {
          letters[i] = '0';
        }
        else if (letters[i] == 'I')
        {
          letters[i] = '1';
        }
        else if (letters[i] == 't' || letters[i] == 'T')
        {
          letters[i] = '7';
        }
        else if ((letters[i] == 's' || letters[i] == 'S') && i != 0)
        {
          letters[i] = 'z';
        }
      }

      return string.Join("", letters);
    }
  }
}