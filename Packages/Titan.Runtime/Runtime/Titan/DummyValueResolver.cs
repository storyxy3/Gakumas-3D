namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Titan;
    using global::UnityEngine.Playables;

    public class DummyValueResolver : IValueResolver
    {
        private readonly PlayableDirector _director;
        public DummyValueResolver(PlayableDirector director)
        {
        }

        public void OnWillCreateTween()
        {
        }

        public bool TryGetValue<T>(string id, out T value)
        {
            throw null;
        }

        public Value Evaluate(string exp)
        {
            return null;
        }

        public IDisposable ParametersOverriddenScope(IEnumerable<KeyValuePair<string, object>> parameters)
        {
            return null;
        }
    }
}
