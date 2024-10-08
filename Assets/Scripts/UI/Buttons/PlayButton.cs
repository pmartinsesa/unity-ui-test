using UnityEngine;

namespace Assets.Scripts.UI.Buttons
{
    public class PlayButton : MonoBehaviour
    {
        public ParticleSystem particleSystem;

        public void OnClick()
        {
            particleSystem.Play();
        }
    }
}
