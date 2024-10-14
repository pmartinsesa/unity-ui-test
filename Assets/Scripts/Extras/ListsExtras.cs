using Assets.Scripts.Main;
using NaughtyAttributes.Test;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Extras
{
    public class ListsExtras : MonoBehaviour
    {

        [SerializeField] public List<string> strings = new List<string>();

        public void PrintRandomList()
        {
            var stringsRandomized = strings.RandomizeList(4);
            stringsRandomized.ToList().ForEach(s => { Debug.Log(s); });
        }
    }
}
