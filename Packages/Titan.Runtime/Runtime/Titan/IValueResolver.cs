namespace Titan
{
    using global::System;
    using global::System.Collections.Generic;
    using global::Titan;

    public interface IValueResolver
    {
        void OnWillCreateTween();
        bool TryGetValue<T>(string id, out T value);
        Value Evaluate(string exp);
        IDisposable ParametersOverriddenScope(IEnumerable<KeyValuePair<string, object>> parameters);
    }
}
