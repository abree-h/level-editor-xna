using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileEngine
{
    //properties of our tile
    class MapCell
    {
        //TileId denotes the type of our tile
        public int TileID { get; set; }

        public MapCell(int tileID)
        {
            TileID = tileID;
        }
    }
}
