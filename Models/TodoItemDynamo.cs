using Amazon.DynamoDBv2.DataModel;
 
namespace TodoApi.Models
{
    [DynamoDBTable("Todo")]
    public class TodoDynamo
    {
        [DynamoDBHashKey]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
