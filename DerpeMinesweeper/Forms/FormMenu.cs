using DerpeMinesweeper.Data;

namespace DerpeMinesweeper.Forms
{
    public partial class FormMenu : Form
    {
        /// <inheritdoc cref="DerpeMinesweeper.Data.GameSettings"/>
        public GameSettings Settings { get; set; }



        /// <summary>
        /// Default constructor. Sets default game settings.
        /// </summary>
        public FormMenu()
        {
            InitializeComponent();
            Settings = new()
            {
                Skin = GameSkin.Classic,
                SpriteSize = new Size(25, 25),
                FieldSize = new Size(15, 15),
                MineCount = 45
            };
        }



        /// <summary>
        /// Opens 'Settings' form.
        /// </summary>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings(this);
            formSettings.ShowDialog();
        }

        /// <summary>
        /// Opens 'Game' form.
        /// </summary>
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formGame = new FormGame(Settings);
            formGame.ShowDialog();
            this.Show();
        }
    }
}
