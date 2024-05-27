using MemontoDesignPattern;
using System;

Storage storage = new();
storage.Append("hakuna");
storage.Save();
storage.Append("matata");
storage.Save();
storage.Append("john");
storage.Save();
storage.Append("doe");
storage.Save();
storage.Append("kamil");
storage.Save();
Console.ReadLine();
try
{
	while (true)
	{
		storage.Show();
		storage.Undo();
        Console.ReadLine();
    }
}
catch (Exception)
{


}