using Lesson11;
using System.Text;
using System.Text.Json;

#region Yield
//IEnumerable<int> GetDatas()
//{
//    yield return 0;
//    yield return 1;
//    yield return 2;
//    yield return 3;
//    yield return 4;
//    yield return 5;
//    yield return 6;
//    yield break;
//    yield return 8;
//    yield return 9;
//    yield return 10;
//    yield return 11;
//}


//foreach (var item in GetDatas())
//{
//    Console.WriteLine(item);
//}
#endregion


/////// Stream
// FileStream
// MemoryStream
// NetworkStream

////// AdapterStream
// StreamWriter, StreamReader
// BinaryWriter, BinaryReader

// File, FileInfo
// Directory, DirectoryInfo
// Path // C:\Users\namiqrasullu\source\repos\Lesson11\Lesson11.sln
//Console.WriteLine( Directory.GetCurrentDirectory());


#region Stream Write and Read

// way 1

//var data = "Hakuna Matata 42";

//using var fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write);

//var bytes = Encoding.UTF8.GetBytes(data);
//fs.Write(bytes);
//fs.Flush();
//fs.Write(Encoding.UTF8.GetBytes("kamil necesen?"));
//fs.Flush();
//fs.Close();

//using var fs = new FileStream("text.txt", FileMode.Open);

//var buffer = new byte[fs.Length];

//fs.Read(buffer, 0, buffer.Length);

//var data = Encoding.UTF8.GetString(buffer);
//Console.WriteLine(data);

#endregion

List<Book> books = new()
{
    new Book(1, "Sefiller", "Victor Hugo", "Drama"),
    new Book(2, "1984", "Geogre Orweel", "Drama"),
    new Book(3, "Angels and Demons", "Dan Brown", "Dedective")
};

//try
//{
//    using FileStream fs = new FileStream("books.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//    foreach (var book in books)
//    {
//        var bytes = Encoding.UTF8.GetBytes(book.ToString());
//        fs.Write(bytes);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//foreach (var book in books)
//{
//    File.AppendAllText("books.txt", book.ToString() + "\n");
//}

#region Copy
//var sourcePath = @"C:\Users\namiqrasullu\Downloads\capture.webp";
//var destPath = @"C:\Users\namiqrasullu\Desktop\kamil.webp";

//using (var source = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
//{
//    using (var dest = new FileStream(destPath, FileMode.Create, FileAccess.Write))
//    {
//        //source.CopyTo(dest); // easy mode
//        var len = 10;
//        var fileSize = source.Length;
//        var buffer = new byte[len];

//        do
//        {

//            len = source.Read(buffer, 0, buffer.Length);
//            dest.Write(buffer, 0, len);
//            Console.WriteLine(fileSize);
//            fileSize -= len;

//        } while (len != 0);

//    }
//}


#endregion

#region Serialize

// Json => JavaScript Object Notation
/*
{
    "Id" : 1,
    "Name": "Hakuna",
    "Author": {
        "Name": "Kamil"
    }
    "AnyKey": [ {} , {},  {}]
} 
 
 
*/

//var json = JsonSerializer.Serialize(books, options: new JsonSerializerOptions() { WriteIndented = true });
//File.WriteAllText("books.json", json);

//var json = File.ReadAllText("books.json");

//var bookList = JsonSerializer.Deserialize<List<Book>>(json);

//foreach (var item in bookList)
//{
//    Console.WriteLine(item);
//}

//var book = new Book(2, "name1", "auhtor1", "genre1")
//{
//    Some = new Some { MyProperty = 42 }
//};

//var json = "{\"Id\":2,\"Name\":\"name1\",\"Author\":\"auhtor1\",\"Genre\":\"genre1\",\"Some\":{\"MyProperty\":42}}"; //JsonSerializer.Serialize(book);
//Console.WriteLine(json);

//var book = JsonSerializer.Deserialize<Book>(json);
//Console.WriteLine();

#endregion

#region StreamWriter

//using var sw = new StreamWriter(@"C:\Users\namiqrasullu\Desktop\books.txt");
//foreach (var book in books)
//{
//    sw.WriteLine(book);
//}


using var sr = new StreamReader(@"C:\Users\namiqrasullu\Desktop\books.txt");

sr.

#endregion