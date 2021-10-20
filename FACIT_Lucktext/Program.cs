using System;

string name = "";
string favoriteSport = "";
string petName = "";

Console.WriteLine("Skriv in ditt namn:");
name = Console.ReadLine();

Console.WriteLine("Skriv in din favoritsport:");
favoriteSport = Console.ReadLine();

Console.WriteLine("Skriv in namnet på ditt husdjur:");
petName = Console.ReadLine();

//------------------------------------------------------------------------------

Console.WriteLine($"Hördu {name}, jag har hört att du är jättedålig på {favoriteSport}.");
Console.WriteLine($"Du är så dålig att till och med {petName} skrattar åt dig!");

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();
