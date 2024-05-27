using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemontoDesignPattern
{
    internal class TextEditorMemento
    {
        public string Text { get; set; }
        public TextEditorMemento(string text) => Text = text;
        public TextEditorMemento() => Text = string.Empty;

    }
}
