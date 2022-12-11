using System;
//Порушено принцип відкритості/закритості

interface ILogging
{
    void Send(Email email);
}

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }}

class EmailSender
{
    public ILogging Logging { get; set; }

    public EmailSender(ILogging logging)
    {
        Logging = logging;
    }

    public void Send(Email email)
    {
        // ... sending...
        Logging.Send(email);
       }
}

class EmailLogging : ILogging
{
    public void Send(Email email)
    {
        Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
    }
}

class Program{
    
    static void Main(string[] args){
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };
        var EmailLogging = new EmailLogging();
        EmailSender es = new EmailSender(EmailLogging);
        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);
        Console.ReadKey();
    }
}