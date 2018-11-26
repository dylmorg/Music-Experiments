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
        public static note GenerateNextNote(note lastNote)
        {
            lastNote = ++lastNote;
            playNote(lastNote);
            return lastNote;
        }
        //Change test
        public static void playNote(note currentNote)
        {
            Console.Beep((int)(440 * Math.Pow(Math.Pow(2,(double)1/12),(int)currentNote - 1)), 1000);
        }
    }
}