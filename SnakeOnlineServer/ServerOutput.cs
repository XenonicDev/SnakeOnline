﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace SnakeOnlineServer
{
    public class ServerOutput
    {
        // Retrieve Entire Game World over Network
        public void GetWorld(out int Rows, out int Columns, out int[,] World)
        {
            //World = new int[]

            Rows = 0;
            Columns = 0;
            World = null;
        }

        public void GetMovement(out int Direction)
        {
            Direction = 0;
        }

        public void GetItemSpawn(out int Row, out int Column)
        {
            Row = 0;
            Column = 0;
        }
    }
}
