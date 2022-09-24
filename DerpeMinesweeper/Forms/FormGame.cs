using DerpeMinesweeper.Data;
using DerpeMinesweeper.Logic;
using System.Diagnostics;
using System.Text;

namespace DerpeMinesweeper.Forms
{
    public partial class FormGame : Form
    {
        #region Variables

        private TableLayoutPanel _UIGrid;

        /// <summary>
        /// Grid for setting all minefield sprites.
        /// </summary>
        private TableLayoutPanel _cellGrid;

        /// <summary>
        /// Timer for stopwatch.
        /// </summary>
        System.Windows.Forms.Timer _timer;

        /// <summary>
        /// Counting game duration time.
        /// </summary>
        Stopwatch _stopwatch;

        /// <summary>
        /// Displays game duration time.
        /// </summary>
        private Label _timerLabel;

        /// <inheritdoc cref="DerpeMinesweeper.Logic.CellController"/>
        private CellController _cellController;

        private bool _gameEnd = false;

        /// <inheritdoc cref="DerpeMinesweeper.Data.GameSettings"/>
        public readonly GameSettings GameSettings;

        #endregion



        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FormGame(GameSettings settings)
        {
            InitializeComponent();
            GameSettings = settings;
            GetSprite.Skin = GameSettings.Skin;
            _cellController = new(this);

            _timer = new();
            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(TimerTick);
            _timer.Start();

            _stopwatch = new();
            _stopwatch.Start();

            _timerLabel = new Label();
            _timerLabel.Font = new Font("Segoe UI", 13);
            _timerLabel.Text = "00:00:00";
            _timerLabel.Anchor = AnchorStyles.Top;
            _timerLabel.TextAlign = ContentAlignment.MiddleCenter;

            SetCellGrid();
            SetUIGrid();

            this.Size = new Size(_UIGrid.Size.Width + 16, _UIGrid.Size.Height + 39);    // I don't know how to properly resize it
        }

        #endregion



        #region Methods

        /// <summary>
        /// Updates '_timerLabel' with '_stopwatch' value.
        /// </summary>
        void TimerTick(object sender, EventArgs e)
        {
            _timerLabel.Text = String.Format("{0:hh\\:mm\\:ss}", _stopwatch.Elapsed);
        }


        /// <summary>
        /// Sets '_UIGrid' elements.
        /// </summary>
        private void SetUIGrid()
        {
            int labelHeight = _timerLabel.Size.Height;

            _UIGrid = new()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,

                Size = new Size(_cellGrid.Width, _cellGrid.Height + labelHeight),

                Location = new Point(0, 0),

                RowCount = 2,
                ColumnCount = 1,

                Margin = new Padding(0),

                AutoSize = true
            };
            this.Controls.Add(_UIGrid);

            _UIGrid.Controls.Add(_timerLabel, 0, 0);
            _UIGrid.Controls.Add(_cellGrid, 0, 1);
        }


        /// <summary>
        /// Sets style of minefield grid and adds all cells to it.
        /// </summary>
        private void SetCellGrid()
        {
            _cellGrid = new()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None,

                Size = new Size(GameSettings.FieldSize.Width * GameSettings.SpriteSize.Width,
                                GameSettings.FieldSize.Height * GameSettings.SpriteSize.Height),

                RowCount = GameSettings.FieldSize.Height,
                ColumnCount = GameSettings.FieldSize.Width,

                AutoSize = true
            };

            for (int i = 0; i < _cellGrid.RowCount; i++)
            {
                for (int j = 0; j < _cellGrid.ColumnCount; j++)
                {
                    _cellGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, GameSettings.SpriteSize.Height));
                    _cellGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, GameSettings.SpriteSize.Width));

                    _cellGrid.Controls.Add(_cellController.CellField[i, j].Sprite, j, i);
                }
            }
        }


        /// <summary>
        /// Shows game over screen.
        /// </summary>
        public void GameOver(GameResults results)
        {
            _gameEnd = true;

            _stopwatch.Stop();
            _timer.Stop();

            StringBuilder message = new();

            if (results.IsWin) message.Append("You win!\n");
            else message.Append("You lost!\n");

            message.Append($"Time: {_timerLabel.Text}\n\n");

            message.Append($"Revealed cells: {results.RevealedEmptyCells}\n");
            message.Append($"Checked empty cells: {results.CheckedEmptyCells}\n");
            message.Append($"Checked mines: {results.CheckedMines}\n");
            message.Append($"Unchecked mines: {results.UncheckedMines}\n");

            MessageBox.Show(message.ToString());
        }

        #endregion



        #region Events

        /// <summary>
        /// Displays game results if user closes the form before ending the game.
        /// </summary>
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_gameEnd)
                _cellController.GameOver(false);
        }

        #endregion
    }
}
