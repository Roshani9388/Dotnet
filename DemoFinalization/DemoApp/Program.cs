// See https://aka.ms/new-console-template for more information
using HR;
Console.WriteLine("Before");
using(Person p=new Person{FirstName="Sainya",LastName="Vishwakarma"}){
    Console.WriteLine(p);
};
Console.WriteLine("After");
GC.Collect();
