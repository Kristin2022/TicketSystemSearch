﻿/* Add search to the Ticket System Application

User should be able to perform a search based on status, priority or submitter
The search results should display the results and the number of matches
Optional - One single search should return results from all ticket types (Concatenation Operator)*/

Console.ForegroundColor = ConsoleColor.Green;

TicketManager ticketManager = new TicketManager();

ticketManager.Run();
