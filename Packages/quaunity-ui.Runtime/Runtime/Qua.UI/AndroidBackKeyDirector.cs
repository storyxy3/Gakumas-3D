namespace Qua.UI
{
    using global::Qua.UI;
    using global::UnityEngine;

    public class AndroidBackKeyDirector : MonoBehaviour
    {
        private void Update()
        {
        }

        protected virtual IAndroidBackKeyScenePresenter GetCurrentScenePresenter()
        {
            return null;
        }

        public virtual void OnBackKeyClicked()
        {
        }

        public AndroidBackKeyDirector()
        {
        }
    }
}
