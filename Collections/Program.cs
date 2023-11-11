
using System.Collections.Specialized;

//String[] names = new string[] { "Ali", "Osman", "İbrahim", "Salih" };
//Console.WriteLine(names[0]);
//Console.WriteLine(names[1]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names[3]);


//names = new string[5];
//names[4] = "Ecrin";
//Console.WriteLine(names[4]);
//Console.WriteLine(names[0]);


List<string> nameList = new List<string> { "Ali", "Osman", "İbrahim", "Salih" };
Console.WriteLine(nameList[0]);
Console.WriteLine(nameList[1]);
Console.WriteLine(nameList[2]);
Console.WriteLine(nameList[3]);
nameList.Add("Ecrin");
Console.WriteLine(nameList[4]);
Console.WriteLine(nameList[0]);

