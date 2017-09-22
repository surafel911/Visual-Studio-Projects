namespace Library
{
    public interface INewSubTaskModel
    {
        SubTask NewSubTask { get; }
        string Title { set; }
        string Description { set; }
    }
}
