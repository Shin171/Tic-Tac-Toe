namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int turn = 0;
        public string player1 = "X";
        public string player2 = "O";
        public string[] board = new string[9];

        public string placeAttack(int pos)
        {
            string currentPlayer = (turn % 2 == 0) ? player1 : player2;
            turn++;
            board[pos] = currentPlayer;
            return currentPlayer;
        }
        public void checkWinner()
        {
            string winner = null;

            // Rows
            if (board[0] != null && board[0] == board[1] && board[1] == board[2])
                winner = board[0];
            else if (board[3] != null && board[3] == board[4] && board[4] == board[5])
                winner = board[3];
            else if (board[6] != null && board[6] == board[7] && board[7] == board[8])
                winner = board[6];
            // Columns
            else if (board[0] != null && board[0] == board[3] && board[3] == board[6])
                winner = board[0];
            else if (board[1] != null && board[1] == board[4] && board[4] == board[7])
                winner = board[1];
            else if (board[2] != null && board[2] == board[5] && board[5] == board[8])
                winner = board[2];
            // Diagonals
            else if (board[0] != null && board[0] == board[4] && board[4] == board[8])
                winner = board[0];
            else if (board[2] != null && board[2] == board[4] && board[4] == board[6])
                winner = board[2];

            if (winner != null)
            {
                MessageBox.Show($"Player {winner} wins!", "Game Over");
                resetGame();
                return;
            }

            if (board[0] != null && board[1] != null && board[2] != null &&
                board[3] != null && board[4] != null && board[5] != null &&
                board[6] != null && board[7] != null && board[8] != null)
            {
                MessageBox.Show("It's a draw!", "Game Over");
                resetGame();
            }
        }

        public void resetGame()
        {
            board[0] = null;
            board[1] = null;
            board[2] = null;
            board[3] = null;
            board[4] = null;
            board[5] = null;
            board[6] = null;
            board[7] = null;
            board[8] = null;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            turn = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (board[0] == null)
            {
                button1.Text = placeAttack(0);
                checkWinner();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (board[1] == null)
            {
                button2.Text = placeAttack(1);
                checkWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (board[2] == null)
            {
                button3.Text = placeAttack(2);
                checkWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (board[3] == null)
            {
                button4.Text = placeAttack(3);
                checkWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (board[4] == null)
            {
                button5.Text = placeAttack(4);
                checkWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (board[5] == null)
            {
                button6.Text = placeAttack(5);
                checkWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (board[6] == null)
            {
                button7.Text = placeAttack(6);
                checkWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (board[7] == null)
            {
                button8.Text = placeAttack(7);
                checkWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (board[8] == null)
            {
                button9.Text = placeAttack(8);
                checkWinner();
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
