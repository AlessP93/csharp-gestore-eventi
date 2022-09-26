//1 Nel vostro programma principale Program.cs, chiedete all’utente di inserire un 
//nuovo evento con tutti i parametri richiesti dal costruttore.


Console.WriteLine("Benvenuto");
Console.WriteLine();
Console.WriteLine("Inserisci il nome dell'evento ");
var nomeEvento = Console.ReadLine();

Console.WriteLine("Inserisci la data dell'evento ");
var dataEvento = Console.ReadLine();

Console.WriteLine("Inserisci il numero dei posti totali ");
var postiEvento = Console.ReadLine();

Console.WriteLine("Quanti posti vuoi prenotare? ");
var postiPrenotati = Console.ReadLine();

Console.WriteLine("Numero dei posti prenotati {0} " + postiPrenotati);
Console.WriteLine("Numero dei posti disponibili {0} " + postiEvento);

Console.WriteLine("Vuoi disdire dei posti (si/no)? ");
var scelta = Console.ReadLine();
if (scelta == "si")
{
    postiPrenotati = postiPrenotati - 
}