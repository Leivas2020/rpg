using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
  class player
  {
    int STRENGHTH, DEXTERITY, CONSTITUTION, INTELLIGENCE, WISDOM, CHARISMA;

    public player()
    {

    }
    public player(int _STR, int _DEX,int _CON,int _INT,int _WIS,int _CHA)
    {
      STRENGHTH = _STR;
      DEXTERITY = _DEX;
      CONSTITUTION = _CON;
      INTELLIGENCE = _INT;
      WISDOM = _WIS;
      CHARISMA = _CHA;


    }
  }
}
