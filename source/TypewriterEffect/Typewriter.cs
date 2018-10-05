using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypewriterEffect
{
    public class Typewriter : IDisposable
    {
        public class Label
        {
            internal string Text;
            internal LabelMode _LabelMode;
            public enum LabelMode
            {
                OverwriteText,
                AppendText
            }
            public Label(string text, LabelMode labelMode = LabelMode.OverwriteText)
            {
                Text = text;
                _LabelMode = labelMode;
            }
        }
        private readonly List<Label> Messages = new List<Label>();
        private readonly int Delay;
        private readonly int endDelay;
        private readonly System.Windows.Forms.Label TextLabel;
        private readonly int RepeatCursorTimes;

        private bool isInitialized;
        private bool isEnabled;
        private int currIndexMessage;
        private int currIndexLetter = -1;
        private string currText;
        private bool disposedValue;
        private readonly string startTextValue;
        private Thread loopThread;

        public Typewriter(System.Windows.Forms.Label textLabel, List<Label> messages, int delayInMiliSeconds, int repeatCursorTimes = 5, int waitAtEndDelay = 0, bool start = true)
        {
            TextLabel = textLabel;
            Messages = messages;
            Delay = delayInMiliSeconds;
            endDelay = waitAtEndDelay;
            RepeatCursorTimes = repeatCursorTimes;
            startTextValue = textLabel.Text;
            Initialize();
            if (start)
                Start();
        }
        private void Initialize()
        {
            if (isInitialized)
                throw new InvalidOperationException("Cannot initialize typewriter because it has already been initialized.");
            isInitialized = true;
            loopThread = new Thread(TypewriterLoop);
            loopThread.Start();
        }
        private void TypewriterLoop()
        {
            while (isInitialized)
            {
                if (isEnabled)
                {
                    Thread.Sleep(Delay);
                    if (IsLetterOutOfRange())
                    {
                        currIndexLetter = 0;
                        if (++currIndexMessage > Messages.Count - 1)
                            currIndexMessage = 0;
                        StartCursor();
                        StartRemoveTextIfNeeded();
                        Thread.Sleep(endDelay);
                        AppendOrOverwriteText();
                        continue;
                    }
                    AppendText(Messages[currIndexMessage].Text[currIndexLetter] + "|");
                    continue;
                }
                Thread.Sleep(1);
            }
        }
        private void AppendOrOverwriteText()
        {
            if (Messages[currIndexMessage]._LabelMode == Label.LabelMode.OverwriteText)
            {
                ChangeText(Messages[currIndexMessage].Text[currIndexLetter].ToString());
                return;
            }
            AppendText(Messages[currIndexMessage].Text[currIndexLetter].ToString());
        }
        private void StartRemoveTextIfNeeded()
        {
            if (Messages[currIndexMessage]._LabelMode == Label.LabelMode.OverwriteText)
            {
                var currLength = currText.Length;
                for (int i = 0; i < currLength; i++)
                {
                    Thread.Sleep(Delay);
                    if (!isEnabled)
                        continue;
                    ChangeText(currText.Remove(currText.Length - 1));
                }
            }
        }
        private void StartCursor()
        {
            if (endDelay != 0)
            {
                if (RepeatCursorTimes != 0)
                    for (int i = 0; i < RepeatCursorTimes; i++)
                    {
                        Thread.Sleep(200);
                        AppendText("_");
                        Thread.Sleep(200);
                        ChangeText(currText.Remove(currText.Length - 1));
                    }
                Thread.Sleep(endDelay);
            }
        }
        private bool IsLetterOutOfRange()
        {
            return ++currIndexLetter > Messages[currIndexMessage].Text.Length - 1;
        }
        private void AppendText(string text)
        {
            if (currText != null)
                currText = currText.TrimEnd('|');
            currText += text;
            ModifyText(currText);
        }
        private void ChangeText(string text)
        {
            currText = text;
            ModifyText(currText);
        }
        private void ModifyText(string text)
        {
            if (TextLabel.InvokeRequired)
                TextLabel.BeginInvoke((MethodInvoker)delegate () { TextLabel.Text = text; });
            else
                TextLabel.Text = text;
        }
        public void Start()
        {
            isEnabled = true;
        }
        public void Stop()
        {
            isEnabled = false;
        }
        public void Toggle()
        {
            if (isEnabled)
            {
                Stop();
                return;
            }
            Start();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Stop();
                    ChangeText(startTextValue);
                    isInitialized = false;
                }

                disposedValue = true;
            }
        }
        ~Typewriter()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
