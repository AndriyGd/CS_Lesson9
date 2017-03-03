using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CS_Lesson9
{
    abstract class Smartphone : BasePhone
    {
        private DateTime _stTime;
        private Thread _thread;
        private bool _isPause, _isRecording;
        
        public FleshCard FleshCard { get; set; }
        public string ScreenResolution { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public float InnerStorage { get; set; }


        protected virtual void StartRecordVideo()
        {
            if (!_isPause)
            {
                _stTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                _isRecording = true;
                _thread = new Thread(Recording);
                _thread.Start();
            }
            else
            {
                _isRecording = true;
                _thread.Resume();
            }
        }

        protected virtual void PauseRecordVideo()
        {
            _thread.Suspend();
            _isPause = true;
            _isRecording = false;
            Console.WriteLine("Pause.");
        }

        protected virtual void StopRecordVideo()
        {
            _isPause = false;
            _isRecording = false;
            _thread.Abort();
            Console.WriteLine("Video saved.");
        }

        private void Recording()
        {
            

            while (_isRecording)
            {
                var span = DateTime.Now - _stTime;
                Console.WriteLine($"Recording: {span.Hours}:{span.Minutes}:{span.Seconds}");
                Thread.Sleep(1000);
            }           
        }
    }
}
