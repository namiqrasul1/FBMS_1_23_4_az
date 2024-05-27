// See https://aka.ms/new-console-template for more information
using StatePattern;

Car car = new();

for (int i = 0; i <100; i++)
{
    car.Drive(i);
    Thread.Sleep(500);
}
