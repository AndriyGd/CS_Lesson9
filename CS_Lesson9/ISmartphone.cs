using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson9
{
    interface ISmartphone
    {
        void Call(Contact contact, int numberIndex);
        void StartRecord();
        void PauseRecord();
        void StopRecord();
    }
}
