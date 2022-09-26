//creare una classe Evento che abbia i seguenti attributi: 
public class Evento
{
    public string Titolo { get; set; }
    public DateTime Data { get; set; }
    public int MaxCapienza { get; } 
    public int PostiPrenotati { get; }

    public Evento(string titolo, DateTime data, int maxCapienza, int postiPrenotati)
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
    public void TitoloVuoto()
    {
        if (Titolo == "")
        {
            Console.WriteLine("Devi inserire un titolo");
        }
    }
    public void NumeroCapienza()
    {

        if (MaxCapienza >= 0)
        {
            
        }
    }
}
