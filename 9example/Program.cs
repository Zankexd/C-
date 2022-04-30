string a = Console.ReadLine();
string b = Console.ReadLine();
int a1 = int.Parse(a);
int b1 = int.Parse(b);
if (a1 * a1 == b1)
{
    Console.WriteLine("Pravda1");
}
if (b1 * b1 == a1)
{
    Console.WriteLine("Pravda2");
}
else
{
    Console.WriteLine("Nety pary");

}