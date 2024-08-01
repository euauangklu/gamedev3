using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlObjectUsingMouse : MonoBehaviour
    {
        // Start is called before the first frame update
        private Vector3 m_MousePreviousPosition;

        public float m_MouseDeltaVectorScaling = 0.5f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Vector3 mouseCurrentPos = Input.mousePosition;
            Vector3 mouseDeltaVector = Vector3.zero;
            mouseDeltaVector = (mouseCurrentPos - m_MousePreviousPosition).normalized;

            if (Input.GetMouseButton(0))
            {
                this.transform.Translate(mouseDeltaVector * m_MouseDeltaVectorScaling, Space.World);
            }

            this.transform.Translate(0, 0, Input.mouseScrollDelta.y * m_MouseDeltaVectorScaling, Space.World);

            m_MousePreviousPosition = mouseCurrentPos;
        }
    }
}
