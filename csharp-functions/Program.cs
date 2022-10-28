// See https://aka.ms/new-console-template for more information

//void StampaArray(int[] array): che preso un array di numeri interi,
//stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
void StampaArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}



    