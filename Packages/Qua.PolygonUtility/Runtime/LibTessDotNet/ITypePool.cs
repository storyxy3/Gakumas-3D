namespace LibTessDotNet
{
    internal interface ITypePool
    {
        object Get();
        void Return(object obj);
    }
}
