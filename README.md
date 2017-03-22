# UnicamCompleanno
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