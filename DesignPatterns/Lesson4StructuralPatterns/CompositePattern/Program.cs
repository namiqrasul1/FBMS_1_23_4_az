using CompositePattern;
using File = CompositePattern.File;

Folder folder = new("C", "C:");
Folder folder1 = new("NewFolder", "C:/");
Folder folder2 = new("NewFolder1", "C:/NewFolder");

folder2.Add(new File("a", "C:/NewFolder/NewFolder1", 3));
folder2.Add(new File("b", "C:/NewFolder/NewFolder1", 10));
folder2.Add(new File("c", "C:/NewFolder/", 9));
folder1.Add(new File("c", "C:/NewFolder/NewFolder1", 9));
folder1.Add(folder2);

folder.Add(folder1);
folder.Add(new File("c", "C:", 10));
folder.Add(new File("c", "C:", 32));
folder.Add(new File("c", "C:", 3));
folder.Add(new File("c", "C:", 34));

Console.WriteLine(folder.Size);
