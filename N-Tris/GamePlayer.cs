﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tris
{
    public abstract class GamePlayer
    {
        public abstract HashSet<int> getMoves(GameBoardManager manager);
    }

}
