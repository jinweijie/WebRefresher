using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebRefresher
{
    public partial class Main : Form
    {
        private CancellationTokenSource cts;

        public Main()
        {
            InitializeComponent();
            HandleButtonStart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            HandleButtonStart();
            StartTask();
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            HandleButtonStart();
            StopTask();
        }

        private void HandleButtonStart()
        {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }
        private void HandleButtonStop()
        {
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
        }

        void StartTask()
        {
            cts = new CancellationTokenSource();
            var token = cts.Token;

            Task t = Task.Factory.StartNew(
                () => {
                    MainLoop(token);
                },
                token,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default
            );
        }

        void StopTask()
        {
            cts.Cancel();
        }

        void MainLoop(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    token.ThrowIfCancellationRequested();
                }

                LoadPage();
                Thread.Sleep(new TimeSpan(0, 0, int.Parse(this.txtInterval.Text)));
            }
        }
        
        private void LoadPage()
        {
            this.wbBrowser.Navigate(this.txtUrl.Text);
        }
    }
}
