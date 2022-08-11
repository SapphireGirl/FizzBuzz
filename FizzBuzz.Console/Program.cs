using FizzBuzz.Console.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Run FizzBuzz and get string

FbModel fb = new FbModel();

var mystring = fb.RunFizzBuzz();
Console.WriteLine(mystring);
