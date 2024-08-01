using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Euaungkul.GameDev3.Chapter1
{
    public class BasicMouseInformation : MonoBehaviour

    {
        public Text m_TextMousePosition;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            m_TextMousePosition.text = Input.mousePosition.ToString();
        }
    }
}