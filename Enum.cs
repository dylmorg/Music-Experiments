using System;
namespace testFolder
{
    public enum NoteLetter {
            A = 0,
            BFlat = 1,
            B = 2,
            CFlat = B,
            C = 3,
            CSharp = 4,
            DFlat = CSharp,
            D  = 5, 
            DSharp = 6,
            EFlat = DSharp,
            E = 7,
            Esharp = 8,
            F = Esharp,
            FSharp = 9, 
            GFlat = FSharp,
            G = 10,
            GSharp = 11,
            AFlat = GSharp                   
    };
    
    public enum Mode{
        //Major
        Ionain = 1,
        Dorian = 2,
        Phrygian = 3,
        //Carries your burdens
        Lydian = 4,
        Mixolydian = 5,
        //Minor
        Aeolian = 6,
        Locrian = 7
    }
}