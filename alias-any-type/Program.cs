// See https://aka.ms/new-console-template for more information
using Address = (string city, string postalCode);
using PathOfPoints = int[];
using DatabaseInt = int?;
using Measurement = (string units, int distance);

using Person = (string name, int age);

void Method(Measurement x) 
{
    Console.WriteLine($"Method! {x.units} {x.distance} ");
}


Console.WriteLine("Hello, human!");

Person person = new Person("Javier", 22);
Address address = new Address("My home", "ES-50105");
PathOfPoints points = new int[] { 2, 5, 5 };

Method(new Measurement("meters", 23));


Console.WriteLine("End. Click enter to exit");
Console.ReadLine();
