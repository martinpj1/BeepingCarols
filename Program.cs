using System;
using System.Collections.Generic;
using System.Threading;

namespace ChristmasMusic
{

    static partial class program
    {
        public static PitchFamily ToPitchFamily(this Pitch pitch)
        {
            var pitchName = Enum.GetName(typeof(Pitch), pitch);
            var pitchFamily = pitchName.Remove(pitchName.Length - 2, 2);
            return (PitchFamily)Enum.Parse(typeof(PitchFamily), pitchFamily);
        }

        public static int ToMiliseconds(this Duration duration) => (int)(((TempoModifier * (int)duration) / BPM) * 60 * 1000);

        static Dictionary<Key, Dictionary<PitchFamily, PitchFamily>> KeyDict = new Dictionary<Key, Dictionary<PitchFamily, PitchFamily>>
        {
            { Key.C_Major, new Dictionary<PitchFamily, PitchFamily> { } },
            { Key.E_Minor,
                new Dictionary<PitchFamily, PitchFamily>
                {
                    { PitchFamily.F, PitchFamily.F_Sharp }
                }
            },
            { Key.B_Flat_Major, 
                new Dictionary<PitchFamily, PitchFamily>
                {
                    { PitchFamily.B, PitchFamily.B_Flat },
                    { PitchFamily.E, PitchFamily.E_Flat }
                }
            },
            { Key.G_Minor,
                new Dictionary<PitchFamily, PitchFamily>
                {
                    { PitchFamily.B, PitchFamily.B_Flat },
                    { PitchFamily.E, PitchFamily.E_Flat }
                }
            },
        };

        const double BPM = 200;
        public static double TempoModifier = 1.0d / (double)Duration.Quarter;

        static Key Key = Key.C_Major;

        static void Main(string[] args)
        {

            var jingleBells = GetJingleBells();
            var greensleeves = GetGreensleeves();
            var ohHolyNight = GetOhHolyNight();
            var silentNight = GetSilentNight();

            Play(ohHolyNight);
            Play(silentNight);
            Play(greensleeves);
            Play(jingleBells);
        }

        static void Play(Song song)
        {
            TempoModifier = 1.0d / (double)song.OneBeatDuration;
            Key = song.Key;

            Play(song.Notes);
        }

        static void Play(Note[] notes)
        {
            foreach (var note in notes)
                Play(note);
        }
        static void Play(Note note)
        {
            if (note.Pitch == Pitch.REST)
                Thread.Sleep(note.Duration.ToMiliseconds());
            else
            {
                var pitchFamily = note.Pitch.ToPitchFamily();

                if (KeyDict[Key].ContainsKey(pitchFamily))
                {
                    var pitchChange = KeyDict[Key][pitchFamily];
                    note.Pitch = ChangePitch(note.Pitch, pitchChange);
                }

                Console.Beep((int)note.Pitch, note.Duration.ToMiliseconds());                
            }
        }

        static Pitch ChangePitch(Pitch pitch, PitchFamily PitchFamily)
        {
            var pitchName = Enum.GetName(typeof(Pitch), pitch);
            var changedPitchName = $"{Enum.GetName(typeof(PitchFamily), PitchFamily)}{pitchName.Substring(pitchName.Length - 2)}";
            return (Pitch)Enum.Parse(typeof(Pitch), changedPitchName);
        }

    }

}
