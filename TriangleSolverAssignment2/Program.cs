// See https://aka.ms/new-console-template for more information
using TriangleSolverAssignment2;

Console.WriteLine("Enter firstSide");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter secondSide");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter thirdSide");
int thirdSide = Convert.ToInt32(Console.ReadLine());
string triangleType = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide); ;
Console.WriteLine("Triangle Type: " + triangleType);

