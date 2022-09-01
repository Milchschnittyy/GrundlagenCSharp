// See https://aka.ms/new-console-template for more information
string vorname = "Rene";
string nachname = "Pruchniewicz";
string alter = "17";
string klasse = "BFT22";

Console.WriteLine("Vorname: {0}", vorname);
Console.WriteLine("Nachname: {0}", nachname);
Console.WriteLine("Alter: {0}", alter);

Console.WriteLine("Geben Sie ihr Alter ein");
alter = Console.ReadLine();

Console.WriteLine($"{vorname} ist {0} {alter} Jahre alt und besucht die {klasse} des Georg-Simon-Ohm-Berufskollegs");
