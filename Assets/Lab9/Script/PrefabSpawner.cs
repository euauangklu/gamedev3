using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    [CreateAssetMenu(menuName = "GameDev3/Util/PrefabSpawner")]
    public class PrefabSpawner : ScriptableObject
    {
        // Start is called before the first frame update
        public GameObject m_Prefab;

        public void SpawnPrefab(GameObject parent)
        {
            var go = Instantiate(m_Prefab);
            go.transform.position = parent.transform.position;
        }
    }
}
