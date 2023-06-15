using System;
public class Gabarito 
{
    public int Verifica(string[] respostas)
    {
        int contador = 0;
        string[] gaba = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };//GABARITO
        for(int i = 0; i < gaba.Length; i++)
        {
            if (gaba[i] == respostas[i].ToUpper()) 
            {
                contador++;
            }
        }
        return contador;
    }
}

