namespace Library
{
    public class SubTask
    {
        private string _title;
        private string _description;
        private bool _completed;

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

        public SubTask()
        { }

        public SubTask(string title, string description)
        {
            _title = title;
            _description = description;
            _completed = false;
        }
    }
}
