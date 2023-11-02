
public class Task : Ticket
{
    public Task() : base() { }
    public Task(int id, string summary, string status, string priority, string submitter, string assigned, string watching, string projectName, DateTime dueDate)
    : base(id, summary, status, priority, submitter, assigned, watching)
    {
        ProjectName = projectName;
        DueDate = dueDate;
    }
    public string ProjectName { get; set; }
    public DateTime DueDate { get; set; }
    public virtual void FromCsvLine(string line, DateTime dateOnly)
    {
        var fields = line.Split(',');
        Id = int.Parse(fields[0]);
        Summary = fields[1];
        Status = fields[2];
        Priority = fields[3];
        Submitter = fields[4];
        Assigned = fields[5];
        Watching = fields[6];
        ProjectName = fields[7];
        DueDate = DateTime.Parse(fields[8]);
    }
        public override string ToCsvLine()
    {
        return $"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching},{ProjectName},{DueDate}";
    }


    public override void Display()
    {
        Console.WriteLine($"{Id},{Summary},{Status},{Priority},{Submitter},{Assigned},{Watching},{ProjectName},{DueDate}");  
    }
}