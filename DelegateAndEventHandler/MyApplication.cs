using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    class MyApplication
    {
        private Button openButton;
        private Button saveButton;
        private string fileName;

        public MyApplication()
        {
            this.openButton = new Button("Open File");
            this.saveButton = new Button("Save File");

            this.openButton.OnButtonClick += this.OpenButtonClicked;
            this.saveButton.OnButtonClick += this.SaveButtonClicked;
        }

        private void OpenButtonClicked(Button source,int x,int y)
        {
            Console.WriteLine("Open Dialog to Select A File")
        }

    }
}
