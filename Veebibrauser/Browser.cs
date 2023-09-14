using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veebibrauser
{
    public class Browser
    {
        private Stack<string> _back = new Stack<string>();
        private Stack<string> _forward = new Stack<string>();
        public List<string> _history = new List<string>();

        private string _current;

        public Browser()
        {
            GoTo("google.com");
        }

        public void GoTo(string url)
        {
            _back.Push(_current);
            _current = url;
            _forward.Clear();
            _history.Add(url);
        }

        public void Back()
        {
            if (_back.Count > 0)
            {
                _forward.Push(_current);
                _current = _back.Pop();
                _history.Add(_current);
            }
        }

        public void Forward()
        {
            if (_forward.Count > 0)
            {
                _back.Push(_current);
                _current = _forward.Pop();
                _history.Add(_current);
            }
        }

        public string Current()
        {
            return _current;
        }

        public List<string> History()
        {
            return _history;
        }
    }
}
