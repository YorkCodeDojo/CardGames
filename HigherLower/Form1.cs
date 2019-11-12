using PackOfCards;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class Form1 : Form
    {
        private Pack _pack;
        private int _currentCardIndex;
        private int _seed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame(Environment.TickCount);

            BackColor = Color.FromArgb(7, 99, 36);

            DisplayCards();
        }

        private void PlayAgain()
        {
            var frm = new NewGame();
            frm.ShowDialog();

            switch (frm.Result)
            {
                case NewGameResult.NewGame:
                    NewGame(Environment.TickCount);
                    break;
                case NewGameResult.Replay:
                    NewGame(_seed);
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }

        private void NewGame(int seed)
        {
            _pack = new Pack();
            var rnd = new Random(seed);
            for (int i = 0; i < 100; i++)
            {
                _pack.Shuffle(rnd);
            }

            _seed = seed;
            Text = $"Higher or Lower (Seed: {seed})";

            _currentCardIndex = 0;
            DisplayCards();
        }

        private void DisplayCards()
        {
            DisplayCard(_pack.GetCard(0), pbCard1, true);
            DisplayCard(_pack.GetCard(1), pbCard2, _currentCardIndex >= 1);
            DisplayCard(_pack.GetCard(2), pbCard3, _currentCardIndex >= 2);
            DisplayCard(_pack.GetCard(3), pbCard4, _currentCardIndex >= 3);
            DisplayCard(_pack.GetCard(4), pbCard5, _currentCardIndex >= 4);
        }

        private void DisplayCard(Card card, PictureBox pbCard, bool condition)
        {
            if (condition)
            {
                pbCard.Load(card.Filename());
                pbCard.SizeMode = PictureBoxSizeMode.AutoSize;
                pbCard.BackColor = Color.White;
                pbCard.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pbCard.Load("cards/back.png");
                pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                pbCard.BackColor = Color.White;
                pbCard.BorderStyle = BorderStyle.FixedSingle;
                pbCard.Width = 223;
                pbCard.Height = 320;
            }
        }

        private void cmdHigher_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value > previousCard.Value);
        }

        private void cmdLower_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value < previousCard.Value);
        }

        private void cmdSame_Click(object sender, EventArgs e)
        {
            CompareCards((newCard, previousCard) => newCard.Value == previousCard.Value);
        }

        private void CompareCards(Func<Card, Card, bool> guess)
        {
            _currentCardIndex++;

            DisplayCards();

            var previousCard = _pack.GetCard(_currentCardIndex - 1);
            var newCard = _pack.GetCard(_currentCardIndex);

            if (!guess(newCard, previousCard))
            {
                PlayAgain();
            }

            if (_currentCardIndex >= 4)
            {
                MessageBox.Show("You won - well done");
                return;
            }
        }
    }
}
