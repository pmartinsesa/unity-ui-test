using NaughtyAttributes;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class UIBase : MonoBehaviour
    {
        [Header("Canvas Ref")]
        public GameObject canvas;

        [Header("Animation Setup")]
        public float startDuration = 0.2f;


        [Button("Show")]
        public void Show()
        {
            StartCoroutine(ShowItems());
        }

        [Button("Hide")]
        public void Hide()
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
        }

        private IEnumerator ShowItems()
        {
            foreach (Transform child in transform)
            {
                yield return new WaitForSeconds(startDuration);
                child.gameObject.SetActive(true);
            }
        }
    }
}
