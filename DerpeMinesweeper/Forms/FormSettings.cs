using DerpeMinesweeper.Data;

namespace DerpeMinesweeper.Forms
{
    public partial class FormSettings : Form
    {
        #region Variables

        private FormMenu _form;
        private GameSettings _settings;

        #endregion



        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="form">Menu form where new settings will be sent to.</param>
        public FormSettings(FormMenu form)
        {
            InitializeComponent();
            _form = form;
            _settings = _form.Settings;

            // Importing values to controls
            comboBox_Skin.SelectedIndex = (int)_settings.Skin; // Enum order == Collection order
            numericMineCount.Value = _settings.MineCount;
            //numericMineCount.Maximum

            numericFieldHeight.Value = _settings.FieldSize.Height;
            numericFieldWidth.Value = _settings.FieldSize.Width;

            numericSpriteHeight.Value = _settings.SpriteSize.Height;
            numericSpriteWidth.Value = _settings.SpriteSize.Width;
        }

        #endregion



        #region Service Methods

        private int DifficultyMineCount()
        {
            int cellCount = _settings.FieldSize.Width * _settings.FieldSize.Height;

            if (radioDifficulty_Easy.Checked)
                return cellCount / 8;

            else if (radioDifficulty_Medium.Checked)
                return cellCount / 6;

            else if (radioDifficulty_Hard.Checked)
                return cellCount / 4;

            else if (radioDifficulty_Custom.Checked)
                return (int)numericMineCount.Value;

            else
                return (int)numericMineCount.Value;
        }

        #endregion



        #region Events

        /// <summary>
        /// Changes game skin in settings. 
        /// </summary>
        private void comboBox_Skin_SelectedValueChanged(object sender, EventArgs e)
        {
            _settings.Skin = (GameSkin)comboBox_Skin.SelectedIndex;
        }


        /// <summary>
        /// Changes custom value of mine count.
        /// </summary>
        private void numericMineCount_ValueChanged(object sender, EventArgs e)
        {
            _settings.MineCount = (int)numericMineCount.Value;
        }

        /// <summary>
        /// Sets custom mine count numeric to readonly if unchecked.
        /// </summary>
        private void radioDifficulty_Custom_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioDifficulty_Custom.Checked)
            {
                numericMineCount.ReadOnly = true;
                numericMineCount.Increment = 0;
            }
            else
            {
                numericMineCount.ReadOnly = false;
                numericMineCount.Increment = 1;
            }
        }


        /// <summary>
        /// Change 'Height' setting for all game sprites.
        /// </summary>
        private void numericSpriteHeight_ValueChanged(object sender, EventArgs e)
        {
            _settings.SpriteSize.Height = (int)numericSpriteHeight.Value;
        }

        /// <summary>
        /// Change 'Width' setting for all game sprites.
        /// </summary>
        private void numericSpriteWidth_ValueChanged(object sender, EventArgs e)
        {
            _settings.SpriteSize.Width = (int)numericSpriteWidth.Value;
        }


        /// <summary>
        /// Changes 'Height' value for field size.
        /// </summary>
        private void numericFieldHeight_ValueChanged(object sender, EventArgs e)
        {
            _settings.FieldSize.Height = (int)numericFieldHeight.Value;
        }

        /// <summary>
        /// Changes 'Width' value for field size.
        /// </summary>
        private void numericFieldWidth_ValueChanged(object sender, EventArgs e)
        {
            _settings.FieldSize.Width = (int)numericFieldWidth.Value;
        }


        /// <summary>
        /// Checks and sends new settings back to Menu form.
        /// </summary>
        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (DifficultyMineCount() >= _settings.FieldSize.Width * _settings.FieldSize.Height)
            {
                MessageBox.Show("Mine count must be lower than field size!");
                return;
            }

            _settings.MineCount = DifficultyMineCount();

            _form.Settings = _settings;

            this.Close();
        }

        #endregion
    }
}
