using System;
using System.Collections.Generic;
using System.Text;

public static class TrascrizioneRNA
{
    public static string ToRna(string dna)
    {
        string rna = "";
        if( String.IsNullOrEmpty( dna ) )

            return "";
        for (int i = 0; i < dna.Length; i++)
        {
            switch(dna[i])
            {
                case 'G': rna = rna + 'C'; break;

                 case 'C': rna = rna + 'G'; break;

                 case 'T': rna = rna + 'A'; break;

                 case 'A': rna = rna + 'U'; break;

            }
        }
            return rna;
    }
}