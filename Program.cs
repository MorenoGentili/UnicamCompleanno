using System;

namespace UnicamCompleanno
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program prints your age and the number of remaining days to your next birthday
            Console.WriteLine("Questo programma ti dice la tua eta' e il numero di giorni che restano al tuo compleanno");
            //Type your date of birth
            Console.WriteLine("Digita la tua data di nascita: ");
            string testoDigitatoDallUtente = Console.ReadLine();

            try {
                DateTime dataDiNascita = DateTime.Parse(testoDigitatoDallUtente);

                //Calcoliamo gli anni dell'utente.
                //Calculate the age of the user
                string anniDiDifferenza = Years(dataDiNascita, DateTime.Today);
                Console.WriteLine($"Oggi hai {anniDiDifferenza} anni");

                //Ora calcoliamo i giorni che ci separano dal prossimo compleanno
                //Now, we calculate the remaining days to his/her next birthday
                DateTime dataProssimoCompleanno = new DateTime(DateTime.Today.Year, dataDiNascita.Month, dataDiNascita.Day);
                TimeSpan differenzaTemporale = dataProssimoCompleanno - DateTime.Today;
                double differenzaInGiorni = differenzaTemporale.TotalDays;
                //days remaining to your next birthday
                Console.WriteLine($"Restano {differenzaInGiorni} giorni al tuo prossimo compleanno!");

            } catch (Exception exc) {
                //You didn't input a valid date, the program will now end. The error was:
                Console.WriteLine($"Non hai digitato una data valida, il programma ora terminera'. L'errore e' stato: {exc.Message}.");
            }
            Console.ReadKey();
        }

        //Grazie, StackOverflow!
        //Thanks, StackOverflow!
        //http://stackoverflow.com/questions/4127363/date-difference-in-years-using-c-sharp#answer-4127477
        static int Years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day))) ? 1 : 0);
        }
    }
}
