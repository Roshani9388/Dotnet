// See https://aka.ms/new-console-template for more information
using TestApp;

Console.WriteLine("Hello, World!");

Salesdashboard s1 = new Salesdashboard();

OrderDetails details = s1;

CustomerDetails customer = s1;

details.ShowDetails();

customer.ShowDetails();
s1.Refresh();
