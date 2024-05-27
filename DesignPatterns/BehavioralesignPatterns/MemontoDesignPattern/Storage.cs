using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemontoDesignPattern
{
    internal class Storage
    {
        private List<TextEditorMemento> Mementos { get; set; } = new();
        public TextEditor TextEditor { get; set; } = new();

        public void Append(string text) => TextEditor.Append(text);
        public void Show() => TextEditor.Show();
        public void Save() => Mementos.Add(TextEditor.Save());

        public void Undo()
        {
            if (Mementos.Count > 0)
            {
                var lastSave = Mementos.Last();
                Mementos.Remove(lastSave);
                TextEditor.Text = lastSave.Text;
            }
            else throw new Exception();
        }
    }
}
