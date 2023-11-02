
using System.Collections.Generic;
using System.IO;

public class TicketFile<T> where T : Ticket, new()
{
    public string FilePath { get; set; }
    public List<T> Tickets { get; set; }

    public TicketFile(string filePath)
    {
        FilePath = filePath;
        Tickets = new List<T>();
        ReadTickets();
    }

    public void ReadTickets()
    {
        if (!File.Exists(FilePath)) return;

        using (StreamReader sr = new StreamReader(FilePath))
        {
            // sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                T ticket = new T();
                ticket.FromCsvLine(line);
                Tickets.Add(ticket);
            }
        }
    }
    public void WriteTicket(Ticket t)
    {
        using (StreamWriter sw = new StreamWriter(FilePath, true))
        {
            sw.WriteLine(t.ToCsvLine());
        }

    }
    public List<T> SearchTickets(Func<T, bool> predicate)
    {
        return Tickets.Where(predicate).ToList();
    }
}
