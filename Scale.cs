using System;
using System.Collections.Generic;

namespace testFolder
{
    public class PlayScale
    {
        public static void createScale(note firstNote)
        {
            List<note> scale = new List<note> {};
            scale.Add(firstNote);
            note currentNote = firstNote;
            int scaleLength = 8;
            for (int i = 1; i <= 8; i++)
            {
                currentNote = currentNote + 2;
                if (i%4 == 0)
                {
                    --currentNote;
                }
                if ((int)currentNote > 12)
                {
                    currentNote = currentNote - 12;
                }                
                scale.Add(currentNote);
            }        
        }
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