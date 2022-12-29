
namespace PatternProxy;

public class Order
{

    public Guid GuidId { get; set; } = Guid.NewGuid();

    public string? Name { get; set; }

    public int StatusId { get; set; }
}
