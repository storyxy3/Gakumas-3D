namespace Uguiss
{
    using global::Uguiss;

    public class SearchFilter
    {
        private class ResultRange
        {
        }

        public class Result
        {
        }

        public interface ISearchTarget
        {
        }

        public class Result<T>
            where T : ISearchTarget
        {
        }
    }
}
