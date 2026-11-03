namespace Campus.Common.Titan
{
    using global::DG.Tweening;
    using global::Titan;

    public class CampusTitanSettings : TitanSettings
    {
        protected override EaseFunction GetEaseFunction(string easeId, float parameter1, float parameter2)
        {
            return null;
        }

        protected override double GetCustomEaseDuration(string easeId, float parameter1, float parameter2)
        {
            return default(double);
        }

        public CampusTitanSettings()
        {
        }
    }
}
