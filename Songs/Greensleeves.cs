using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasMusic
{
    static partial class program
    {
        public static Song GetGreensleeves()
        {
            Song Greensleeves = new Song()
            {
                Key = Key.E_Minor,
                OneBeatDuration = Duration.Eighth,
            };

            var melody = new Note[]
            {
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_5, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.B_3, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_5, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.REST, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.D_5, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.D_5, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_5, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.B_3, Duration = Duration.DottedQuarter},

                new Note{Pitch = Pitch.D_5, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.D_5, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_5, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.B_4, Duration = Duration.Eighth},


                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_Sharp_4, Duration = Duration.DottedEight},
                new Note{Pitch = Pitch.C_Sharp_4, Duration = Duration.Sixteenth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.DottedQuarter}
            };

    
            var notes = new List<Note>();

            notes.AddRange(melody);

            Greensleeves.Notes = notes.ToArray();

            return Greensleeves;
        }

    }
}
