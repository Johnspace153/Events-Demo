

using GenericsDemo;
using GenericsDemo.Models;

GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
peopleHelper.PrintToConsole(new PersonModel { FirstName = "Aj" });

Console.ReadLine();