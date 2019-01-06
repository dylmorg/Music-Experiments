using System;

namespace testFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Note a = new Note(0, 5);
            Scale testScale = new Scale(a, 8, Mode.Lydian);
            PlayNote.PlayNotes(testScale.NotesInScale);
        }               
    }
}