using System;
class JadooAndPositiveIntegers
{
    //trick is to keep the code as short as possible. Including the identifier names and everything
    public JadooAndPositiveIntegers()
    {int t = Convert.ToInt16(Console.ReadLine()); int s = 0; while (t-- > 0) { int n = Convert.ToInt16(Console.ReadLine()); s = s + ((n > 0) ? n : 0); } Console.Write(s); }
}