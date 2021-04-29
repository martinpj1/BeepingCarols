using System.Collections.Generic;

namespace ChristmasMusic
{
    static partial class program
    {
        public static Song GetOhHolyNight()
        {
            Song OhHolyNight = new Song()
            {
                Key = Key.C_Major,
                OneBeatDuration = Duration.Eighth,
            };

            var melody = new Note[]
            {
                new Note{Pitch = Pitch.E_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.DottedQuarterSustainedToQuarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.A_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.A_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.C_5, Duration = Duration.DottedHalf},

                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.C_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.G_4, Duration = Duration.DottedQuarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Eighth},

                new Note{Pitch = Pitch.C_4, Duration = Duration.DottedWhole}

        };


            var notes = new List<Note>();

            notes.AddRange(melody);

            OhHolyNight.Notes = notes.ToArray();

            return OhHolyNight;
        }

    }
}
