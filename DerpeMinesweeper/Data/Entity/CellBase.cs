using DerpeMinesweeper.Logic;

namespace DerpeMinesweeper.Data.Entity
{
    public delegate void RevealEventHandler(object sender, EventArgs e);

    /// <summary>
    /// Base class for all minefield cells.
    /// </summary>
    public abstract class CellBase
    {
        public event RevealEventHandler RevealEvent;
        public PictureBox Sprite { get; set; }
        public bool IsRevealed { get; protected set; }
        public bool IsChecked { get; private set; }



        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="spriteSize"></param>
        public CellBase(Size spriteSize)
        {
            Sprite = new PictureBox()
            {
                Image = GetSprite.UnChecked(),
                Size = spriteSize,
                Margin = new Padding(0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            Sprite.MouseClick += MouseClickEvent;

            IsRevealed = false;
            IsChecked = false;
        }


        /// <summary>
        /// Logic for interacting with game cell.
        /// </summary>
        public void MouseClickEvent(object sender, MouseEventArgs e)
        {
            if (!IsRevealed)
            {
                if (e.Button == MouseButtons.Left && !IsChecked)
                {
                    Reveal();
                    RevealEvent?.Invoke(this, null);    // Subscriber pattern - notify all subscribers
                }
                if (e.Button == MouseButtons.Right)
                    SwitchCheck();
            }
        }

        /// <summary>
        /// Left mouse click action. Reveals cell.
        /// </summary>
        public virtual void Reveal()
        {
            IsRevealed = true;
        }

        /// <summary>
        /// Right mouse button click action. Switches flag status on a tile that cannot be revealed.
        /// </summary>
        public void SwitchCheck()
        {
            IsChecked = !IsChecked;
            if (IsChecked)
                Sprite.Image = GetSprite.Checked();
            else
                Sprite.Image = GetSprite.UnChecked();
        }
    }
}
