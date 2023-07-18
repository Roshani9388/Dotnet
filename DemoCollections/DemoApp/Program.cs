// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using HR;
List<Person> student=new List<Person>();
student.Add(new Person{FirstName="sss",LastName="hdhfk"});

Dictionary<string,Person> p=new Dictionary<string, Person>();
p.Add("ceo",new Person{FirstName="vcjjvh",LastName="xhgxyvf"});
Person pceo=p["ceo"];

Stack<string> callerStudent=new Stack<string>();
callerStudent.Push("sainya");
string theStudent=callerStudent.Pop();
