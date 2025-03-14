using System.Speech.Recognition;

namespace Delulu
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
        DateTime _lastCheckTime = DateTime.Now;
        long _frameCount = 0;
        Size KDSize;
        Size GDSize;
        Point KDLocation;
        Point GDLocation;
        // called whenever a map is updated
        void OnMapUpdated()
        {
            Interlocked.Increment(ref _frameCount);
        }

        // called every once in a while
        double GetFps()
        {
            double secondsElapsed = (DateTime.Now - _lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref _frameCount, 0);
            double fps = count / secondsElapsed;
            _lastCheckTime = DateTime.Now;
            return fps;
        }
        public Form1()
        {
            InitializeComponent();
            KDSize = pictureBox1.Size;
            GDSize = pictureBox2.Size;
            KDLocation = pictureBox1.Location;
            GDLocation = pictureBox2.Location;
            label1.Text = "";

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Size = new Size(pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Size = new Size(pictureBox1.Size.Width - 5, pictureBox1.Size.Height);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                ;
            }
            catch (Exception ex)
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
                ;
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Size = new Size(pictureBox1.Size.Width + 5, pictureBox1.Size.Height);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                ;
            }
            catch (Exception ex)
            {

            }
        }

        private void GameTick_Tick(object sender, EventArgs e)
        {
           
            var keys = Console.ReadKey().Key;
            OnMapUpdated();
            if (keys == ConsoleKey.W)
            {
                try
                {
                    float x = pictureBox1.Location.X - 5;
                    float y = pictureBox1.Location.Y - 5;
                    float z = pictureBox1.Size.Width + 10;
                    float a = pictureBox1.Size.Height + 10;
                    label1.Text = label1.Text + "\n Key registered 'W' / " + pictureBox1.Size.Height.ToString() + " + 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " + 10 /=/ " + z.ToString() + pictureBox1.Location.X.ToString() + " - 5 /=/ " + x.ToString() + pictureBox1.Location.Y.ToString() + " - 5 /=/ " + y.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);


                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.E)
            {
                ;
                SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
                sr.SetInputToDefaultAudioDevice();
                Grammar word = new DictationGrammar();
                sr.LoadGrammar(word);
                RecognitionResult resultr = sr.Recognize();
                string result = resultr.Text.ToLower();
                label1.Text = label1.Text + "\n" + result;
                if (result.Contains("w"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X - 5;
                        float y = pictureBox1.Location.Y - 5;
                        float z = pictureBox1.Size.Width + 10;
                        float a = pictureBox1.Size.Height + 10;
                        label1.Text = label1.Text + "\n Key registered 'W' / " + pictureBox1.Size.Height.ToString() + " + 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " + 10 /=/ " + z.ToString() + pictureBox1.Location.X.ToString() + " - 5 /=/ " + x.ToString() + pictureBox1.Location.Y.ToString() + " - 5 /=/ " + y.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width + 10, pictureBox1.Size.Height + 10);
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);


                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("s"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X + 5;
                        float y = pictureBox1.Location.Y + 5;
                        float z = pictureBox1.Size.Width - 10;
                        float a = pictureBox1.Size.Height - 10;
                        label1.Text = label1.Text + "\n Key registered 'S' / " + pictureBox1.Size.Height.ToString() + " - 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " - 10 /=/ " + z.ToString() + pictureBox1.Location.X.ToString() + " + 5 /=/ " + x.ToString() + pictureBox1.Location.Y.ToString() + " + 5 /=/ " + y.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("right"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X - 10;
                        float y = pictureBox1.Size.Width - 20;
                        label1.Text = label1.Text + "\n Key registered 'RIGHTARROW' / " + pictureBox1.Location.X.ToString() + " - 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " - 20 /=/ " + y.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width - 20, pictureBox1.Size.Height);
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("left"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X + 10;
                        float y = pictureBox1.Size.Width + 20;
                        label1.Text = label1.Text + "\n Key registered 'LEFTARROW' / " + pictureBox1.Location.X.ToString() + " + 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " + 20 /=/ " + y.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width + 20, pictureBox1.Size.Height);
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("down"))
                {
                    try
                    {
                        float x = pictureBox1.Location.Y - 10;
                        float y = pictureBox1.Size.Height - 5;
                        float z = pictureBox2.Size.Height + 20;
                        float a = pictureBox2.Location.Y - 10;
                        label1.Text = label1.Text + "\n Key registered 'DOWNARROW' / " + pictureBox1.Size.Height.ToString() + " - 5 /=/" + y.ToString() + " / " + pictureBox1.Location.Y.ToString() + " - 10 /=/ " + x.ToString() + " / " + pictureBox2.Size.Height.ToString() + " + 20 /=/" + z.ToString() + " / " + pictureBox2.Location.Y.ToString() + " - 10 /=/" + a.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height - 5);
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                        pictureBox2.Size = new Size(pictureBox2.Size.Width, pictureBox2.Size.Height + 20);


                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("up"))
                {
                    try
                    {
                        float x = pictureBox1.Location.Y + 10;
                        float y = pictureBox1.Size.Height + 5;
                        float z = pictureBox2.Size.Height - 5;
                        float a = pictureBox2.Location.Y + 5;
                        label1.Text = label1.Text + "\n Key registered 'UPARROW' / " + pictureBox1.Size.Height.ToString() + " + 5 /=/" + y.ToString() + " / " + pictureBox1.Location.Y.ToString() + " + 10 /=/ " + x.ToString() + " / " + pictureBox2.Size.Height.ToString() + " - 5 /=/" + z.ToString() + " / " + pictureBox2.Location.Y.ToString() + " + 5 /=/" + a.ToString();
                        pictureBox1.Size = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height + 5);
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
                        pictureBox2.Size = new Size(pictureBox2.Size.Width, pictureBox2.Size.Height - 5);

                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (result.Contains("d"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X - 10;
                        label1.Text = label1.Text + "\n Key registered 'D' / " + pictureBox1.Location.X.ToString() + " - 10 /=/ " + x.ToString();
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else if (result.Contains("a"))
                {
                    try
                    {
                        float x = pictureBox1.Location.X + 10;
                        label1.Text = label1.Text + "\n Key registered 'A' / " + pictureBox1.Location.X.ToString() + " + 10 /=/ " + x.ToString();
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            else if (keys == ConsoleKey.S)
            {
                try
                {
                    float x = pictureBox1.Location.X + 5;
                    float y = pictureBox1.Location.Y + 5;
                    float z = pictureBox1.Size.Width - 10;
                    float a = pictureBox1.Size.Height - 10;
                    label1.Text = label1.Text + "\n Key registered 'S' / " + pictureBox1.Size.Height.ToString() + " - 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " - 10 /=/ " + z.ToString() + pictureBox1.Location.X.ToString() + " + 5 /=/ " + x.ToString() + pictureBox1.Location.Y.ToString() + " + 5 /=/ " + y.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width - 10, pictureBox1.Size.Height - 10);
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);


                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.RightArrow)
            {
                try
                {
                    float x = pictureBox1.Location.X - 10;
                    float y = pictureBox1.Size.Width - 20;
                    label1.Text = label1.Text + "\n Key registered 'RIGHTARROW' / " + pictureBox1.Location.X.ToString() + " - 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " - 20 /=/ " + y.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width - 20, pictureBox1.Size.Height);
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                    ;
                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.LeftArrow)
            {
                try
                {
                    float x = pictureBox1.Location.X + 10;
                    float y = pictureBox1.Size.Width + 20;
                    label1.Text = label1.Text + "\n Key registered 'LEFTARROW' / " + pictureBox1.Location.X.ToString() + " + 10 /=/ " + x.ToString() + pictureBox1.Size.Width.ToString() + " + 20 /=/ " + y.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width + 20, pictureBox1.Size.Height);
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                    ;
                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.DownArrow)
            {
                try
                {
                    float x = pictureBox1.Location.Y - 10;
                    float y = pictureBox1.Size.Height - 5;
                    float z = pictureBox2.Size.Height + 20;
                    float a = pictureBox2.Location.Y - 10;
                    label1.Text = label1.Text + "\n Key registered 'DOWNARROW' / " + pictureBox1.Size.Height.ToString() + " - 5 /=/" + y.ToString() + " / " + pictureBox1.Location.Y.ToString() + " - 10 /=/ " + x.ToString() + " / " + pictureBox2.Size.Height.ToString() + " + 20 /=/" + z.ToString() + " / " + pictureBox2.Location.Y.ToString() + " - 10 /=/" + a.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height - 5);
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 10);
                    pictureBox2.Size = new Size(pictureBox2.Size.Width, pictureBox2.Size.Height + 20);


                    ;
                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.UpArrow)
            {
                try
                {
                    float x = pictureBox1.Location.Y + 10;
                    float y = pictureBox1.Size.Height + 5;
                    float z = pictureBox2.Size.Height - 5;
                    float a = pictureBox2.Location.Y + 5;
                    label1.Text = label1.Text + "\n Key registered 'UPARROW' / " + pictureBox1.Size.Height.ToString() + " + 5 /=/" + y.ToString() + " / " + pictureBox1.Location.Y.ToString() + " + 10 /=/ " + x.ToString() + " / " + pictureBox2.Size.Height.ToString() + " - 5 /=/" + z.ToString() + " / " + pictureBox2.Location.Y.ToString() + " + 5 /=/" + a.ToString();
                    pictureBox1.Size = new Size(pictureBox1.Size.Width, pictureBox1.Size.Height + 5);
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 10);
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
                    pictureBox2.Size = new Size(pictureBox2.Size.Width, pictureBox2.Size.Height - 5);
                    ;
                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.Backspace)
            {
                pictureBox1.Size = KDSize;
                pictureBox1.Location = KDLocation;
                pictureBox2.Size = GDSize;
                pictureBox2.Location = GDLocation;

                label1.Text = label1.Text + "\n Key registered 'BACKSPACE' / RESET WORLD";
                ;
            }
            else if (keys == ConsoleKey.D)
            {
                try
                {
                    float x = pictureBox1.Location.X - 10;
                    label1.Text = label1.Text + "\n Key registered 'D' / " + pictureBox1.Location.X.ToString() + " - 10 /=/ " + x.ToString();
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
                }
                catch (Exception ex)
                {
                }
            }
            else if (keys == ConsoleKey.A)
            {
                try
                {
                    float x = pictureBox1.Location.X + 10;
                    label1.Text = label1.Text + "\n Key registered 'A' / " + pictureBox1.Location.X.ToString() + " + 10 /=/ " + x.ToString();
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y);
                }
                catch (Exception ex)
                {

                }
            }
            else if (keys == ConsoleKey.P)
            {
                colorDialog1.ShowDialog();
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog1.Color;
                }
              
            }


            Console.Clear();
            richTextBox1.Text = "FPS: " + GetFps().ToString() + "\n Kanade: " + pictureBox1.Location.ToString() + " " + pictureBox1.Size.ToString() + "\n Ground: " + pictureBox2.Location.ToString() + " " + pictureBox2.Size.ToString();

        }

        private void recognizer_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string FirstLine = label1.Text.Split('\n')[0];
                label1.Text = label1.Text.Remove(0, FirstLine.Length + 1);
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
