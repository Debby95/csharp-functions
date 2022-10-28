// See https://aka.ms/new-console-template for more information

//void StampaArray(int[] array): che preso un array di numeri interi,
//stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina

int[] array = { 2, 6, 7, 5, 3, 9 };
void StampaArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    int quadratoNum = numero * numero;
    return quadratoNum;
}

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayAlQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayAlQuadrato[i] = array[i];
    }
    return arrayAlQuadrato;
}

//int SommaElementiArray(int[] array): che preso un array di numeri interi,
//restituisca la somma totale di tutti gli elementi dell’array.

int SommaElementiArray(int[] array)
{
    int somma = 0;
    for(int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//stampo l'array di numeri fornito a video
Console.WriteLine("Array di numeri fornito: ");
StampaArray(array);

