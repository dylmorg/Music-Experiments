using System;
namespace testFolder
{
  //Starts at 0 because the scale is tune to A4 at 440 mhz
        public enum note : int {
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
    
}