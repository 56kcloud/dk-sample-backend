namespace TodoApi.Models;

public class TodoItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItem(string name) {
        Id = Guid.NewGuid().ToString();
        Name = name;
    }
}
