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
            //For each note in the scale
            for (int i = 1; i <= scaleLength; i++)
            {
                currentNote = currentNote + 2;
                //In Western scales, every fourth step is a half step
                if (i%4 == 0)
                {
                    --currentNote;
                }
                //If we have gone over an octave, bring it back down
                if ((int)currentNote > 12)
                {
                    currentNote = currentNote - 12;
                }                
                scale.Add(currentNote);
            }        
        }
    }
}