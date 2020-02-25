using System;
using System.Collections.Generic;
using System.Linq;

public class Palindrome
{
  public string Input;
  public static void Main()
  {
    Console.WriteLine("Enter a word to see if it's a palindrome!");
    string userInput = Console.ReadLine();
    Palindrome word = new Palindrome(userInput);
    word.IsPalindrome(word.Input);
  }

    public Palindrome(string input)
  {
    Input = input;
  }

  public void IsPalindrome(string input)
  {
  
    char[] wordChecker = input.ToCharArray();
    Array.Reverse(wordChecker);
    string check = new string(wordChecker);

    if (check == input)
    {
      Console.WriteLine("This is a Palindrome");
    }
    else {
      Console.WriteLine("This is not a palindrome");
  }

}
}