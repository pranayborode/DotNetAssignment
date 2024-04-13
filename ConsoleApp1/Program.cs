
using ConsoleApp1;
using ConsoleApp1.TheorySession;

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


Student std1 = new Student();

Student std2 = new Student("Rahul");

Student std3 = new Student("Ganesh");

Console.WriteLine(std1.Display());
Console.WriteLine(std2.Display());
Console.WriteLine(std3.Display());

Console.WriteLine($"Total Count {Student.GetCount()}");

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