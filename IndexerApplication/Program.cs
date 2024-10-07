// See https://aka.ms/new-console-template for more information
using IndexerApplication;

IndexedNames names = new IndexedNames();
names[0] = "Zara";
names[1] = "Riz";
names[2] = "Nuha";
names[3] = "Asif";
names[4] = "Davinder";
names[5] = "Sunil";
names[6] = "Rubic";

for (int i = 0; i < IndexedNames.size; i++)
{
    Console.WriteLine(names[i]);
}
Console.ReadKey();
