using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToneApp
{
    public class OctaveToneSet
    {
        public Tone[] Tones { get; }

        public OctaveToneSet(Octave octave)
        {
            Tones = Tone.AllTones(octave).ToArray();
            //var tones = new List<Tone>();
            //for (var i = 0; i <= 11; i++)
            //{
            //    tones.Add(new Tone(i, octave));
            //}

            //Tones = tones.ToArray();
        }
    }
}
