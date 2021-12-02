/*  Created by: Team 3 - Taiyo, Charlie, Manny, Miguel, Matthew, Isaac
 *  Project: Brick Breaker
 *  Date: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown, spacebarDown;

        //collision variable for breaking out of the ball foreach loop
        bool didCollide = false;

        // Game values
        int lives;
        int score;

        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;

        // lists
        public static List<Block> blocks = new List<Block>();
        public static List<PowerUp> powerUps = new List<PowerUp>();
        public static List<Ball> balls = new List<Ball>();

        //image arrays
        public static Image[] powerUpImages = { BrickBreaker.Properties.Resources._1Up_Mushroom, BrickBreaker.Properties.Resources.Super_Star, 
            BrickBreaker.Properties.Resources.Double_Cherry, BrickBreaker.Properties.Resources.Super_Mushroom, BrickBreaker.Properties.Resources.Mini_Mushroom };
        public static Image[] brickImages = { BrickBreaker.Properties.Resources.Brick_Question, BrickBreaker.Properties.Resources.Brick_1hp, 
            BrickBreaker.Properties.Resources.Brick_2hp, BrickBreaker.Properties.Resources.Brick_3hp, BrickBreaker.Properties.Resources.Brick_4hp, 
            BrickBreaker.Properties.Resources.Brick_5hp };
        public static Image rainbow = BrickBreaker.Properties.Resources.rainbow_effect2;

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush textBrush = new SolidBrush(Color.White);

        // Sound effect arrays
        public static SoundPlayer[] powerUpSounds = { new SoundPlayer(Properties.Resources._1_UP_Mushroom_Sound_Effect), 
            new SoundPlayer(Properties.Resources.Super_Mario_Star_Sound), new SoundPlayer(Properties.Resources.PowerUp_Sound_Effect), 
            new SoundPlayer(Properties.Resources._Mushroom_Sound_Effect), new SoundPlayer(Properties.Resources._Mini_Mushroom_Sound_Effect) };

        //font for text
        Font textFont = new Font("Arial", 16);

        //random generator
        public static Random randGen = new Random();

        //global paddle and ball values
        int paddleWidth, paddleHeight, paddleX, paddleY, paddleSpeed;

        int ballX, ballY, xSpeed, ySpeed, ballSize;

        //powerup counters
        int starCounter, superMushCounter, miniMushCounter = 0;

        //powerup activated or not
        bool powerActive, starActive, superMushActive, miniMushActive = false;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set life counter
            lives = 3;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = spacebarDown = false;

            // setup starting paddle values and create paddle object
            paddleWidth = 80;
            paddleHeight = 20;
            paddleX = ((this.Width / 2) - (paddleWidth / 2));
            paddleY = (this.Height - paddleHeight) - 60;
            paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            ballX = this.Width / 2 - 10;
            ballY = this.Height - paddle.height - 80;
            xSpeed = 5;
            ySpeed = 5;
            ballSize = 20;

            //makes sure the balls list is empty from the last game
            balls.Clear();
            // Creates starting ball
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);
            balls.Add(ball);

            #region Temporary code that loads levels.

            //TODO: select level
            //clears screen and loads level 1

            blocks.Clear();

            int newX, newY, newHp, newColour, newType;

            XmlReader reader = XmlReader.Create("Resources/level1.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {

                    newX = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("y");
                    newY = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("hp");
                    newHp = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("colour");
                    newColour = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("type");
                    newType = Convert.ToInt32(reader.ReadString());

                    Block s = new Block(newX, newY, newHp, newColour, newType);
                    blocks.Add(s);
                }
            }

            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spacebarDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //check if any powerups are active
            if (powerActive == true)
            {//check which powerups are active
                if (starActive == true)
                {
                    starCounter++;
                    ball.StarCollision(this);
                    if (starCounter == 2000)
                    {
                        starActive = false;
                    }
                }
                else if (superMushActive == true)
                {
                    superMushCounter++;
                    if (superMushCounter == 1200)
                    {
                        paddle.width = 80;
                        superMushActive = false;
                    }
                }
                else if (miniMushActive == true)
                {
                    miniMushCounter++;
                    if (miniMushCounter == 1200)
                    {
                        paddle.width = 80;
                        miniMushActive = false;
                    }
                }
                else if (starActive && superMushActive && miniMushActive == false)
                {
                    powerActive = false;
                }
            }

            // Move the paddle
            if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            //move powerups
            foreach (PowerUp p in powerUps)
            {
                p.Move();
            }

            foreach (Ball b in balls)
            {
                // Move ball
                if(spacebarDown == true)
                {
                    b.Move();
                }

                if (spacebarDown == false)
                {
                    ball.x = paddle.x + paddleWidth / 2 - ballSize / 2;
                }

                // Check for collision with top and side walls
                b.WallCollision(this);

                // Check for ball hitting bottom of screen
                if (b.BottomCollision(this))
                {
                    lives--;

                    
                    RemoveBall(b);

                    if (lives == 0)
                    {
                        gameTimer.Enabled = false;
                        OnEnd();
                    }

                    RemoveBall(b);
                    break;
                }

                // Check for collision of ball with paddle, (incl. paddle movement)
                b.PaddleCollision(paddle);

                // Check if ball has collided with any blocks
                foreach (Block bl in blocks)
                {
                    if (b.BlockCollision(bl))
                    {
                        bl.hp--;
                        score++;

                        if (bl.colour != 0)
                        {
                            bl.colour = bl.hp;
                        }

                        if (bl.type == 0)
                        {
                            SpawnPowerUp(bl.x, bl.y);
                        }

                        if (bl.hp == 0)
                        {
                            blocks.Remove(bl);
                        }

                        if (blocks.Count == 0)
                        {
                            gameTimer.Enabled = false;
                            OnEnd();
                        }
                        didCollide = true;
                        break;
                    }
                }

                if (didCollide)
                {
                    didCollide = false;
                    break;
                }
            }

            //check powerup collision with bottom
            foreach (PowerUp p in powerUps)
            {
                if (p.BottomCollision(this))
                {
                    powerUps.Remove(p);
                    break;
                }

                //check powerup collision with paddle
                if (p.PaddleCollision(paddle))
                {
                    ActivatePowerUp(p);
                    break;
                }
            }

            //redraw the screen
            Refresh();
        }

        public void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();

            GameOverScreen gos = new GameOverScreen();
            gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            form.Controls.Add(gos);
            form.Controls.Remove(this);

            Form1.highscoreList.Add(new Scores(score+""));
        }

        public void ResetBall()
        {
            balls[0].x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
            balls[0].y = (this.Height - paddle.height) - 85;
            balls[0].xSpeed = 5;
            balls[0].ySpeed = 5;
        }


        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            foreach(Block b in blocks)
            {
                e.Graphics.DrawImage(brickImages[b.colour], b.x, b.y, b.width, b.height);
            }

            // Draws blocks

            //foreach (Block b in blocks)
            //{
            //    if (b.type == 0)
            //    {
            //        e.Graphics.DrawImage(brickImages[0], b.x, b.y, b.width, b.height);
            //    }
            //    else if (b.hp == 1)
            //    {
            //        e.Graphics.DrawImage(brickImages[0], b.x, b.y, b.width, b.height);
            //    }
            //    else if (b.hp == 2)
            //    {
            //        e.Graphics.DrawImage(brickImages[1], b.x, b.y, b.width, b.height);
            //    }
            //    else if (b.hp == 3)
            //    {
            //        e.Graphics.DrawImage(brickImages[2], b.x, b.y, b.width, b.height);
            //    }
            //    else if (b.hp == 4)
            //    {
            //        e.Graphics.DrawImage(brickImages[3], b.x, b.y, b.width, b.height);
            //    }
            //    else if (b.hp == 5)
            //    {
            //        e.Graphics.DrawImage(brickImages[4], b.x, b.y, b.width, b.height);
            //    }
            //}

            //draws powerups
            foreach (PowerUp p in powerUps)
            {
                if (p.type == 1)
                {
                    e.Graphics.DrawImage(powerUpImages[p.type - 1], p.x, p.y, p.size, p.size);
                }
                else if (p.type == 2)
                {
                    e.Graphics.DrawImage(powerUpImages[p.type - 1], p.x, p.y, p.size, p.size);
                }
                else if (p.type == 3)
                {
                    e.Graphics.DrawImage(powerUpImages[p.type - 1], p.x, p.y, p.size, p.size);
                }
                else if (p.type == 4)
                {
                    e.Graphics.DrawImage(powerUpImages[p.type - 1], p.x, p.y, p.size, p.size);
                }
                else if (p.type == 5)
                {
                    e.Graphics.DrawImage(powerUpImages[p.type - 1], p.x, p.y, p.size, p.size);
                }
            }

            // Draws ball
            foreach (Ball b in balls)
            {
                e.Graphics.FillRectangle(ballBrush, b.x, b.y, b.size, b.size);
            }

            //draws life counter
            e.Graphics.DrawString($"Lives left: {lives}", textFont, textBrush, 370, 490);

            //draws score counter
            e.Graphics.DrawString($"Score: {score}", textFont, textBrush, 370, 510);

            //if star power is active, draw rainbow effect at bottom
            //Draw star rainbow effect
            if (starActive == true)
            {
                e.Graphics.DrawImage(rainbow, 0, 658, 1068, 20);
            }
        }

        public void AddBall()
        {
            ball = new Ball(balls[0].x, balls[0].y, balls[0].xSpeed * -1, balls[0].ySpeed, ballSize);
            balls.Add(ball);
        }

        public void RemoveBall(Ball b)
        {
            if (balls.Count == 1)
            {
                ResetBall();
                spacebarDown = false;
                //// Moves the ball back to origin
                //b.x = ((paddle.x - (b.size / 2)) + (paddle.width / 2));
                //b.y = (this.Height - paddle.height) - 85;
                //b.xSpeed = 5;
                //b.ySpeed = 5;
            }
            else
            {
                balls.Remove(b);
            }
        }

        public void SpawnPowerUp(int x, int y)
        {
            int size = 40;
            int speed = 4;
            int type = randGen.Next(1, 5);

            //create powerup object and spawn it on powerup block's x and y
            PowerUp p = new PowerUp(x, y, size, speed, type);

            powerUps.Add(p);
        }

        public void _1UpMushroom()
        {
            lives = lives + 1;
        }

        public void SuperStar()
        {
            starCounter = 0;
            starActive = true;
            powerActive = true;
        }

        public void DoubleCherry()
        {
            AddBall();
        }

        public void SuperMushroom()
        {
            superMushCounter = 0;
            superMushActive = true;
            powerActive = true;

            paddle.width = 250;
        }

        public void MiniMushroom()
        {
            miniMushCounter = 0;
            miniMushActive = true;
            powerActive = true;

            paddle.width = 50;
        }

        public void ActivatePowerUp(PowerUp p)
        {
            if (p.type == 1)
            {
                powerUpSounds[0].Play();
                _1UpMushroom();
            }
            else if (p.type == 2)
            {
                powerUpSounds[1].Play();
                SuperStar();
            }
            else if (p.type == 3)
            {
                powerUpSounds[2].Play();
                DoubleCherry();
            }
            else if (p.type == 4)
            {
                powerUpSounds[3].Play();
                SuperMushroom();
            }
            else if (p.type == 5)
            {
                powerUpSounds[4].Play();
                MiniMushroom();
            }

            powerUps.Remove(p);
        }

    }
}
