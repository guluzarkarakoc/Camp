

using GenericsIntro;

MyList<string> names = new MyList<string>();

names.Add("Ali");
Console.WriteLine(names.Length);

names.Add("Salih");
Console.WriteLine(names.Length);

foreach (var name in names.Items)
{
    Console.WriteLine(name);
}

