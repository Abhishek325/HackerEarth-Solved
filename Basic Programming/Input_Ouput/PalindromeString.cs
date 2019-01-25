using System;

class PalindormeString
{
    public string reverseString(string original)
    {
        char[] arr = original.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
    public PalindormeString()
    {
        string input = Console.ReadLine();
        Console.WriteLine((reverseString(input) == input) ? "YES" : "NO");
    }
}