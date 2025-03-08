// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDbConsoleApp.Models;


const string mongodbUrl = "mongodb+srv://tobynwude:spiderman10@cluster0.wjlun.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

var client = new MongoClient(mongodbUrl);
var database = client.GetDatabase("inventorydb");

var equipmentCollection = database.GetCollection<Equipment>("equipment");

var newEquipment1 = new Equipment
{
    Name = "CAP",
    Total = 57
};

var newEquipment2 = new Equipment
{
    Name = "CAP",
    Total = 24
};

// equipmentCollection.InsertOne(newEquipment1);
// equipmentCollection.InsertMany(new List<Equipment>() { newEquipment1, newEquipment2});

// await equipmentCollection.InsertOneAsync(newEquipment1);
await equipmentCollection.InsertManyAsync(new List<Equipment> { newEquipment1, newEquipment2 });

// var dbList = client.ListDatabases().ToList();
//
// Console.WriteLine("The list of database on this server is: ");
// foreach (var db in dbList)
// {
//     Console.WriteLine(db);
// }