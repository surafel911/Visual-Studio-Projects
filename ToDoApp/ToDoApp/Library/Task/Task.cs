using System.Collections.Generic;

namespace Library
{
    public class Task
    {
        private string _title;
        private string _description;
        private bool _completed;
        private List<SubTask> _subTasks;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        public List<SubTask> SubTasks
        {
            get { return _subTasks; }
            set { _subTasks = value; }
        }

        public Task()
        { }

        public Task(string title, string description)
        {
            _title = title;
            _description = description;
            _completed = false;
            _subTasks = new List<SubTask>();
        }
    }
}
