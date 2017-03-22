using System;

namespace UnicamCompleanno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma ti dice la tua eta' e il numero di giorni che restano al tuo compleanno");
            Console.WriteLine("Digita la tua data di nascita: ");
            string testoDigitatoDallUtente = Console.ReadLine();

            try {
                DateTime dataDiNascita = DateTime.Parse(testoDigitatoDallUtente);

                //Calcoliamo gli anni dell'utente.
                //Quando non sappiamo come si fa o quando, come in questo caso,
                //.NET non ha un modo facile per ottenere la differenza in anni
                //andiamo a vedere su StackOverlow se qualcuno ha già avuto la stessa necessità
                //Il metodo Years è stato preso da lì (è definito più in basso, in questo file)
                string anniDiDifferenza = Years(dataDiNascita, DateTime.Today);
                Console.WriteLine($"Oggi hai {anniDiDifferenza} anni");

                //Ora calcoliamo i giorni che ci separano dal prossimo compleanno
                DateTime dataProssimoCompleanno = new DateTime(DateTime.Today.Year, dataDiNascita.Month, dataDiNascita.Day);
                TimeSpan differenzaTemporale = dataProssimoCompleanno - DateTime.Today;
                double differenzaInGiorni = differenzaTemporale.TotalDays;
                Console.WriteLine($"Restano {differenzaInGiorni} giorni al tuo prossimo compleanno!");

            } catch (Exception exc) {
                Console.WriteLine($"Non hai digitato una data valida, il programma ora terminera'. L'errore e' stato: {exc.Message}.");
            }
            Console.ReadKey();
        }

        //Grazie, StackOverflow!
        //http://stackoverflow.com/questions/4127363/date-difference-in-years-using-c-sharp#answer-4127477
        static int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}
