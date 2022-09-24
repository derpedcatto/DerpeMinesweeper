using DerpeMinesweeper.Logic;

namespace DerpeMinesweeper.Data.Entity
{
    public class CellMine : CellBase
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public CellMine(Size spriteSize) : base(spriteSize) { }


        public override void Reveal()
        {
            base.Reveal();
            Sprite.Image = GetSprite.CellClickedMine();
        }
    }
}
