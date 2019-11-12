using PackOfCards;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HigherLower
{
    public partial class Form1 : Form
    {
        private Pack _pack;
        private int _seed;
        private bool _player1 = true;
        private Queue<Card> _player1Cards = new Queue<Card>();
        private Queue<Card> _player2Cards = new Queue<Card>();
        private List<Card> _pile = new List<Card>();

        public Form1()
        {
            InitializeComponent();
            CreateCards();
        }

        private void DisplayPlayer()
        {
            label1.Visible = _player1;
            panel1.Visible = _player1;

            label2.Visible = !_player1;
            panel2.Visible = !_player1;

            pbPile1.Visible = _player1Cards.Count > 0;
            pbPile1Top.Visible = _player1Cards.Count > 1;

            pbPile2.Visible = _player2Cards.Count > 0;
            pbPile2Top.Visible = _player2Cards.Count > 1;

            pbTop.Visible = _pile.Count > 0;
            pbBottom.Visible = _pile.Count > 1;

            if (_pile.Count > 0)
                pbTop.Load(_pile[_pile.Count - 1].Filename());

            if (_pile.Count > 1)
                pbBottom.Load(_pile[_pile.Count - 2].Filename());
        }

        private void CreateCards()
        {
            pbTop.BorderStyle = BorderStyle.FixedSingle;
            pbTop.SizeMode = PictureBoxSizeMode.AutoSize;
            pbTop.BackColor = Color.White;

            pbBottom.BorderStyle = BorderStyle.FixedSingle;
            pbBottom.SizeMode = PictureBoxSizeMode.AutoSize;
            pbBottom.BackColor = Color.White;

            pbPile1.Load("cards/back.png");
            pbPile1.BorderStyle = BorderStyle.FixedSingle;
            pbPile1.SizeMode = PictureBoxSizeMode.AutoSize;

            pbPile2.Load("cards/back.png");
            pbPile2.BorderStyle = BorderStyle.FixedSingle;
            pbPile2.SizeMode = PictureBoxSizeMode.AutoSize;

            pbPile1Top.Load("cards/back.png");
            pbPile1Top.BorderStyle = BorderStyle.FixedSingle;
            pbPile1Top.SizeMode = PictureBoxSizeMode.AutoSize;

            pbPile2Top.Load("cards/back.png");
            pbPile2Top.BorderStyle = BorderStyle.FixedSingle;
            pbPile2Top.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame(Environment.TickCount);

            BackColor = Color.FromArgb(7, 99, 36);

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

            for (int i = 0; i < 52; i += 2)
            {
                _player1Cards.Enqueue(_pack.GetCard(i));
                _player2Cards.Enqueue(_pack.GetCard(i + 1));
            }

            _seed = seed;
            Text = $"Snap";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_player1 && e.KeyCode == Keys.Z)
            {
                var card = _player1Cards.Dequeue();
                _pile.Add(card);

                if (_player1Cards.Count == 0)
                {
                    MessageBox.Show("Player 1 wins!");
                }

                _player1 = false;

                DisplayPlayer();
            }

            if (!_player1 && e.KeyCode == Keys.OemQuestion)
            {
                var card = _player2Cards.Dequeue();
                _pile.Add(card);

                if (_player2Cards.Count == 0)
                {
                    MessageBox.Show("Player 2 wins!");
                }

                _player1 = true;

                DisplayPlayer();
            }

            if (e.KeyCode == Keys.X)
            {
                if (_pile.Count > 1)
                {
                    var top = _pile[_pile.Count - 1];
                    var bottom = _pile[_pile.Count - 2];

                    if (top.Value == bottom.Value)
                    {
                        MessageBox.Show("Player 1 correctly says SNAP!");
                        foreach (var card in _pile)
                        {
                            _player2Cards.Enqueue(card);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Player 1 wrongly says SNAP!");
                        foreach (var card in _pile)
                        {
                            _player1Cards.Enqueue(card);
                        }
                    }

                    _pile.Clear();
                    _player1 = false;
                }

                DisplayPlayer();
            }

            if (e.KeyCode == Keys.OemPeriod)
            {
                if (_pile.Count > 1)
                {
                    var top = _pile[_pile.Count - 1];
                    var bottom = _pile[_pile.Count - 2];

                    if (top.Value == bottom.Value)
                    {
                        MessageBox.Show("Player 2 correctly says SNAP!");
                        foreach (var card in _pile)
                        {
                            _player1Cards.Enqueue(card);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Player 2 wrongly says SNAP!");
                        foreach (var card in _pile)
                        {
                            _player2Cards.Enqueue(card);
                        }
                    }

                    _pile.Clear();
                    _player1 = true;
                }

                DisplayPlayer();
            }
        }
    }
}
