using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Extras
{
    [CustomEditor(typeof(ListsExtras))]
    public class ListsExtrasEditor : Editor
    {
        [MenuItem("ui-project/create-random-list")]
        public static void CreateRandomList()
        {
            new GameObject("list", typeof(ListsExtras));
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            var myTarget = (ListsExtras)target;
            if (GUILayout.Button("Print lista randomizada"))
            {
                myTarget.PrintRandomList();
            }
        }
    }
}
