using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class TitleBase : MonoBehaviour
    {
        private TextMeshProUGUI textMesh;
        private string _title;

        private void Awake()
        {
            textMesh = gameObject.GetComponent<TextMeshProUGUI>();
            _title = textMesh.text;
        }

        private void OnEnable()
        {
            StartCoroutine(ShowText());
        }

        private IEnumerator ShowText()
        {
            textMesh.text = string.Empty;
            foreach (char c in _title.ToCharArray())
            {
                yield return new WaitForSeconds(.2f);
                textMesh.text += c;
            }
        }
    }
}
