namespace Simulator;

public class Animals
{
    private string description = "Unknown";

    public required string Description
    {
        get => description;
        init
        {
            description = Validator.Shortener(value, 3, 15, '#');
            description = char.ToUpper(description[0]) + description.Substring(1).ToLower();
        }
    }
    public uint Size { get; set; } = 3;
    public virtual string Info => $"{Description} <{Size}>";
    public override string ToString()
    {
        return $"{GetType().Name.ToUpper()}: {Info}";
    }
}

public class Birds : Animals
{
    public bool CanFly { get; set; } = true;
    public override string Info
    {
        get
        {
            string flyAbility = CanFly ? "fly+" : "fly-";
            return $"{Description} ({flyAbility}) <{Size}>";
        }
    }
}