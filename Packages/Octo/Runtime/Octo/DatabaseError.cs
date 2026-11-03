namespace Octo
{
    public interface DatabaseError
    {
        string Name { get; }

        string Code { get; }

        string Message { get; }
    }
}
