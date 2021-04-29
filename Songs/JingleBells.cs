using System.Collections.Generic;

namespace ChristmasMusic
{
    static partial class program
    {
        public static Song GetJingleBells()
        {
            Song JingleBells = new Song()
            {
                Key = Key.C_Major,
                OneBeatDuration = Duration.Quarter,
            };

            var jingleBellsPhrase = new Note[]
            {
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Half},

                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Half},

                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.C_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.E_4, Duration = Duration.Whole}
            };

            var ohWhatFunPhrase = new Note[]
            {
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                 new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                     new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Eighth}
            };

            var oneHorseA = new Note[]
            {
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.E_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.D_4, Duration = Duration.Half},
                 new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.REST, Duration = Duration.Quarter}               
            };

            var oneHorseB = new Note[]
            {
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.G_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.F_4, Duration = Duration.Quarter},
                new Note{Pitch = Pitch.D_4, Duration = Duration.Quarter},

                new Note{Pitch = Pitch.C_4, Duration = Duration.Whole}
            };

            var notes = new List<Note>();
            
            notes.AddRange(jingleBellsPhrase);
            notes.AddRange(ohWhatFunPhrase);
            notes.AddRange(oneHorseA);

            notes.AddRange(jingleBellsPhrase);
            notes.AddRange(ohWhatFunPhrase);
            notes.AddRange(oneHorseB);

            JingleBells.Notes = notes.ToArray();

            return JingleBells;
        }

    }
}
