# Descrizione

#### Il linguaggio utilizzato in questo codice è il C#

> Per risolvere questo esercizio bisogna superare 7 test.

#### **Scrivere un programma che calcoli l'altezza massima di una piramide (in piani) dato un certo numero di cubi di pietra.**

Ipotizzando che:

- i piani della piramide siano quadrati
- la piramide da costruire sia compatta, cioè non ci siano cavità al suo interno. 
- ogni piano è quadrato, con una lunghezza laterale inferiore di due rispetto a quella sottostante.
- il primo piano è sempre di un mattone

Esempi:

- il primo piano ha un mattone, il secondo 9 mattoni, il terzo 25 e così via
- con 1 mattone la piramide è alta 1 piano
- con 84 mattoni la piramide è alta 4 piani

Va bene se hai blocchi rimanenti, purché tu costruisca una piramide completa.

Sviluppare:

- il metodo int Piani( int mattoni ) che torna il numero di piani
- il metodo int Rimanenti( int mattoni ) che torna il numero di mattoni rimasti dopo la costruzione

# Descrizione della soluzione
``` c#
 public static int Piani(int mattoni)
        {
            int piani = 0;
            while(mattoni >= (2 * piani +1) *  (2 * piani +1))
            {
                piani++;
                mattoni = mattoni - (2 * piani - 1) * (2 * piani - 1);
            }
            return piani;
        }
``` 
> Questo metodo calcola il numero massimo di piani che possono essere costruiti utilizzando un certo numero di mattoni. Il while incrementa la variabile "piani" finché è possibile costruire un altro piano con i mattoni rimanenti.All'interno del ciclo while, la condizione (mattoni >= (2 * piani + 1) * (2 * piani + 1)) verifica se è possibile costruire un altro piano con il numero attuale di mattoni. La formula (2 * piani + 1) * (2 * piani + 1) calcola il numero di mattoni necessari per costruire un piano.
> Se la condizione è vera viene incrementata la variabile "piani" e il numero di mattoni necessari per costruire il piano viene sottratto da "mattoni". Questo passo viene ripetuto finché non è più possibile costruire un altro piano.
> Infine viene restituito il valore di "piani", che rappresenta il numero massimo di piani che possono essere costruiti.


``` c#
public static int Rimanenti( int mattoni )
        {
            int piani = Piani(mattoni);
            int usati = 0;
            for (int i = 1; i <= piani; i++)
            {
                usati += (2 * i - 1) * (2 * i - 1);
            }
            int Rimanenti = mattoni - usati;
            return Rimanenti;
``` 
> La funzione Rimanenti, prende un intero mattoni come input e restituisce il numero di mattoni rimanenti dopo che tutti i piani sono stati costruiti utilizzando il numero massimo di mattoni disponibili. Questa funzione richiama la funzione Piani per calcolare il numero di piani costruibili e utilizza un ciclo for per calcolare il numero di mattoni utilizzati per costruire tutti i piani. Sottraendo quindi il numero di mattoni utilizzati dal numero totale di mattoni, la funzione restituisce il numero di mattoni rimanenti.



