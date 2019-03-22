using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Numerics;

namespace huffman_encoder.TextCrawling
{
    class FrequencyMap
    {
        private readonly Dictionary<char, int> _frequencies;

        public FrequencyMap(Dictionary<char, int> frequencies)
        {
            _frequencies = frequencies;
        }

        public int GetFrequency(char character)
        {
            
            if (!_frequencies.ContainsKey(character))
            {
                throw new ArgumentException($"{character} is not in the map!");
            }

            return _frequencies[character];
        }

        public Dictionary<char, int> ToDict()
        {
            return _frequencies;
        }
    }
}