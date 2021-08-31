using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataEditor.myClass
{
    public class TextEditor
    {
        public TextEditor(string path)
        {
            _path = path;
        }

        private string _path { get; set; }

        public void append(string text)
        {
            using (StreamWriter JsonText = new StreamWriter(_path, true))
            {
                JsonText.Flush();
                JsonText.Write("");
                JsonText.Write(text);
                JsonText.Close();
            }
        }
        public void Override(string text)
        {
            using (StreamWriter JsonText = new StreamWriter(_path, false))
            {
                JsonText.Flush();
                JsonText.Write("");
                JsonText.Write(text);
                JsonText.Close();
            }
        }
        public string Reader()
        {
            string Jsonstring = null;
            using (StreamReader Text = new StreamReader(_path, true))
            {

                Jsonstring = Text.ReadToEnd();
                Text.Close();

            }
            return Jsonstring;
        }

    }
}
