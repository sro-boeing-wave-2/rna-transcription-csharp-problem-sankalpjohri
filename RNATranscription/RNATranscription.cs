using System;
using System.Collections.Generic;
using System.Linq;

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
            if (!String.IsNullOrWhiteSpace(nucleotide))
            {   
                return new String(nucleotide.Where(ch => rnaMapping.ContainsKey(ch)).Select(ch => rnaMapping[ch]).ToArray());
            }
            return nucleotide;
        }
    }
}
