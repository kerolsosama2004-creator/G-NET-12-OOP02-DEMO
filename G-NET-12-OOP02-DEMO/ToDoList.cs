using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class ToDoList
    {
        private string[] _Tasks;
        private int _Count;
        public ToDoList(int Capacity)
        {
            _Tasks = new string[Capacity];
        }
        //----------------------
        public int Count => _Count;
        //--------------------
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < _Tasks.Length)
                {
                    return _Tasks[index];

                }
                return "No Task Found";
            }
            set
            {
                if (index >= 0 && index < _Tasks.Length)
                {
                    if (_Tasks[index] == null)
                    // If The Task Is Being Added For The First Time
                    {
                        _Count++;
                    }
                    _Tasks[index] = value;
                }
            }

        }

    }
}
