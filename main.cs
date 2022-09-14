/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
double pie = 3.14159;
        double radius, length, volume, area;

        Console.Write("Enter the radius of a cylinder: " );
        radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the lenght of a cylinder: ");
        length = Convert.ToDouble(Console.ReadLine());

        area = radius * radius * pie;
        volume = area * length;

        Console.WriteLine("");

        Console.WriteLine("The area is " + area);
        Console.WriteLine("The volume is " + volume);
  }
}