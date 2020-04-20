using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventHandler
{
    class MyApplication
    {
        public Button openButton;
        public Button saveButton;
        private string fileName;

        public MyApplication()
        {
            this.openButton = new Button("Open File");
            this.saveButton = new Button("Save File");

            this.openButton.OnButtonClick += this.OpenButtonClicked;
            this.saveButton.OnButtonClick += this.SaveButtonClicked;
        }

        private void OpenButtonClicked(Button source, int x, int y)
        {
            Console.WriteLine("Open Dialog to Select A File");
            this.fileName = "File" + x + "_" + y + ".txt";
            Console.WriteLine("Openning File: " + this.fileName);
        }

        private void SaveButtonClicked(Button source, int x, int y)
        {
            if (this.fileName == null)
            {
                Console.WriteLine("No file saved");
                return;
            }
            Console.WriteLine("Saved file: " + this.fileName);
        }

    }

}
