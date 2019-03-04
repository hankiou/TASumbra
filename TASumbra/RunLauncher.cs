using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TASumbra
{
    class RunLauncher
    {
        private MemoryReader memoryReader;
        Thread gameClockRefresherThread;

        private Label gameClockLabel;
        private Label frames;
        private long framesLong = 0;
        private Label fps;
        private int fpsTemp = 0;
        private Label performanceText;


        public string penumbraPath;

        private void Destroy(object sender, EventArgs e)
        {
            gameClockRefresherThread.Abort();
        }

        public RunLauncher(string gamePath,Label gameClockLabel, Label frames, Label fps, Label performanceText)
        {
            penumbraPath = gamePath;
            memoryReader = new MemoryReader();
            this.gameClockLabel = gameClockLabel;
            this.frames = frames;
            this.fps = fps;
            this.performanceText = performanceText;
        }

        public bool Start()
        {
            if (!memoryReader.InitPenumbraMemoryReader())
            {
                return false;
            }
            gameClockRefresherThread = new Thread(GameClockRefresher);
            Application.ApplicationExit += Destroy;
            gameClockRefresherThread.Start();
            return true;
        }

        public void GameClockRefresher()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            long stopwatchtime = 0;
            long fpsCalcTemp = 1;
            long i = 0;
            float oldgameClock = 0f;
            float gameClock;
            dontCare:
            //stopwatchtime = stopWatch.ElapsedTicks;
            gameClockLabel.Invoke(new MethodInvoker(delegate
            {
                i++;
                gameClock = memoryReader.GetGameClock();
                if(gameClock > oldgameClock)
                {
                    if(stopwatchtime > fpsCalcTemp*10000000 )
                    {
                        FramesPerSecond();
                        fpsCalcTemp++;
                    }
                    oldgameClock = gameClock;
                    gameClockLabel.Text = gameClock.ToString();
                    NextFrame();
                }
                performanceText.Text = ((stopWatch.ElapsedTicks - stopwatchtime) / 10).ToString() + "µs";
                stopwatchtime = stopWatch.ElapsedTicks;
            }));
            Thread.Sleep(1);
            goto dontCare;
        }

        public void NextFrame()
        {
            frames.Text = (++framesLong).ToString();
            fpsTemp++;
        }

        public void FramesPerSecond()
        {
            fps.Text = fpsTemp.ToString();
            fpsTemp = 0;
        }
    }
}
