using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    public class Button
    {
        private string label;

        public delegate void ClickHandler(Button source, int x, int y);

        public event ClickHandler OnButtonClick;

        public Button(string label)
        {
            this.label = label;
        }

        public void Clicked()
        {
            Random random = new Random();

            int x = random.Next(1, 100);
            int y = random.Next(1, 50);

            if (OnButtonClick != null)
            {
                OnButtonClick(this, x, y);
            }
        }
    }
}
