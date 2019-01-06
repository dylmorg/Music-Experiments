using System;
namespace testFolder
{
  //Starts at 0 because the scale is tune to A4 at 440 mhz, and western music uses 12 notes
    public class Note
    {

        public Note(int note, int addOctave)
        {
          noteNumber = note;
          octave = addOctave;
        }

    public int noteNumber { get;set; }

    public int octave { get; set; }

    public string parseThisNoteToLetter
    {
        get
        {
            try
            {
                string returnedString = Enum.Parse(typeof(NoteLetter), noteNumber.ToString()).ToString();
                returnedString = String.Concat(returnedString, octave.ToString());
                return returnedString;
            }
            catch
            {

            }
            return "";
        }
    }
  }     
}