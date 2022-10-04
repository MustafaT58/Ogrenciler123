// See https://aka.ms/new-console-template for more information
using FakeData;
SahteVeri sahteVeri = new SahteVeri();
Basla();
void Basla()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{i+1} {sahteVeri.AdVeri()} {sahteVeri.SoyadVeri()} {sahteVeri.SehirVeri()}");
    }
}
Console.ReadKey();