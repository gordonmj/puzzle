using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class GameArea : Form
    {

        public static Board play;
        public static Board goal;
        public static bool highlightOn = true;

        public GameArea()
        {
            InitializeComponent();
        }

        private void GameArea_Load(object sender, EventArgs e)
        {

        }

        private void playBoard_Paint(object sender, PaintEventArgs e)
        {
            play = new Board(playBoard);
            play.displayBoard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            goal = new Board(goalBoard);
            goal.displayBoard();
            refreshGoal.ForeColor = Color.Black;
            refreshInitial.ForeColor = Color.Black;
            MessageBox.Show("Select your initial configurations by clicking the two (re)set buttons");
        }

        private void goalBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newGame_Click(object sender, EventArgs e)
        {
            play.clearDisplay();
            goal.clearDisplay();
            play.displayBoard();
            goal.displayBoard();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            play.undo();
            play.highlightAround();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            play.resetBoard();
            goal.resetBoard();
            play.highlightAround();
        }

        private void refreshInitial_Click(object sender, EventArgs e)
        {
            play.clearDisplay();
            play.fillBoard();
            newGame.ForeColor = Color.Black;
            Undo.ForeColor = Color.Black;
            Reset.ForeColor = Color.Black;
            updateCount();
            play.highlightAround();
        }

        private void refreshGoal_Click(object sender, EventArgs e)
        {
            goal.clearDisplay();
            goal.fillBoard();
            newGame.ForeColor = Color.Black;
            Undo.ForeColor = Color.Black;
            Reset.ForeColor = Color.Black;
            updateCount();
        }

        private void playBoard_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        public void updateCount()
        {
            int misplacedTiles = play.compareBoards(goal);
            count.Text = misplacedTiles.ToString();
            if (misplacedTiles == 0)
            {
                MessageBox.Show("You won! Click 'New Game' or the (re)set buttons to play again.");
            }
        }

        private void playBoard_MouseClick(object sender, MouseEventArgs e)
        {
            play.fillSquare(e.Location);
            play.highlightAround();
            updateCount();
        }

        private void highlight_Click(object sender, EventArgs e)
        {
            if (highlightOn)
            {
                highlight.Text = "Highlight Off";
                highlightOn = false;
                play.findTheBlank();
                play.drawLines(false);
                goal.drawLines(false);

            }
            else
            {
                MessageBox.Show("Sorry. This button doesn't work yet.");
                //highlight.Text = "Highlight On";
                //highlightOn = true;
                //play.highlightAround();
                //updateCount();
            }
        }
    }
}
