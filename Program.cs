using System;

namespace testFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastNote = notes.note.A;
           while(true)
           {
               lastNote = GenerateNextNote(lastNote);

           }
        }
        public static notes.note GenerateNextNote(notes.note lastNote)
        {
            lastNote = ++lastNote;
            playNote(lastNote);
            return lastNote;
        }
        //Change testing
        public static void playNote(notes.note currentNote)
        {
            Console.Beep((int)(440 * Math.Pow(Math.Pow(2,(double)1/12),(int)currentNote - 1)), 1000);
        }
    }
}