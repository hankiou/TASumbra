using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASumbra
{
    class RunLauncher
    {
        private MemoryReader memoryReader;

        public string penumbraPath;
        private Label gameClockLabel;

        public RunLauncher(string gamePath,Label gameClockLabel)
        {
            this.penumbraPath = gamePath;
            this.memoryReader = new MemoryReader();
            this.gameClockLabel = gameClockLabel;
        }

        public void Start()
        {
            Thread thread = new Thread(gameClockRefresher);
            thread.Start();
        }

        public void gameClockRefresher()
        {
            rienAFoutre:
            gameClockLabel.Invoke(new MethodInvoker(delegate
            {
                gameClockLabel.Text = MemoryReader.ReadPenumbraMemory().ToString();
            }));
            Thread.Sleep(1);
            goto rienAFoutre;

        }
    }
}
