using System;
using System.Collections.Generic;

namespace testFolder 
{
    //Actual class that plays any notes
    public class PlayNote
    {
        
        //Plays the note given, based on the number of note specified
        public static void PlaySingleNote(Note currentNote, int length)
        {            
            Console.Beep((int)(440 * (double)Math.Pow((double)2.0, (double)currentNote.noteNumber / 12 + currentNote.octave - 4  )), length);
        }

        //Plays the series of notes given
        public static void PlayNotes(List<Note> noteList)
        {
            Note[] noteArray = noteList.ToArray();
            for (int i = 0; i < noteList.Count; i++)
            {
                PlaySingleNote(noteList[i], 1000);
            }
        }
    }
}
