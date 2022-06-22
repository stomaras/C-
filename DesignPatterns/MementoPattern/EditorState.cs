using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class EditorState
    {
        
        private string Content { get; set; }

        public EditorState(string content)
        {
            Content = content;
        }


        public EditorState createState()
        {
            return new EditorState(Content);
        }

        public void restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}
