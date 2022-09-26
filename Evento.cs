//creare una classe Evento che abbia i seguenti attributi: 
public class Evento
{
    public int Titolo { get; set; }
    public DateOnly Data { get; set; }
    public double MaxCapienza { get; }
    public int PostiPrenotati { get; }

    public Evento(int titolo, DateOnly data, double maxCapienza, int postiPrenotati)
    {
        Titolo = titolo;
        Data = data;
        MaxCapienza = maxCapienza;
        PostiPrenotati = postiPrenotati;
    }

    //controlli
    public void DataNonPassata()
    {
        DateTime DataOggi = DateTime.Now;
        if (Data < DataOggi)
        {
            Console.WriteLine("Data non disponibile");
        }
    }
}
