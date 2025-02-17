// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! Part 5");

string firstFriend = "      \"James\" ";
string secondFriend = "  \"Mary\"       ";
Console.WriteLine($"My friends are {firstFriend.Trim()} and {secondFriend.Trim()}. {{  }}");
Console.WriteLine("My friends are " + firstFriend.TrimStart() + " and " + secondFriend.TrimEnd() + ". {  }");

var name = "    Mark    ";
name = name.Trim();
Console.WriteLine($"Hello, {name}!");