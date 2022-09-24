using DerpeMinesweeper.Data;
using DerpeMinesweeper.Data.Entity;
using DerpeMinesweeper.Forms;

namespace DerpeMinesweeper.Logic
{
    /// <summary>
    /// Controls all cells and its behaviours on minefield.
    /// </summary>
    public class CellController
    {
        #region Variables

        private FormGame _form;

        /// <inheritdoc cref="DerpeMinesweeper.Data.GameSettings"/>
        private GameSettings _settings;

        /// <summary>
        /// Counts unrevealed empty cells. Game over if 0.
        /// </summary>
        private int _emptyCount = 0;

        /// <summary>
        /// Stores all game cells in grid format.
        /// </summary>
        public CellBase[,] CellField { get; }

        #endregion



        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public CellController(FormGame form)
        {
            _form = form;
            _settings = _form.GameSettings;

            CellField = new CellBase[_settings.FieldSize.Height, _settings.FieldSize.Width];
            SetCells();

            // Subscribing to reveal of cells
            foreach (var cell in CellField)
            {
                cell.RevealEvent += new RevealEventHandler(RevealEvent);
            }
        }

        #endregion



        #region Methods - Generation

        /// <summary>
        /// Generates and sets all 'GameField' cells.
        /// </summary>
        private void SetCells()
        {
            var rand = new Random();
            var size = _settings.FieldSize;

            // Setting mines
            for (int i = 0; i < _settings.MineCount; i++)
            {
                int x = rand.Next(size.Width);
                int y = rand.Next(size.Height);

                if (CellField[y, x] == null)
                {
                    CellField[y, x] = new CellMine(_settings.SpriteSize);
                }
                else
                {
                    i--;
                    continue;
                }
            }

            // Setting empty cells
            for (int i = 0; i < _settings.FieldSize.Height; i++)
            {
                for (int j = 0; j < _settings.FieldSize.Width; j++)
                {
                    if (CellField[i, j] is CellMine)
                        continue;

                    var index = new Point(j, i);
                    CellField[i, j] = new CellEmpty(_settings.SpriteSize, GetNeighbouringMineCount(index));

                    _emptyCount++;
                }
            }
        }


        /// <summary>
        /// Used for setting number in empty cell.
        /// </summary>
        /// <param name="index">Index for accessing 'CellField' cell.</param>
        /// <returns>Count of all neighbouring mines.</returns>
        private int GetNeighbouringMineCount(Point index)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    try
                    {
                        if (CellField[index.Y + i, index.X + j] is CellMine)
                            count++;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return count;
        }

        #endregion



        #region Methods - Game logic

        /// <summary>
        /// Logic for cell reveal.
        /// </summary>
        private void RevealEvent(object sender, EventArgs e)
        {
            if (sender is CellEmpty cell)
            {
                _emptyCount--;

                if (cell.BorderingMinesCount == 0)
                {
                    CascadeRevealEmpty(GetCell(cell));
                }

                if (_emptyCount == 0)
                    GameOver(true);
            }

            if (sender is CellMine)
            {
                GameOver(false);
            }
        }


        /// <param name="cell">Reference to cell.</param>
        /// <returns>Index of cell from 'CellField'.</returns>
        private Point GetCell(CellBase cell)
        {
            for (int i = 0; i < _settings.FieldSize.Height; i++)
            {
                for (int j = 0; j < _settings.FieldSize.Width; j++)
                {
                    if (CellField[i, j] == cell)
                        return new Point(j, i);
                }
            }
            return new Point(0, 0);
        }


        /// <summary>
        /// Recursively iterates and reveals all empty cells without neighbouring mines.
        /// </summary>
        /// <param name="index">Array index of 'CellField'.</param>
        private void CascadeRevealEmpty(Point index)
        {
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    try
                    {
                        if (CellField[index.Y + i, index.X + j] is CellEmpty _cell)
                        {
                            if (!_cell.IsChecked && !_cell.IsRevealed)
                            {
                                _cell.Reveal();
                                _emptyCount--;

                                if (_cell.BorderingMinesCount == 0)
                                {
                                    CascadeRevealEmpty(new Point(index.X + j, index.Y + i));
                                }
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
        }


        /// <summary>
        /// Reveals all tiles, generates results and calls GameOver method from FormGame.
        /// </summary>
        /// <param name="isWin"></param>
        public void GameOver(bool isWin)
        {
            GameResults results = new();
            results.IsWin = isWin;

            foreach (var cell in CellField)
            {
                if (cell is CellMine mine)
                {
                    if (mine.IsChecked)
                        results.CheckedMines++;
                    else
                        results.UncheckedMines++;
                }
                if (cell is CellEmpty empty)
                {
                    if (empty.IsRevealed)
                        results.RevealedEmptyCells++;
                    if (empty.IsChecked)
                        results.CheckedEmptyCells++;
                }

                cell.Reveal();
            }
            
            _form.GameOver(results);
        }

        #endregion
    }
}