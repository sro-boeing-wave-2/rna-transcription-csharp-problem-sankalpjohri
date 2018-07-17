using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        private static Dictionary<char, char> rnaMapping = new Dictionary<char, char>(){
            {'A', 'U'},
            {'T', 'A'},
            {'G', 'C'},
            {'C', 'G'}
        };

        public static string ToRna(string nucleotide)
        {
            String rnaString = "";
            if (!String.IsNullOrWhiteSpace(nucleotide))
            {
                foreach (char c in nucleotide)
                {
                    rnaString = rnaMapping.ContainsKey(c) ? String.Concat(rnaString, rnaMapping[c]) : rnaString;
                }
            }
            return rnaString;
        }
    }
}
