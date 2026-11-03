namespace Titan
{
    using global::DG.Tweening;
    using global::Titan;

    [TitanTrackBindingType(typeof(TextMeshProCharMeshModifier))]
    public abstract class TextMeshProCharTrackBase<TClipAsset, TValue, TParameter> : TweenerTrackBase<TClipAsset, TextMeshProCharMeshModifier, TValue, TParameter> where TClipAsset : TextMeshProCharClipBase<TValue, TParameter> where TParameter : ParameterBase<TValue>, new()
    {
        protected override Tween GetTween(TextMeshProCharMeshModifier component, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected override Tween GetTween(TextMeshProCharMeshModifier component, TValue endValue, TClipAsset clipAsset, float duration)
        {
            return null;
        }

        protected abstract Tween CharTween(TextMeshProCharMeshModifier component, int index, TValue endValue, TClipAsset clipAsset, float duration);
        protected override void SetValue(TValue value, TextMeshProCharMeshModifier component)
        {
        }

        protected override TValue GetValue(TextMeshProCharMeshModifier component)
        {
            return default(TValue);
        }

        protected abstract void SetCharValue(TextMeshProCharMeshModifier component, int index, TValue value);
        protected abstract TValue GetCharValue(TextMeshProCharMeshModifier component, int index);
        protected TextMeshProCharTrackBase()
        {
        }
    }
}
