using PackOfCards;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class Form1 : Form
    {
        private Pack _pack;
        private int _seed;
        private PictureBox[,] _cards = new PictureBox[13, 4];
        private int _cardsOnDisplay = 0;
        private PictureBox _firstCard;
        private PictureBox _secondCard;

        private int _player1Score = 0;
        private int _player2Score = 0;
        private bool _player1sTurn = true;

        private void DisplayScore()
        {
            this.Text = $"Pairs -  Player1: {_player1Score}      Player2:  {_player2Score}";
        }
        public Form1()
        {
            InitializeComponent();
            CreateCards();
        }

        private void CreateCards()
        {
            var cardNumber = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 13; column++)
                {
                    var pbCard = new PictureBox();
                    pbCard.Location = new System.Drawing.Point(row * 10, column * 20);
                    pbCard.Name = $"pbCard_{column}_{row}";
                    pbCard.Size = new System.Drawing.Size(10, 20);
                    pbCard.TabIndex = 0;
                    pbCard.TabStop = false;
                    pbCard.Load("cards/back.png");
                    pbCard.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbCard.BackColor = Color.White;
                    pbCard.BorderStyle = BorderStyle.FixedSingle;
                    pbCard.Tag = cardNumber;
                    Controls.Add(pbCard);
                    _cards[column, row] = pbCard;

                    pbCard.Click += PbCard_Click;
                    cardNumber++;
                }
            }
        }

        private void PbCard_Click(object sender, EventArgs e)
        {
            switch (_cardsOnDisplay)
            {
                case 0:
                    _firstCard = sender as PictureBox;
                    _firstCard.Load(_pack.GetCard((int)_firstCard.Tag).Filename());
                    _cardsOnDisplay = 1;
                    break;

                case 1:
                    _secondCard = sender as PictureBox;
                    _secondCard.Load(_pack.GetCard((int)_secondCard.Tag).Filename());
                    _cardsOnDisplay = 2;
                    timerCompare.Enabled = true;
                    break;

                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame(Environment.TickCount);

            BackColor = Color.FromArgb(7, 99, 36);
            txtPlayer.BackColor = Color.FromArgb(7, 99, 36);

            DisplayCards();

            DisplayPlayer();
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
            Text = $"Pairs";

            DisplayCards();
        }

        private void DisplayCards()
        {
            var gap = 20;
            var availableWidth = this.Width - 40;
            var availableHeight = this.Height - 60;
            var cardWidth = ((availableWidth - 20) / 13) - gap;
            var cardHeight = ((availableHeight - 20) / 4) - gap;

            var y = gap;
            for (int row = 0; row < 4; row++)
            {
                var x = gap;
                for (int column = 0; column < 13; column++)
                {
                    var pbCard = _cards[column, row];
                    pbCard.Location = new System.Drawing.Point(x, y);
                    pbCard.Size = new System.Drawing.Size(cardWidth, cardHeight);
                    x += gap + cardWidth;
                }
                y += gap + cardHeight;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DisplayCards();
            this.Refresh();
        }

        private void timerCompare_Tick(object sender, EventArgs e)
        {
            timerCompare.Enabled = false;

            var card1 = _pack.GetCard((int)_firstCard.Tag);
            var card2 = _pack.GetCard((int)_secondCard.Tag);

            if (card1.Value == card2.Value)
            {
                _firstCard.Visible = false;
                _secondCard.Visible = false;

                _firstCard.Click -= PbCard_Click;
                _secondCard.Click -= PbCard_Click;


                if (_player1sTurn)
                    _player1Score++;
                else
                    _player2Score++;

                DisplayScore();
            }
            else
            {
                _firstCard.Load("cards/back.png");
                _secondCard.Load("cards/back.png");
            }


            _cardsOnDisplay = 0;
            _player1sTurn = !_player1sTurn;

            DisplayPlayer();
        }

        private void DisplayPlayer()
        {
            if (_player1sTurn)
            {
                txtPlayer.TextAlign = HorizontalAlignment.Left;
                txtPlayer.Text = "Player 1";
            }
            else
            {
                txtPlayer.TextAlign = HorizontalAlignment.Right;
                txtPlayer.Text = "Player 2";
            }
        }
    }
}
