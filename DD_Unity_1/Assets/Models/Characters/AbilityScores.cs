using System;
using System.Collections;
using System.Collections.Generic;

namespace Dungeon_Darkly
{
  public class AbilityScores
  {
    public int Str { get; set; }
    public int Dex { get; set; }
    public int Con { get; set; }
    public int Wis { get; set; }
    public int Int { get; set; }
    public int Cha { get; set; }
    public int Lck { get; set; }

    public AbilityScores(int str, int dex, int con, int wis, int intel, int cha, int lck)
    {
      this.Str = str;
      this.Dex = dex;
      this.Con = con;
      this.Wis = wis;
      this.Int = intel;
      this.Cha = cha;
      this.Lck = lck;
    }

    public int ScoreMod(string score)
    {
      // System.Reflection.PropertyInfo temp = this.GetType().GetProperty(score);
      // int x = (int)(temp.GetValue(this, null));

      // double mod = (x - 10) / 2;
      // if (mod < 0)
      // {
      //   return Math.Floor(mod);
      // }
      // else
      // {
      //   return Int32.Parse(mod);
      // }
      return 1; //Unity testing
    }

  }
}

// export class AbilityScores {
//   constructor(str,dex,con,wis,int,chr,lck) {
//     this.str = str;
//   }
// }

// export class AbilityScores {
//   constructor(str,dex,con,wis,int,chr,lck) {
//     this.str = str;
//     this.dex = dex;
//     this.con = con;
//     this.wis = wis;
//     this.int = int;
//     this.chr = chr;
//     this.lck = lck; 
//   }

//   scoreMod (score) {
//     let mod = (this[score]-10)/2;
//     if (mod < 0) {
//       return Math.floor(mod);
//     } else {
//       return parseInt(mod);
//     }
//   }  
// }
