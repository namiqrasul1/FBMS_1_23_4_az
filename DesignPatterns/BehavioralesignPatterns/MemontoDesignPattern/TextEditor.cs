using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemontoDesignPattern
{
    internal class TextEditor
    {
        public string Text { get; set; } = string.Empty;

        public void Append(string text) => Text += text;
        public TextEditorMemento Save() => new TextEditorMemento(Text);
        public void Undo(TextEditorMemento memento) => Text = memento.Text;
        public void Show() => Console.WriteLine(Text);
        
    }
}
