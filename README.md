# UnicamCompleanno (italiano)
Applicazione console C# che calcola l'età dell'utente e gli indica i giorni che lo separano dal suo prossimo compleanno.

## Comportamento desiderato (specifica del programma)
1. Il programma deve chiedere all'utente di digitare la propria data di nascita;
2. La data deve essere inserita nel formato italiano `gg/mm/aaaa` oppure nel formato internazionale `aaaa/mm/gg`;
3. L'età della persona deve essere calcolata correttamente, anche nel giorno del suo compleanno;
4. Il numero di giorni che restano al prossimo compleanno deve essere calcolato correttamente;
5. *Nice-to-have*: Se è il giorno del compleanno dell'utente, il programma non deve scrivere il numero di giorni che restano ma deve scrivere "Tanti auguri!".

## Situazione attuale
Il programma ha dei problemi e non è ancora stato ancora rilasciato al cliente. Al momento, non si riesce neanche a compilare il sorgente (premendo il tasto F5, Visual Studio Code dice che sono stati rilevati errori).
Per prima cosa va risolto quello, e poi anche un altro problema: per alcune date di nascita, il programma scrive "Restano -80 giorni al tuo prossimo compleanno!".
Come è possibile che scriva un numero negativo? Va identificato il problema e risolto. Hai giusto notato che si verifica per i nati a gennaio, febbraio e alcuni di marzo.
Fai il possibile per consegnare il programma funzionante al cliente.


# UnicamCompleanno (english)
A C# console application to calculate the age of the user and the number of days to his/her next birthday

## Desired behavior (program specifics)
1. The program must ask the user for his/her date of birth;
2. The date must be input according to the italian format `dd/mm/yyyy` or using the international format `yyyy/mm/dd`;
3. The actual age of the person must be correctly calculated, even if today it's his/her birthday;
4. The number of days to his/her next birthday must be correctly calculated;
5. *Nice-to-have*: If today is the birthday of the user, then it should print "Happy birthday" insted of the remaining days.

## Current situation
This program has problems and it has not yet been released to the customer. At the moment, the program won't even compile (try pressing the F5 key and Visual Studio Code will show compilation errors).
That's the first problem to solve and then another: for some dates, the program will print "-80 days remaining to your next birthday".
How could it be it's showing a negative number? The problem has to be found and solved. You've noticed this happens when the date is in january, february, march and april (and some in may).
Do your best so the program can be released to the client.
