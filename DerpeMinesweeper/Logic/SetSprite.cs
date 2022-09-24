using DerpeMinesweeper.Data;

namespace DerpeMinesweeper.Logic
{
    /// <summary>
    /// Static class that gives images to game cells corresponding to set game skin.
    /// </summary>
    public static class GetSprite
    {
        public static GameSkin Skin { get; set; }
        private static readonly Image error = Sprites.Other.error;


        public static Image Checked()
        {
            switch (Skin)
            {
                case GameSkin.Classic:
                    return Sprites.Classic.classic_Flag;
                case GameSkin.Windows7:
                    return Sprites.Windows7.win7_Flag;
                default:
                    return error;
            }
        }

        public static Image UnChecked()
        {
            switch (Skin)
            {
                case GameSkin.Classic:
                    return Sprites.Classic.classic_Tile;
                case GameSkin.Windows7:
                    return Sprites.Windows7.win7_Tile;
                default:
                    return error;
            }
        }

        public static Image CellEmpty(int number)
        {
            switch (Skin)
            {
                case GameSkin.Classic:
                    switch (number)
                    {
                        case 0: return Sprites.Classic.classic_Empty;
                        case 1: return Sprites.Classic.classic_One;
                        case 2: return Sprites.Classic.classic_Two;
                        case 3: return Sprites.Classic.classic_Three;
                        case 4: return Sprites.Classic.classic_Four;
                        case 5: return Sprites.Classic.classic_Five;
                        case 6: return Sprites.Classic.classic_Six;
                        case 7: return Sprites.Classic.classic_Seven;
                        case 8: return Sprites.Classic.classic_Eight;
                    }
                    break;

                case GameSkin.Windows7:
                    switch(number)
                    {
                        case 0: return Sprites.Windows7.win7_Empty;
                        case 1: return Sprites.Windows7.win7_One;
                        case 2: return Sprites.Windows7.win7_Two;
                        case 3: return Sprites.Windows7.win7_Three;
                        case 4: return Sprites.Windows7.win7_Four;
                        case 5: return Sprites.Windows7.win7_Five;
                        case 6: return Sprites.Windows7.win7_Six;
                        case 7: return Sprites.Windows7.win7_Seven;
                        case 8: return Sprites.Windows7.win7_Eight;
                    }
                    break;
            }
            return error;
        }

        public static Image CellClickedMine()
        {
            switch (Skin)
            {
                case GameSkin.Classic:
                    return Sprites.Classic.classic_ClickedMine;
                case GameSkin.Windows7:
                    return Sprites.Windows7.win7_ClickedMine;
                default:
                    return error;
            }
        }
    }
}
