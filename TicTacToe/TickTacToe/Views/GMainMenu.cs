using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Interfaces;

namespace Views
{
    public partial class GMainMenu : Form, IMainMenuView
    {
        public event EventHandler PlayerOneNameChanged;
        public event EventHandler PlayerTwoNameChanged;
        public event EventHandler PlayButtonClicked;
        public event EventHandler QuitButtonClicked;

        public string PlayerOneName
        {
            get { return playerOneNameTextbox.Text; }

            set { playerOneNameTextbox.Text = value; }
        }

        public string PlayerTwoName
        {
            get { return playerTwoNameTextbox.Text; }

            set { playerTwoNameTextbox.Text = value; }
        }
        
        public GMainMenu()
        {
            InitializeComponent();
            PlayerOneName = "Player One";
            PlayerTwoName = "Player Two";
        }

        private void playerOneNameTextbox_TextChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (PlayerOneNameChanged != null)
            {
                PlayerOneNameChanged(this, e);
            }

            Cursor.Current = Cursors.Default;
        }

        private void playerTwoNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (PlayerTwoNameChanged != null)
            {
                PlayerTwoNameChanged(this, e);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (PlayButtonClicked != null)
            {
                PlayButtonClicked(this, e);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            if (QuitButtonClicked != null)
            {
                QuitButtonClicked(this, e);
            }
        }
    }
}
