
using ConsoleApp1;
using ConsoleApp1.TheorySession;
using ConsoleApp1.TheorySession.Collection;
using ConsoleApp1.TheorySession.IEnumerator_Enumerator;
using ConsoleApp1.TheorySession.Interface;
using ConsoleApp1.TheorySession.PartialClass;
using ConsoleApp1.TheorySession.PartialMethods;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Transactions;
using static ConsoleApp1.TheorySession.Collection.Player;

// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

string name = "Pranay"; // 4bytes

char ch = 'A';// 1byte

short s1 = 100;  //2bytes

int no = 1212; //4bytes

long l1 = 434353; //8 bytes

float f1 = 33.33f; //4bytes

double d1 = 50.50; // 8 bytes

decimal dec = 99.99M; //16 bytes

// print the output
Console.WriteLine("Integer number is "+no+" decimal number is "+d1);

//using placeholder    or
Console.WriteLine("Integer number is {0} and float number is {1}", no, f1);

//string interpolation --> $  or
Console.WriteLine($"Integer number is {no} and float number is {f1}");

//accept the values from user --> Consloe.ReadLine()--> return string
Console.WriteLine("Enter Your Name");
string name1 = Console.ReadLine();

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter your salary");
double salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("hello "+name1);

Console.WriteLine($"Hello {name1}, your age is {age} and salary is {salary}");*/

/*Employee emp1 = new Employee();

emp1.Assign();
emp1.CalculateSalary();
string result = emp1.display();
Console.WriteLine(result);


Employee emp2 = new Employee();

emp2.Accept(101, "Pranay", 5500.00, 2200.00, 1100.00);
emp2.CalculateSalary();
Console.WriteLine(emp2.display());

*/

/*Employee emp1 = new Employee(1,"Pranay",2000, 1000, 250);
emp1.CalculateSalary();
Console.WriteLine(emp1.display());


//object of child class
Manager m1 = new Manager(2, "Rahul", 3000, 2000, 500, 1000);
m1.CalculateSalary();
Console.WriteLine(m1.display());


//create reference of base class, but object of child class
Employee e1 = new Manager(3, "Ganesh",4000, 2000, 500, 1000);
m1.CalculateSalary();
Console.WriteLine(e1.display());*/


/*Student std1 = new Student();

Student std2 = new Student("Rahul");

Student std3 = new Student("Ganesh");

Console.WriteLine(std1.Display());
Console.WriteLine(std2.Display());
Console.WriteLine(std3.Display());

Console.WriteLine($"Total Count {Student.GetCount()}");*/

/*Date d1 = new Date();

Date d2 = new Date(15, "April", 2024);

Console.WriteLine(d1.Display());
Console.WriteLine(d2.Display());*/
/*
Product p1 = new Product();

p1.Code = 101;
p1.Name = "Mouse";
p1.Price = 670.00;

Console.WriteLine($"{p1.Code}, {p1.Name}, {p1.Price}");

Product p2 = new Product { Code = 102, Name = "Keyboard", Price = 1200.00};
Console.WriteLine($"{p2.Code}, {p2.Name}, {p2.Price}");*/


/*Book b1 = new Book();

b1.Id = 101;
b1.Name = "Yayati";
b1.Price = 340.00;

Console.WriteLine($"{b1.Id}, {b1.Name}, {b1.Price}");


Book b2 = new Book { Id=102, Name="72 Mail Ek Pravas", Price =1200.00 };

Console.WriteLine($"{b2.Id}, {b2.Name}, {b2.Price}");*/


/*Circle c1 = new Circle(6);
c1.CalculateArea();

Console.WriteLine(c1.Print());

Rectangle r1 = new Rectangle(8, 4);
r1.CalculateArea();
Console.WriteLine(r1.Print());*/


// Interface ******************************

/*Job j1 = new Job();
Console.WriteLine("Job: Tax Amount - "+j1.PayTax());

Business b1 = new Business();
Console.WriteLine("Business: Tax Amount - "+b1.PayTax());*/


/*ICustomer c1 = new Trasaction();
Console.WriteLine(c1.print());

IOrder o1 = new Trasaction();
Console.WriteLine(o1.print());*/

//Partial Class in C# ***********************************

/*Calc c1 = new Calc();
Console.WriteLine(c1.Add(10,33));
Console.WriteLine(c1.Sub(33, 10));*/


//Partial Methods in C# ***********************************

/*Calc2 c1 = new Calc2();
Console.WriteLine(c1.Add(10,33));
c1.Sub(10, 5);
c1.Mul(10, 5);  
c1.Div(10, 5);*/


// Array ********************************************
/*
int[] arr1 = new int[] { 80, 45, 12, 78, 1 };
int[] arr2 = new int[3];

foreach (int item in arr1)
{
    Console.WriteLine(item);
}

Array.Sort(arr1);
Console.WriteLine("---After sort-----");
foreach (int item in arr1)
{
    Console.WriteLine(item);
}

Array.Reverse(arr1);
Console.WriteLine("---After Reverse-----");
foreach (int item in arr1)
{
    Console.WriteLine(item);
}

//copy the 3 elements  45, 12, 1 in the new array

Array.Copy(arr1,2,arr2,0,3);
Console.WriteLine("---After copy-----");
foreach (int item in arr2)
{
    Console.WriteLine(item);
}

Array.Clear(arr1);
Console.WriteLine("---After Clear-----");
foreach (int item in arr1)
{
    Console.WriteLine(item);
}

*/
/*
string[] arr1 = new string[] { "Pune", "Amravati", "Mumbai", "Hydrabad", "Delhi" };
string[] arr2 = new string[3];

foreach (string item in arr1)
{
    Console.WriteLine(item);
}

Array.Sort(arr1);
Console.WriteLine("---After sort-----");
foreach (string item in arr1)
{
    Console.WriteLine(item);
}

Array.Reverse(arr1);
Console.WriteLine("---After Reverse-----");
foreach (string item in arr1)
{
    Console.WriteLine(item);
}

Array.Copy(arr1, 2, arr2, 0, 3);
Console.WriteLine("---After copy-----");
foreach (string item in arr2)
{
    Console.WriteLine(item);
}

Array.Clear(arr1);
Console.WriteLine("---After Clear-----");
foreach (string item in arr1)
{
    Console.WriteLine(item);
}*/

// Addition of 3*3 matrix using 2D arrya

// Collections ****************************

/*int[] arr = new int[] { 7, 2, 6, 4, 4, 1 };

ArrayList list = new ArrayList();

list.Add(12);
list.Add(23);
list.Add(35);
list.AddRange(arr);

list.RemoveAt(4);
list.Remove(12);
list.RemoveRange(2, 3);

foreach (var i in list)
{
    Console.WriteLine(i);
}
*/

//Hashtable*********************
/*
Hashtable ht = new Hashtable();

ht.Add(91, "IND");
ht.Add(93, "AFG");
ht.Add(20,"EGY");
ht.Add(33, "FRA");
ht.Add(299, "GRL");

foreach (DictionaryEntry item in ht)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

SortedList sl = new SortedList();

Console.WriteLine("Sorted List");

sl.Add(91, "IND");
sl.Add(93, "AFG");
sl.Add(20, "EGY");
sl.Add(33, "FRA");
sl.Add(299, "GRL");

foreach (DictionaryEntry item in sl)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}

*/
/*Team ind = new Team();

foreach (Player p in ind)
{
    Console.WriteLine(p);
}

Player virat = new Player("Virat", 3300);
Player rohit = new Player("Rohti", 2500);

int result = virat.CompareTo(rohit);
if (result == 1)
{
    Console.WriteLine("Virat has more runs than rohit");
}
else if (result == -1)
{
    Console.WriteLine("virat has less runs than rohit");
}
else
{
    Console.WriteLine("both have equal runs");
}

Console.WriteLine("****************************");

PlayerCompare obj = new PlayerCompare();

int r = obj.Compare(virat, rohit);

if (r==1)
{
    Console.WriteLine("Virat has more runs than rohit");

}
else if (result == -1)
{
    Console.WriteLine("virat has less runs than rohit");
}
else
{
    Console.WriteLine("both have equal runs");

}*/

/*Employees rahul = new Employees(101,"Rahul", 33000);

Employees ganesh = new Employees(102, "Ganesh", 43000);

int res = rahul.CompareTo(ganesh);
if (res == 1)
{
    Console.WriteLine("Rahul has more Salary than Ganesh");
}
else if (res == -1)
{
    Console.WriteLine("Rahul has less Salary than Ganesh");
}
else
{
    Console.WriteLine("both have equal Salary");
}*/
