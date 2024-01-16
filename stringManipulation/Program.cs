// learning how to creat a list of <T>. add new and sort.
// order from the end of the list concept / loop for each name in names "list".

var names = new List<string>
 {
     "Moe",
     "Abby",
     "Alia",
 };
    names.Add("Adam");
    names.Add("Sayed");
    names.Add("Hassan");
    names.Sort();

    Console.WriteLine(names[^1]);
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
};
