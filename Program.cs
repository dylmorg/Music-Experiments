using System;

namespace testFolder
{
    class Program
    {
        static void Main(string[] args)
        {
           var lastNote = note.A;
           while(true)
           {
               lastNote = GenerateNextNote(lastNote);

           }
        }
        //Probably need to move into its own class
        public static note GenerateNextNote(note lastNote)
        {
            lastNote = ++lastNote;
            PlayNote.PlaySingleNote(lastNote);
            return lastNote;
        }
        
        
    }
}