using System;
using System.Security.Cryptography;
using System.Text;


namespace DataTypeDemoApp
{
  class Program
  {
    static void Main(string[] args)
    {
      #region variable declarion
      //int n1, n2, m;
      //n2 = 10;
      //n1 = n2;
      //{
      //  int m = 19;
      //}
      //Console.WriteLine(m);
      #endregion

      //#region typecasting
      //int n = 10;
      //byte b = 10;
      //n = b;//Valid
      //b = n; //Invalid 4bytes cannot store singlebyte.
      //b = (byte)n;//Explicit Casting. But with this there could be dataloss

      //long l = 10;
      //float f = 10;

      //l = f;//Not valid because f range is large than l. So we get compilation error.
      //f = l;//Valid

      //To see the overflow or dataloss

      //int n = 256;// 00000000 00000000 00000001 00000000

      //We can also write
      //checked//unchecked For checked we get the overflow exception and for unchecked we dont get it
      //{
      //  byte b = (byte)n;
      //  Console.WriteLine(b);

      //}
      //#endregion


      //#region strings
      //Reference type
      //string s = "Rama";
      //s.Replace('a', 'k');
      //Console.WriteLine(s);
      ////Parsing
      //s = "100";
      //int n = int.Parse(s);
      //Console.WriteLine(s);

      //string str;
      //str = Console.ReadLine();
      //int n = 100;
      //if (int.TryParse(str, out n))
      //  Console.WriteLine((char)n);
      //else
      //{
      //  Console.WriteLine("Invalid");
      //}

      //#endregion

      //#region Var
      //var m = 10;
      //m = "Hi";//this is not correct as it is already infered as Int in above statement


      //////#endregion

      ////#region Object

      //print(100);
      //print("Hi");

      //#endregion

      //#region enums
      //days d;
      //d = days.Mon;
      //Console.WriteLine((int)d);


      ////#endregion

      //#region var&dynamic
      //var m = 10;
      ////m = "str";

      //dynamic d1, d2;
      //d1 = 10;
      //d1 = "santosh";
      //Console.WriteLine(d1 + d1.Length);

      //#endregion

      #region sbcapacity


      //StringBuilder s2 = new StringBuilder("happy day ");
      //Console.WriteLine("Capacity for " + s2 + ":" + s2.Capacity);
      //var str = ("all at thomson reuters!!!!!!!!");
      //char[] b = new char[str.Length];
      //b = str.ToCharArray();
      //foreach (var C in b)
      //{
      //  Console.WriteLine(s2.Append(C) + "-" + s2.Capacity);
      //}

      //Console.WriteLine("capacity after modifying the string " + s2 + ":" + s2.Capacity);


      #endregion

    }
    static void print(object n)
    {
      Console.WriteLine(n);
    }


  }

  enum days
  {
    Sun, Mon, Tue, Wed, Thu, Fri, Sat
  }
}
