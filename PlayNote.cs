using System;
using System.Collections.Generic;

namespace testFolder
{
    //Actual class that plays any notes
    public class PlayNote
    {
        
        //Plays the note given, based on the number of note specified
        public static void PlaySingleNote(note currentNote)
        {
            
            Console.Beep((int)(440 * Math.Pow(Math.Pow(2,(double)1/12),(int)currentNote)), 1000);
        }
        //Plays the series of notes given
        public static void PlayNotes(List<note> noteList)
        {
            note[] noteArray = noteList.ToArray();
            for (int i = 0; i < noteList.Count; i++)
            {
                PlaySingleNote(noteList[i]);                
            }
        }
    }
}