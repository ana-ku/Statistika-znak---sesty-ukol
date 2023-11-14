using System;

Console.WriteLine("Zadej text:");
string radek = Console.ReadLine();

Console.WriteLine("Celkový počet znaků: " + radek.Count());

//statistika výskytu znaků
Console.WriteLine("Statistika znaků: ");
foreach (var skupina in radek.GroupBy(z => z))
{
    Console.WriteLine(skupina.Key + " - " + skupina.Count());
}

//zjistit, zda text je věta: 

bool containsWhiteSpace = radek.Any(c => char.IsWhiteSpace(c));
Console.WriteLine("Text je věta: " + containsWhiteSpace);

//počet mezer
int countSpaces = radek.Count(c => char.IsWhiteSpace(c));

Console.WriteLine("Text obsahuje: " + (countSpaces+1) + " slov");


//zjistit, zda text obsahuje číslo

bool containsDigit = radek.Any(c => char.IsDigit(c));
Console.WriteLine("Text obsahuje číslice: " + containsDigit);

//zjistit, zda text obsahuje velké písmeno

bool containsUppercase = radek.Any(c => char.IsUpper(c));
Console.WriteLine("Text obsahuje velké písmeno: " + containsUppercase);



Console.ReadLine();