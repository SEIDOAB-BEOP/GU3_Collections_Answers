using Models;
using Seido.Utilities.SeedGenerator;

Console.WriteLine("Hello, Group Assignment3 Collections!");
var rnd = new csSeedGenerator();

//Instantiate and initialize a list
//IMyList<int> ints1 = null; 
IMyList<int> ints1 = new csMyList<int>();
for (int i = 0; i < 50; i++)
{
    ints1?.Add(rnd.Next(0,100));
}

System.Console.WriteLine("\nNr of occurances of each ints");
ints1?.ItemsOccurances.ToList().ForEach(item => System.Console.WriteLine($"{item.Key} occur {item.Value} time(s)"));

System.Console.WriteLine($"\n{nameof(ints1)} contains duplicates: {ints1?.ContainsDuplicates}");
System.Console.WriteLine($"\n{nameof(ints1)} contains pairs: {ints1?.ContainsPair}");
System.Console.WriteLine($"\n{nameof(ints1)} contains tripplets: {ints1?.ContainsTripplets}");
System.Console.WriteLine($"\n{nameof(ints1)} contains quads: {ints1?.ContainsQuads}");
System.Console.WriteLine($"\n{nameof(ints1)} contains fullhouse: {ints1?.ContainsFullHouse}");

System.Console.WriteLine("\nUnique items List");
var intsUnique = ints1?.UniqueItems;
System.Console.WriteLine($"{nameof(intsUnique)} contains {intsUnique?.Count} items");
intsUnique?.ToList().ForEach(i => System.Console.WriteLine(i));


//Instantiate and initialize a list
//IMyList<csWine> wines1 = null; 
IMyList<csWine> wines1 = new csMyList<csWine>();

rnd.ItemsToList<csWine>(50).ForEach(w => wines1?.Add(w));

System.Console.WriteLine("\nNr of occurances of each wine");
wines1?.ItemsOccurances.ToList().ForEach(item => System.Console.WriteLine($"{item.Key} occur {item.Value} time(s)"));

System.Console.WriteLine($"\n{nameof(wines1)} contains duplicates: {wines1?.ContainsDuplicates}");
System.Console.WriteLine($"\n{nameof(wines1)} contains pairs: {wines1?.ContainsPair}");
System.Console.WriteLine($"\n{nameof(wines1)} contains tripplets: {wines1?.ContainsTripplets}");
System.Console.WriteLine($"\n{nameof(wines1)} contains quads: {wines1?.ContainsQuads}");
System.Console.WriteLine($"\n{nameof(wines1)} contains fullhouse: {wines1?.ContainsFullHouse}");

System.Console.WriteLine("\nUnique items List");
var winesUnique = wines1?.UniqueItems;
System.Console.WriteLine($"{nameof(winesUnique)} contains {winesUnique?.Count} items");
winesUnique?.ToList().ForEach(i => System.Console.WriteLine(i));