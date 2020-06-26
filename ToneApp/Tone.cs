using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToneApp
{
    public class Tone
    {
        public int ToneIndex { get; }
        public Octave Octave { get; }
        public double BaseFrequency { get; }
        private static readonly string[] ToneNames = new[] { "C", "C#", "D", "D#" };

        public Tone(int toneIndex, Octave octave)
        {
            Octave = octave;
            ToneIndex = toneIndex;
            BaseFrequency = 16.35 + Math.Pow(2, 1.0 / 12) * ToneIndex;
        }

        public Tone(string tone, Octave octave)
            : this(Array.IndexOf(ToneNames, tone), octave)
        {
        }

        public static IEnumerable<Tone> AllTones(Octave octave)
        {
            return Enumerable.Range(0, 11).Select(i => new Tone(i, octave));
        }
    }
}
