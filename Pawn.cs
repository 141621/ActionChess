using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Chessman
{
    public override bool[,] PossibleMove()
    {
        bool[,] r = new bool[8, 8];

        r[3, 3] = true;
        return r;
    }
}
        //Chessman c, c2;
        /*
        //White move
        if (isWhite)
        {
            //Diagonal Left
            if(CurrentX != 0  && CurrentY != 7)
            {
                c = BoardManager.Instance.Chessmans[CurrentX - 1, CurrentY + 1];
                if (c != null && !c.isWhite)
                    r[CurrentX - 1, CurrentY + 1] = true;
            }

            //Diagonal Right

            //Middle

            //Middle on first move
            
            
            
        }

        return r;
    }
}
*/