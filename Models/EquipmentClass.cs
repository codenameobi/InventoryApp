using MongoDB.Bson;

namespace DefaultNamespace;

internal sealed class EquipmentClass
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    [BsonElement("Name")] 
    public string? Name { get; set; }
    [BsonElement("Total")]
    public int? Total { get; set; }


}