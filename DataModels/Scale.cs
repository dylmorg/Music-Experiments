using System;
using System.Collections.Generic;

namespace testFolder
{
  //Starts at 0 because the scale is tune to A4 at 440 mhz, and western music uses 12 notes
    public class Scale
    {
        public List<Note> NotesInScale;
        public Mode Mode {get; set;}
        public int ScaleLength {get;set;}
//        protected int Length { get => length; set => length = value; }

        public Scale (Note startingNote, int scaleLength, Mode mode = Mode.Aeolian)
        {
            ScaleLength = scaleLength;            
            Mode = mode;
            NotesInScale = new List<Note>();      
            NotesInScale.Add(startingNote);      
            BuildScale();
        }

        private void BuildScale()
        {
            int modeToInt = (int)Mode;
            //Add the mode to the notes because it helps determine whole vs half steps
            for (int i = 0 + modeToInt; i < ScaleLength + modeToInt - 1; i++)
            {            
                var a = i - modeToInt;
                Note currentNote = new Note(NotesInScale[a].noteNumber,  NotesInScale[a].octave);
                currentNote.noteNumber = currentNote.noteNumber + 2;
                //In Western scales, every fourth step is a half step
                if (i%4 == 0)
                {
                    --currentNote.noteNumber;
                }
                if (currentNote.noteNumber >= 12)
                {    
                    currentNote.noteNumber -= 12;
                    ++currentNote.octave;
                }
                NotesInScale.Add(currentNote);
            }                                        
        }                
    }
}