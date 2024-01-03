using System;
using System.Collections.Generic;

public class DnaStrand
{
    public static string MakeComplement(string dna)
    {
        List<char> newDnaList = new List<char>();

        foreach (char item in dna)
        {
            switch (item)
            {
                case 'A':
                    newDnaList.Add('T');
                    break;
                case 'T':
                    newDnaList.Add('A');
                    break;
                case 'C':
                    newDnaList.Add('G');
                    break;
                case 'G':
                    newDnaList.Add('C');
                    break;
                default:
                    // Handle other characters if needed
                    break;
            }
        }

        char[] newDnaArray = newDnaList.ToArray();
        string complementaryDna = new string(newDnaArray);

        return complementaryDna;
    }
}