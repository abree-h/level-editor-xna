using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace TileEngine
{
    //Create the columns for the map
    class MapRow
    {
        public List<MapCell> Columns = new List<MapCell>();
    }

    //Creates the TileMap
    class TileMap
    {
       //Create the rows
        public List<MapRow> Rows = new List<MapRow>();
        //Initialize map width and height
        public int MapWidth = 50;
        public int MapHeight = 50;

       

        public TileMap()
        {
            //Fill the map with rows and columns
            for (int y = 0; y < MapHeight; y++)
            {
                MapRow thisRow = new MapRow();
                for (int x = 0; x < MapWidth; x++)
                {
                    thisRow.Columns.Add(new MapCell(0));
                }
                Rows.Add(thisRow);
            }

            // Create Sample Map Data
            //This will fill our rows and colums with a specific tile, in this case water and grass
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i > 15)
                    {
                        Rows[j].Columns[i].TileID = 2;
                    }
                }
            }

            //TileID represents the colour and type of tile we have.
            /*
            Rows[0].Columns[3].TileID = 3;
            Rows[0].Columns[4].TileID = 3;
            Rows[0].Columns[5].TileID = 1;
            Rows[0].Columns[6].TileID = 1;
            Rows[0].Columns[7].TileID = 1;
            
            Rows[1].Columns[3].TileID = 3;
            Rows[1].Columns[4].TileID = 1;
            Rows[1].Columns[5].TileID = 1;
            Rows[1].Columns[6].TileID = 1;
            Rows[1].Columns[7].TileID = 1;

            Rows[2].Columns[2].TileID = 3;
            Rows[2].Columns[3].TileID = 1;
            Rows[2].Columns[4].TileID = 1;
            Rows[2].Columns[5].TileID = 1;
            Rows[2].Columns[6].TileID = 1;
            Rows[2].Columns[7].TileID = 1;

            Rows[3].Columns[2].TileID = 3;
            Rows[3].Columns[3].TileID = 1;
            Rows[3].Columns[4].TileID = 1;
            Rows[3].Columns[5].TileID = 2;
            Rows[3].Columns[6].TileID = 2;
            Rows[3].Columns[7].TileID = 2;

            Rows[4].Columns[2].TileID = 3;
            Rows[4].Columns[3].TileID = 1;
            Rows[4].Columns[4].TileID = 1;
            Rows[4].Columns[5].TileID = 2;
            Rows[4].Columns[6].TileID = 2;
            Rows[4].Columns[7].TileID = 2;

            Rows[5].Columns[2].TileID = 3;
            Rows[5].Columns[3].TileID = 1;
            Rows[5].Columns[4].TileID = 1;
            Rows[5].Columns[5].TileID = 2;
            Rows[5].Columns[6].TileID = 2;
            Rows[5].Columns[7].TileID = 2;
            
            Rows[6].Columns[2].TileID = 3;
            Rows[6].Columns[3].TileID = 1;
            Rows[6].Columns[4].TileID = 1;
            Rows[6].Columns[5].TileID = 2;
            Rows[6].Columns[6].TileID = 2;
            Rows[6].Columns[7].TileID = 2;
            */
            // End Create Sample Map Data
        }
    }
}
