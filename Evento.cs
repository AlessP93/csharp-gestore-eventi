//Creare una classe Evento che abbia i seguenti attributi: 
//Con relativi controlli
public class Evento
{
    public string _titolo; //proprietà
    public string Titolo
    {
        get => _titolo;
        set
        {
            if (Titolo == "")
            {
                throw new Exception("Il titolo non può essere vuoto");

            }
            _titolo = Titolo;
        }
    }
    public DateTime _data;
    public DateTime Data
    {
        get => _data;
        set
        {
            if (_data < DateTime.Now)
            {
                throw new Exception("La data è già passata");

            }
            _data = Data;
        }
    }
    public int _maxCapienza;
    public int MaxCapienza
    {
        get => _maxCapienza;
        private set
        {
            if (_maxCapienza < 1)
            {
                throw new Exception("La capienza non può essere 0");
            }
            _maxCapienza = MaxCapienza;
        }
    }
    public int PostiPrenotati { get; private set; }

    public Evento(string _titolo, DateTime _data, int _maxCapienza)
    {
        Titolo = _titolo;
        Data = _data;
        MaxCapienza = _maxCapienza;
        PostiPrenotati = 0;
    }

    //Metodi
    public void PrenotaPosti(int posti)
    {
        if (posti > _maxCapienza - PostiPrenotati)
        {
            throw new Exception("Non ci sono posti disponibili");
        }
        if (_data < DateTime.Now)
        {
            throw new Exception("La data è già passata");

        }
        MaxCapienza = MaxCapienza - posti;
        PostiPrenotati = PostiPrenotati + posti;

    }
    public void DisdiciPosti(int posti)
    {
        if (posti > PostiPrenotati)
        {
            throw new Exception("Non ci sono abbastanza posti per disdire");
        }
        if (_data < DateTime.Now)
        {
            throw new Exception("La data è già passata");

        }
        MaxCapienza = MaxCapienza + posti;
        PostiPrenotati = PostiPrenotati - posti;

    }
    public override string ToString()
    {
        string riga = "";
        riga += Data.ToString("dd/MM/yyyy") + Titolo;
        return riga;
    }
}
//public override string ToString()
//{
//    return $"{Titolo} - {Data.ToString("dd/MM/yyyy")}";
//}

