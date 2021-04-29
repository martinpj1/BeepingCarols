using System.Collections.Generic;

namespace ChristmasMusic
{
    static partial class program
    {
        public static Song GetSilentNight()
        {
            Song SilentNight = new Song()
            {
                Key = Key.B_Flat_Major,
                OneBeatDuration = Duration.Quarter,
            };

            var melody = new Note[]
            {
                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.C_5, Duration = Duration.Half},
                new Note{Pitch = Pitch.C_5, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.B_4, Duration = Duration.Half},
                new Note{Pitch = Pitch.B_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Half},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Half},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.C_5, Duration = Duration.Half},
                new Note{Pitch = Pitch.C_5, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_5, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.C_5, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedHalf},
                new Note{Pitch = Pitch.D_5, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.B_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.C_4, Duration = Duration.Quarter},

                 new Note{Pitch = Pitch.B_3, Duration = Duration.DottedWhole}
            };


            var notes = new List<Note>();

            notes.AddRange(melody);

            SilentNight.Notes = notes.ToArray();

            return SilentNight;
        }

    }
}
