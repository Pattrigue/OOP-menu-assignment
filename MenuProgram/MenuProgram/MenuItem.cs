﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProgram
{
    class MenuItem : IMenuItem
    {
        public string Title { get; set; }

        public IMenuItem PrevMenuItem { get; set; }

        public string Content { get; set; }

        public MenuItem(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public virtual void Select()
        {
            DrawContent();
            WaitForBackspace();
        }

        protected void DrawContent()
        {
            //Draw content
            Console.Clear();
            Console.WriteLine(Content);

        }

        private void WaitForBackspace()
        {
            ConsoleKeyInfo _lastPressedKey;
            do
            {
                _lastPressedKey = Console.ReadKey();
            } while (_lastPressedKey.Key != ConsoleKey.Backspace);

            //After enter has been presset, return to prev 
            PrevMenuItem.Select();
        }
    }
}
