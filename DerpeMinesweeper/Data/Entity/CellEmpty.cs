using DerpeMinesweeper.Logic;

namespace DerpeMinesweeper.Data.Entity
{
    public class CellEmpty : CellBase
    {
        /// <summary>
        /// Contains number of number of bordering mines. Used for setting cell sprite after reveal.
        /// </summary>
        public int BorderingMinesCount { get; }


        /// <summary>
        /// Default constructor.
        /// </summary>
        public CellEmpty(Size spriteSize, int borderingMineCount) : base(spriteSize) 
        {
            BorderingMinesCount = borderingMineCount;
        }


        public override void Reveal()
        {
            base.Reveal();
            Sprite.Image = GetSprite.CellEmpty(BorderingMinesCount);
        }
    }
}
