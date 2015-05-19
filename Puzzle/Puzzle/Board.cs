using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace Puzzle
{
    public class Board
    {
        public Panel panel;
        public System.Drawing.Graphics pG;
        public int width;
        public int height;
        public int boxWidth;
        public int boxHeight;
        public int[,] brd = new int[4, 4];
        public int[,] original = new int[4, 4];
        public static int blankR = -1;
        public static int blankC = -1;
        public int[] lastMove = {-1,-1,-1,-1,-1};//last r, last c, new r, new c, num
        public Board(Panel p)
        {
            panel = p;
            pG = panel.CreateGraphics();
            width = panel.Width;
            height = panel.Height;
            boxHeight = panel.Height / 4;
            boxWidth = panel.Width / 4;
        }

        public void displayBoard()
        {
            pG.FillRectangle(new SolidBrush(Color.White), 0, 0, width, height);
            drawLines(true);
        }//method

        public void findTheBlank()
        {
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (brd[r, c] == 0)
                    {
                        blankC = c;
                        blankR = r;
                        if(GameArea.highlightOn) pG.FillRectangle(new SolidBrush(Color.Gray), c * boxWidth, r * boxHeight, boxWidth, boxHeight);
                        drawLines(false);
                    }
                }
            }
        }
        public void fillBoard()
        {
            Random rando = new Random();
            for (int i = 1; i <= 15; i++)
            {
                bool placed = false;
                while (!placed)
                {
                    int r = rando.Next(0, 4);
                    int c = rando.Next(0, 4);
                    if (brd[r, c] == 0)
                    {
                        brd[r, c] = i;
                        original[r, c] = i;
                        fillHelper(r, c, i);
                        placed = true;
                    }
                }
            }
            findTheBlank();
        }

        public void resetBoard()
        {
            clearDisplay();
            for (int r = 0; r < 4; r++)
            {

                for (int c = 0; c < 4; c++)
                {
                    brd[r, c] = original[r, c];
                    fillHelper(r, c, original[r, c]);
                }//for c
            }//for r
            findTheBlank();
        }

        public void drawLines(bool isNew)
        {
            for (int r = 0; r < 4; r++)
            {

                for (int c = 0; c < 4; c++)
                {
                    pG.DrawRectangle(new Pen(new SolidBrush(Color.Black),4), c * boxWidth, r * boxHeight, boxWidth, boxHeight);
                    if (!isNew && brd[r,c]!=0)
                    {
                        fillHelper(r, c, brd[r, c]);
                    }
                }//for c
            }//for r
        }
        public void clearDisplay()
        {
            displayBoard();
            brd = new int[4, 4];
        }

        public void fillSquare(Point pt)
        {
            int probR = -1, probC = -1;
            try
            {
                probC = pt.X / boxWidth;
                probR = pt.Y / boxHeight;
                if (isAdjacentToBlank(probR, probC))
                {
                    lastMove[0] = probR;
                    lastMove[1] = probC;
                    lastMove[2] = blankR;
                    lastMove[3] = blankC;
                    lastMove[4] = brd[probR, probC];
                    fillHelper(blankR, blankC, brd[probR,probC]);
                    eraseSquare(pt);
                    findTheBlank();
                }
                else
                {
                    MessageBox.Show("Sorry. That tile cannot be moved.");
                    return;
                }
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC + ioore.ToString());
            }
        }

        public void highlightAround()
        {
            findTheBlank();
            for (int r = 0; r < 4; r++)
            {

                for (int c = 0; c < 4; c++)
                {
                    unhighlight(brd[r, c], r, c);
                    if (isAdjacentToBlank(r, c))
                    {
                        highlight(brd[r, c], r, c);
                    }
                }//for c
            }//for r
        }

        public bool isAdjacentToBlank(int row, int col)
        {
            findTheBlank();
            if ((row-1==blankR && col==blankC) || (row+1==blankR && col==blankC) || (row==blankR && col-1==blankC) || (row==blankR && col+1==blankC))
            {
                return true;
            }
            return false;
        }

        public bool fillHelper(int row, int col, int num)
        {
            int offset = 30;
            if (num < 10) offset = 40;
            brd[row, col] = num;
            pG.DrawString(num.ToString(), new Font("Arial", 36), new SolidBrush(Color.Black), new Point(col * boxWidth + offset, row * boxHeight + 30));
            return true;

        }
        public void eraseSquare(Point pt)
        {
            int probR = -1, probC = -1;
            try
            {
                probC = pt.X / boxWidth;
                probR = pt.Y / boxHeight;
                brd[probR, probC] = 0;
                //new Point(probC*boxWidth+boxWidth/2,probR*boxHeight+boxHeight/2)
                pG.FillRectangle(new SolidBrush(Color.White), probC * boxWidth, probR * boxHeight, boxWidth, boxHeight);
            }
            catch (IndexOutOfRangeException ioore)
            {
                MessageBox.Show("Index out of range. probR is " + probR + " and probC is " + probC);
            }
        }//method

        public void highlight(int num, int row, int col)
        {
            if (num == 0) return;
            if (!GameArea.highlightOn) return;
            int offset = 30;
            if (num < 10) offset = 40;
            pG.FillRectangle(new SolidBrush(Color.Green), col * boxWidth, row * boxHeight, boxWidth, boxHeight);
            pG.DrawString(num.ToString(), new Font("Arial", 36), new SolidBrush(Color.White), new Point(col * boxWidth + offset, row * boxHeight + 30));
            drawLines(false);
        }

        public void unhighlight(int num, int row, int col)
        {
            if (num == 0) return;
            if (!GameArea.highlightOn) return;
            int offset = 30;
            if (num < 10) offset = 40;
            pG.FillRectangle(new SolidBrush(Color.White), col * boxWidth, row * boxHeight, boxWidth, boxHeight);
            pG.DrawString(num.ToString(), new Font("Arial", 36), new SolidBrush(Color.Black), new Point(col * boxWidth + offset, row * boxHeight + 30));
            drawLines(false);
        }

        public int compareBoards(Board b)
        {
            int count = 0;
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    b.unhighlight(b.brd[r, c], r, c);
                    if (brd[r, c] != b.brd[r, c])
                    {
                        count++;
                    }
                    else
                    {
                        b.highlight(b.brd[r, c], r, c);
                    }
                }
            }
            return count;
        }

        public void undo()
        {
            fillHelper(blankR, blankC, lastMove[4]);
            brd[lastMove[2], lastMove[3]] = 0;
            pG.FillRectangle(new SolidBrush(Color.White), lastMove[3] * boxWidth, lastMove[2] * boxHeight, boxWidth, boxHeight);
        }
    }//class
}//namespace