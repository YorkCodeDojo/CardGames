using System;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class NewGame : Form
    {
        internal NewGameResult Result { get; private set; }

        public NewGame()
        {
            InitializeComponent();
            Result = NewGameResult.Exit;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Result = NewGameResult.Exit; 
            DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void cmdReplay_Click(object sender, EventArgs e)
        {
            Result = NewGameResult.Replay;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            Result = NewGameResult.NewGame;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
