

public class DefectBug : Ticket
{

    public DefectBug() : base() { }
    public DefectBug(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string severity) : base(id, summary, status, priority, submitter, assigned, watching)
    {
        
    } 

    public string Severity { get; set; }  
    public override void FromCsvLine(string line)
    {
        var fields = line.Split(',');
        Id = int.Parse(fields[0]);
        Summary = fields[1];
        Status = fields[2];
        Priority = fields[3];
        Submitter = fields[4];
        Assigned = fields[5];
        Watching = fields[6];
        Severity = fields[7];  
    }


    public override string ToCsvLine()
    {
        return $"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching},{Severity}";
    }


    public override void Display()
    {
        Console.WriteLine($"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching},{Severity}");  
    }
}


