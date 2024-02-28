using Lesson12Serialize.Models;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

/*
    1 aASJDHjk  sjkadhasjkdhajksdhaskjdh imgurl 
    2 aASJDHjk  sjkadhasjkdhajksdhaskjdh imgurl 
    3 aASJDHjk  sjkadhasjkdhajksdhaskjdh imgurl 
    4 aASJDHjk  sjkadhasjkdhajksdhaskjdh imgurl 
    5 aASJDHjk  sjkadhasjkdhajksdhaskjdh imgurl 
*/

void XmlWrite(string fileName, List<Car> cars)
{
    using XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.UTF8);
    writer.Formatting = Formatting.Indented;

    writer.WriteStartDocument();
    writer.WriteStartElement("cars");

    foreach (var car in cars)
    {
        writer.WriteStartElement("car");

        writer.WriteAttributeString("id", car.Id.ToString());
        writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
        writer.WriteAttributeString(nameof(car.Model), car.Model);
        writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

        //writer.WriteElementString(nameof(car.Vendor), car.Vendor);
        //writer.WriteElementString(nameof(car.Model), car.Model);
        //writer.WriteElementString(nameof(car.Year), car.Year.ToString());

        writer.WriteEndElement();
    }
    writer.WriteEndElement();
    writer.WriteEndDocument();
}

List<Car>? XmlRead(string fileName)
{
    if (File.Exists(fileName))
    {
        List<Car> cars = new();
        XmlDocument doc = new();

        doc.Load(fileName);
        XmlElement? root = doc.DocumentElement;

        if (root is not null)
        {
            if (root.HasChildNodes)
            {
                foreach (XmlNode node in root.ChildNodes)
                {
                    var car = new Car
                    {
                        Id = int.Parse(node.Attributes![0].Value),
                        Vendor = node.Attributes![1].Value,
                        Model = node.Attributes![2].Value,
                        Year = int.Parse(node.Attributes![3].Value)
                    };
                    cars.Add(car);
                }
            }
        }
        return cars;
    }

    throw new FileNotFoundException(fileName);
}


//List<Car> cars = new()
//{
//    new(){ Id = 1, Vendor = "Tesla", Model = "ModelX", Year = 2024},
//    new(){ Id = 2, Vendor = "Nissan", Model = "Skyline", Year = 1999},
//    new(){ Id = 3, Vendor = "Nissan", Model = "Silvia", Year = 197},
//};

//XmlWrite("carsXmlFile.xml", cars);

//var cars = XmlRead("carsXmlFile.xml");

//foreach (var car in cars!)
//{
//    Console.WriteLine(car);
//}

//var gallery = new ShowRoom
//{
//    Name = "StepShowRoom",
//    Address = "K.Rahimov 70",
//    PhoneNumber = "+994891234567",
//    Cars = new()
//        {
//            new(){ Id = 1, Vendor = "Tesla", Model = "ModelX", Year = 2024},
//            new(){ Id = 2, Vendor = "Nissan", Model = "Skyline", Year = 1999},
//            new(){ Id = 3, Vendor = "Nissan", Model = "Silvia", Year = 197},
//        }
//};


//var xml = new XmlSerializer(typeof(ShowRoom));
//using FileStream fs = new("gallery.xml", FileMode.Create, FileAccess.Write);
//xml.Serialize(fs, gallery);


//ShowRoom? showRoom = null;

//var xml = new XmlSerializer(typeof(ShowRoom));
//using FileStream fs = new("gallery.xml", FileMode.Open, FileAccess.Read);
//showRoom = xml.Deserialize(fs) as ShowRoom;

//Console.WriteLine(showRoom!.Name);
//Console.WriteLine(showRoom!.Address);
//Console.WriteLine(showRoom!.PhoneNumber);

//showRoom!.Cars!.ForEach(c => Console.WriteLine(c));


// JSON

// {} => object
// [] => array

//List<Car> cars = new()
//{
//    new(){ Id = 1, Vendor = "Tesla", Model = "ModelX", Year = 2024},
//    new(){ Id = 2, Vendor = "Nissan", Model = "Skyline", Year = 1999},
//    new(){ Id = 3, Vendor = "Nissan", Model = "Silvia", Year = 197},
//};

//var json = JsonSerializer.Serialize(cars, options: new JsonSerializerOptions { WriteIndented = true});
//File.WriteAllText("cars.json", json);

//var json = File.ReadAllText("cars.json");

//var cars = JsonSerializer.Deserialize<List<Car>>(json);

//cars?.ForEach(c => Console.WriteLine(c));

var gallery = new ShowRoom
{
    Name = "StepShowRoom",
    Address = "K.Rahimov 70",
    PhoneNumber = "+994891234567",
    Cars = new()
        {
            new(){ Id = 1, Vendor = "Tesla", Model = "ModelX", Year = 2024},
            new(){ Id = 2, Vendor = "Nissan", Model = "Skyline", Year = 1999},
            new(){ Id = 3, Vendor = "Nissan", Model = "Silvia", Year = 197},
        }
};

var json =  JsonSerializer.Serialize(gallery, options: new JsonSerializerOptions {WriteIndented = true });

Console.WriteLine(json);