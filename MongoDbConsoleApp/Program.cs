// See https://aka.ms/new-console-template for more information
using MongoDB.Driver;
using MongoDB.Bson;

const string mongodbUrl = "mongodb+srv://tobynwude:spiderman10@cluster0.wjlun.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

var client = new MongoClient(mongodbUrl);

var dbList = client.ListDatabases().ToList();

Console.WriteLine("The list of database on this server is: ");
foreach (var db in dbList)
{
    Console.WriteLine(db);
}