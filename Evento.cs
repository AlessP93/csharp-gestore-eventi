//creare una classe Evento che abbia i seguenti attributi: 
public class Evento
{
    public string Titolo { get; set; }
    public DateTime Data { get; }
    public double MaxCapienza { get; }
    public int PostiPrenotati { get; }

    public Evento(string titolo, DateTime data, double maxCapienza, int postiPrenotati)
    {
        Titolo = titolo;
        Data = data;
        MaxCapienza = maxCapienza;
        PostiPrenotati = postiPrenotati;
    }

    //controlli
    public void DataPassata()
    {
        DateTime DataOggi = DateTime.Now;
        if (Data < DataOggi)
        {
            Console.WriteLine("La data è già passata");
        }
    }
    public void 
}
