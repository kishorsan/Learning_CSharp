public class TodoItem
{
    public required String Title { get; set; }
    public bool IsDone { get; set; }

    public override string ToString()
    {
        return Title;
    }
}