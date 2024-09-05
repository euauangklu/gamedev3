using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    [CreateAssetMenu(menuName = "GameDev3/Util/ScriptableObjectUtils")]

    public class ScriptableObjectUtils : ScriptableObject
    {
        // Start is called before the first frame update
        public void Destroy(GameObject gameObject)
        {
            Object.Destroy(gameObject);
        }
    }
}
