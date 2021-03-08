using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockFluteConverter.Core.Classes
{
    public class Bar
    {
        public List<Note> Notes { get; set; }
        public Fraction TimeSignature { get; set; }

        public Bar(List<Note> notes, Fraction timeSignature)
        {
            Notes = notes;
            TimeSignature = timeSignature;
        }

        public bool TimeCheck()
        {
            return Notes.Aggregate(new Fraction(0, 1),
                (current, note) => current + note.Duration)
                .Equals(TimeSignature.Reduce());
        }
    }
}
