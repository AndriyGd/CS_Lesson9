using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson9
{
    class MobilePhone :Smartphone, ISmartphone
    {
        public void Call(Contact contact, int numberIndex)
        {
            StartCall(contact, numberIndex);
        }

        public void StartRecord()
        {
            StartRecordVideo();
        }

        public void PauseRecord()
        {
            PauseRecordVideo();
        }

        public void StopRecord()
        {
            StopRecordVideo();
        }
    }
}
