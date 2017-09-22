using Library;

namespace Model
{
    public class NewSubTaskModel : INewSubTaskModel
    {
        private SubTask _subTask;

        public SubTask NewSubTask { get { return _subTask; } }

        public string Title { set { _subTask.Title = value; } }

        public string Description { set { _subTask.Description = value; } }

        public NewSubTaskModel()
        {
            _subTask = new SubTask();
            _subTask.Completed = false;
        }
    }
}
