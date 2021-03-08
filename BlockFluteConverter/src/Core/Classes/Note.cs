using BlockFluteConverter.Core.Enums;

namespace BlockFluteConverter.Core.Classes
{
    public class Note
    {
        public Pitch Pitch { get; set; }
        public int Octave { get; set; }
        public Fraction Duration { get; set; }

        public Note(Pitch pitch, int octave, Fraction duration)
        {
            Pitch = pitch;
            Octave = octave;
            Duration = duration;
        }
    }
}
