
public abstract class Ticket
{
    protected Ticket(int id, string summary, string status, string priority, string submitter, string assigned, string watching)
    {
        Id = id;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        Assigned = assigned;
        Watching = watching;
    }

    protected Ticket()
    {
    }

    public int Id { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string Submitter { get; set; }
    public string Assigned { get; set; }
    public string Watching { get; set; }
    //public string Severity { get; set; }

    public virtual void FromCsvLine(string line)
    {
        var fields = line.Split(',');
        Id = int.Parse(fields[0]);
        Summary = fields[1];
        Status = fields[2];
        Priority = fields[3];
        Submitter = fields[4];
        Assigned = fields[5];
        Watching = fields[6];
        //Severity = fields[7];
    }

    public virtual string ToCsvLine()
    {
        return $"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching}";
    }

    public virtual void Display()
    {
        Console.WriteLine($"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching}");
    }
    public virtual void DisplaySearch()
    {
        Console.WriteLine($"Summary: {Summary}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Priority: {Priority}");
    }
}