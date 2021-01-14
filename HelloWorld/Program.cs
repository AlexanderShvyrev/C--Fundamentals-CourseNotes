using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HelloWorld.Math;
using HelloWorld.People;

namespace HelloWorld
{

    //public enum ShippingMethod
    //{
    //    RegularAirMail = 1,
    //    RegisteredAirMail = 2,
    //    Express = 3
    //}
    class Program
    {
        static void Main(string[] args)

        {
            //++++++++++++++++++++++++PRIMITIVE TYPEs+++++++++++++++++++++++++++++++++++


            //byte number =2;
            //int count = 10;
            //float totalPrice = 20.95f; //f stands for float explicitly tells complier to use float
            //char character = 'A';//single quotes
            //string firstName = "Alex";//double quotes
            //bool isWorking = false;

            //Console.WriteLine(number);
            //Console.WriteLine(count);
            //Console.WriteLine(totalPrice);
            //Console.WriteLine(character);
            //Console.WriteLine(firstName);
            //Console.WriteLine(isWorking);


            //lines below represent a range of value that can be stored in one or another variable
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);//returns 0 255
            //Console.WriteLine("{0} {1}", float.MaxValue, float.MaxValue);//returns 3.4028235E+38 3.4028235E+38


            //const float Pi = 3.14f; //immutable value

            //int i = 1000;
            //byte b = (byte)i;
            //Console.WriteLine(b);//will return 232 because of data loss

            //string number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);

            //string number = "1234";
            //byte b = Convert.ToByte(number);
            //Console.WriteLine(b); //will throw an exception and app will crash

            //try
            //{
            //string number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("The number could not be converted to a byte");
            //}

            //var a = 10;
            //var b = 3;
            //Console.WriteLine(a / b); //will return 3 because of int type

            //var c = 10;
            //var d = 3;
            //Console.WriteLine((float)c / (float)d);//will return 3.333333


            //+++++++++++++++++++++++++++NON-PRIMITIVE TYPEs++++++++++++++++++++++++++++++

            //int result = Calculator.Add(1, 2);
            //Console.WriteLine(result);

            //var alex = new Person();
            //alex.FirstName = "Alex";
            //alex.LastName = "Shvyrev";
            //alex.Introduce();

            //string firstName = "Alex";
            //string lastName = "Shvyrev";

            //string fullName = string.Format("My name is {0} {1}", firstName, lastName);


            //var names = new string[3] { "John", "Jack", "Mary" };
            //var formattedNames = string.Join(",", names);
            //Console.WriteLine(formattedNames);

            ////+++++++++++++++++++++verbatim string (@) lets you skip \n and \\ for backslashes++++++++++++++++++++

            //var text = @"
            //Hi John
            //Look into the following paths
            //c:\folder1\folder3
            //c:\folder4\folder4
            //";
            //Console.WriteLine(text);

            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);//3



            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId); //Express


            ////Conver enum to string
            //Console.WriteLine(method.ToString());//Express

            ////Convert string to enum
            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            //Console.WriteLine(shippingMethod);


            ////++++++++++++++++++++++++++Reference types and value types++++++++++++++++


            ////Value types
            //var a = 10;
            //var b = a;
            //b++;
            //Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //a:10, b:11;

            ////Reference types point to the same address in memory. Though, will be changed simultaniously
            //var array1 = new int[4] { 1, 2, 3, 4 };
            //var array2 = array1;
            //array2[0] = 0;

            //Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));//will return 0 and 0







            //=========================CONDITIONAL STATEMENTS=============================

            //int hour = 19;
            //if(hour > 0 && hour<12)
            //{

            //    Console.WriteLine("It's morning");
            //}
            //else if(hour >= 12 && hour <18)
            //{
            //    Console.WriteLine("It's afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening");
            //}




            //bool isGoldCustomer = true;
            //float price;
            //if(isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            ////OR

            //float priceOne = (isGoldCustomer) ? 19.95f : 29.95f;



            ////OR SWITCH CASE

            //var season = Season.Fall;

            //switch(season)
            //{
            //    case Season.Fall:
            //        Console.WriteLine("It's Fall");
            //        Console.WriteLine("We've got promotion");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("It's Summer");
            //        break;
            //    case Season.Spring:
            //        Console.WriteLine("It's Spring");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("It's Winter");
            //        break;
            //    default:
            //        Console.WriteLine("Your season did not match");
            //        break;
            //}



            ////===========================ITERATION==================

            ////FOR LOOPS

            //for(var k=1; k<10; k++)
            //{
            //    if(k%2==0)
            //    {
            //        Console.WriteLine(k);
            //    }
            //}

            ////FOREACH LOOPS
            //var name = "John Smith";

            //foreach( var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            //var numbers = new int[] { 1, 3, 4, 5 };
            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}


            ////WHILE LOOPS
            //int i = 0;
            //while(i<10)
            //{
            //    if(i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            ////while (true)
            ////{
            ////    Console.Write("Type your name");
            ////    var input = Console.ReadLine();
            ////    if (String.IsNullOrWhiteSpace(input))
            ////        break;
            ////    Console.WriteLine("@Echo: " + input);
            ////}

            ////DO WHILE LOOPS
            ////executed at least once

            //do
            //{
            //    //xome code here
            //    i++;
            //} while (i < 10);



            //==================Random class===========

            //var random = new Random();
            //for(var i=0; i<10; i++)
            //{
            //    Console.Write((char)random.Next(97,122));//will print a random string because 97-122 represent characters in computer
            //}

            //================Example creating passwords with random class

            //var random = new Random();
            //const int passwordLength = 10;
            //var buffer = new char[passwordLength];
            //for(var i=0; i<passwordLength; i++)
            //{
            //    buffer[i] = (char)('a' + random.Next(0, 26));
            //    var password = new string(buffer);
            //    Console.WriteLine(password);// will return a random string 10 characters long
            //}


            //=========================ARRAYS========================

            //var numbers = new[] { 3, 4, 6, 7, 8, 0 };
            ////Length
            //Console.WriteLine(numbers.Length);

            ////IndexOf()

            //var index = Array.IndexOf(numbers, 8);
            //Console.WriteLine(index);

            ////Clear
            //Array.Clear(numbers, 0, 2);

            //foreach(var num in numbers)
            //    Console.WriteLine(num);

            ////Copy
            //var another = new int[3];
            //Array.Copy(numbers, another, 3);
            //Console.WriteLine("===========");
            //foreach(var n in another)
            //    Console.WriteLine(n);

            ////Sort
            //Array.Sort(numbers);
            //foreach(var k in numbers)
            //    Console.WriteLine(k);

            ////Reverse
            //Array.Reverse(numbers);
            //foreach (var j in numbers)
            //    Console.WriteLine(j);




            //=========================LISTS========================


            //var numbers = new List<int>() { 1, 2, 3, 4 };

            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });

            //foreach (var num in numbers)
            //    Console.WriteLine(num);

            //Console.WriteLine("Index of 4: " + numbers.IndexOf(4));
            //Console.WriteLine();

            //Console.WriteLine("Count: " + numbers.Count);



            //    Console.Write("Type your name ");
            //    var userName = (string)Console.ReadLine();
            //    for(var i=userName.Length-1; i>=0; i--)
            //{

            //    Console.Write(userName[i]);
            //}




            //====================DATE TIME+++++++++++++++++++++

            //DateTime is immutable

            //var dateTime = new DateTime(2021, 1, 1);
            //var now = DateTime.Now;
            //var today = DateTime.Today;

            ////Console.Write(now.Hour);
            ////Console.Write(now.Minute);

            //var tomorrow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);

            //Console.WriteLine(now.ToShortDateString());

            ////TimeSpan

            ////Creating
            //var timeSpan = new TimeSpan(1, 2, 3);
            //var timeSpan1 = new TimeSpan(1, 0, 0);
            //var timeSpan2 = TimeSpan.FromHours(1);

            //var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(2);
            //var duration = end - start;
            //Console.WriteLine("Duration: " + duration);

            ////Properties

            //Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            ////Add
            //Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            ////ToString
            //Console.WriteLine("ToString " + timeSpan.ToString());

            ////Parse
            //Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));   



            //++++++++++++++++++++++++++++STRINGS++++++++++++++++

            //var fullName = "Alex Shvyrev ";
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            //var index = fullName.IndexOf(' ');
            //var firstName = fullName.Substring(0, index);
            //var lastName = fullName.Substring(index + 1);

            //Console.WriteLine("First Name: " + firstName);
            //Console.WriteLine("Last Name: " + lastName);

            ////OR

            //var names = fullName.Split(' ');
            //Console.WriteLine("First Name: " + names[0]);
            //Console.WriteLine("Last Name: " + names[1]);


            //Console.WriteLine(fullName.Replace("Alex", "afafffg").Replace(' ', '-'));




            //if(String.IsNullOrWhiteSpace(" "))
            //    Console.WriteLine("Invalid");


            ////Convert to int

            //var str = "25";
            //var age = Convert.ToByte(str);
            //Console.WriteLine(age);

            ////Convert int to string

            //float price = 29.95f;

            //Console.WriteLine(price.ToString("C"));


            //===========================SUMMARIZING TEXT===================

            //var sentence = "This is going to be a really really really really long text";

            //var summary = StringUtility.SummerizeText(sentence, 25);
            //Console.WriteLine(summary);

            //=============================String Builder===========

            //var builder = new StringBuilder();

            //builder
            //    .Append('-', 10)
            //    .AppendLine()
            //    .Append("Header")
            //    .AppendLine()
            //    .Append('-', 10)

            //    .Replace('-', '+')

            //    .Remove(0, 10)

            //    .Insert(0, new string('-', 10));

            //Console.WriteLine(builder);




            //===================File, FileInfo==============

            //var path = @"c:\somefile.jpg";

            //File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true); //copies file from one directory to another
            //File.Delete(path);
            //if(File.Exists(path))
            //{
            //    //some code
            //}

            //var content = File.ReadAllText(path);

            //var fileInfo = new FileInfo(path);
            //fileInfo.CopyTo("...", true);
            //fileInfo.Delete();
            //if(fileInfo.Exists)
            //{
            //    //some code
            //}




            //=======================Directory, DirectoryInfo=================

            //Directory.CreateDirectory(@"c:\temp\folder!");

            //var files = Directory.GetFiles(@"c:\projects\csharp\fundamentals", "*.jpg*", SearchOption.AllDirectories);
            //foreach(var file in files)
            //    Console.WriteLine(file);



            //var directories = Directory.GetDirectories(@"c:\projects\csharp\fundamentals", "*.*", SearchOption.AllDirectories);

            //foreach(var directory in directories)
            //    Console.WriteLine(directory);

            //Directory.Exists(@"c:\projects\folder1");

            //var directoryInfo = new DirectoryInfo("some path");
            //directoryInfo.GetFiles();
            //directoryInfo.GetDirectories();


            //============================PAth=================================

            //var path = @"c:\projects\somefile.jpg";

            //var dotIndex = path.IndexOf('.');
            //var extension = path.Substring(dotIndex);


            //Console.WriteLine(Path.GetExtension(path));

            //Console.WriteLine(Path.GetFileName(path));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            //Console.WriteLine(Path.GetDirectoryName(path));




        }


    }
}
