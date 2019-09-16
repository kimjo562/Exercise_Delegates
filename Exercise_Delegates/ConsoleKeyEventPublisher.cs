using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Delegates
{
    class ConsoleKeyEventPublisher
    {
        public delegate void TKeyPressed(char key);

        // Assign an empty Lamda Function
        private TKeyPressed KeyPressedEvent = (char key) => { Console.WriteLine("List changed event received."); };

        public void Subscribe(TKeyPressed func)
        {
            KeyPressedEvent += func;
        }

        public void Update()
        {
            if (Console.KeyAvailable == true)
            {
                char cKeyInfo = Console.ReadKey(true).KeyChar;
                KeyPressedEvent(cKeyInfo);
            }
        }
    }
}
