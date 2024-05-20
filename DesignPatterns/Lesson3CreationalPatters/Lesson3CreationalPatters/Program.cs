using Lesson3CreationalPatters.AbstractFactory.Abstracts;
using Lesson3CreationalPatters.AbstractFactory.Contrates;
using Lesson3CreationalPatters.BuilderPattern.Builders;
using Lesson3CreationalPatters.FactoryMethod.Abstacts;
using Lesson3CreationalPatters.FactoryMethod.Conrates;
using Lesson3CreationalPatters.PrototypePattern;
using Lesson3CreationalPatters.SingletonPattern;

//President president = President.GetPresident();
//president.Name = "Hakuna";
//president.Surname = "Matata";
//president.Age = 42;

//var pr = President.GetPresident();

//pr.Name = "john";
//Console.WriteLine(president.Name);

//Product product = new()
//{
//    Id = 1,
//    Name = "Kola",
//    Description = "Chox shekerli, qazli ichki"
//};

//Product? pr = product.Clone() as Product;
//pr!.Description = "Chox babat ichki";

//Console.WriteLine(product.Description);


//IHouseBuilder builder = new StoneHouseBuilder();

//builder.BuildWindows(5)
//        .BuildRooms(5)
//        .BuildGarrage()
//        .BuildDoors(7)
//        .BuildRoof();

//var house = builder.GetHouse();
//builder.Reset();
//Console.WriteLine(house);

//builder.BuildWindows(10);
//builder.BuildRooms(40);
//builder.BuildPool();
//var h = builder.GetHouse();
//Console.WriteLine(h);


//Director director = new (new StoneHouseBuilder());
//var house = director.Make(HouseType.UchOtaqli);

//Console.WriteLine(house);



//BadLogistic bl = new BadLogistic() { State = "road"};

//ITransport? transport = null;
//if(bl.State == "road")
//{
//    transport = new Truck();
//}

//Logistic logistic = new SeaLogistic();

//var transport = logistic.CreateTranport();
//transport.Deliver();

//var kargo = new KamilKargo();
//kargo.Logistics.Add(new RoadLogistic());
//kargo.Logistics.Add(new SeaLogistic());
//kargo.Logistics.Add(new SkyLogistic());

//var transport = kargo.Logistics[2].CreateTranport();
//transport.Deliver();

//foreach (var l in kargo.Logistics)
//{
//    l.PlanDelivery();
//}




//IFurnitureFacotry facotry = new ArtFurnitureFactory();

//var chair = facotry.CreateChair();

//chair.WhoAreYou();

//var client = new Client(new ArtFurnitureFactory());

//var sofa = client.facotry.CreateSofa();

//var chair = client.facotry.CreateChair();

//sofa.WhoAreYou();
//chair.WhoAreYou();