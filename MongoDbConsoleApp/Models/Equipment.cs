using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbConsoleApp.Models;

internal sealed class Equipment
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; } 
    [BsonElement("Name")] 
    public string? Name { get; set; } 
    [BsonElement("Total")]
    public int? Total { get; set; }


}