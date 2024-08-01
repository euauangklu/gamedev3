using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlByPlayerInputActions : MonoBehaviour
    {
        // Start is called before the first frame update
        public float m_MovementScale = 0.5f;
        protected float m_CurrentHorizontal;
        protected float m_CurrentVertical;
        protected bool m_IsFire1Held = false;
        protected bool m_IsFire2Held = false;

        public void OnHorizontal(InputValue value)
        {
            m_CurrentHorizontal = value.Get<float>();
        }

        public void OnVertical(InputValue value)
        {
            m_CurrentVertical = value.Get<float>();
        }

        public void OnFire1(InputValue value)
        {
            Debug.Log("Fire1");
            var v = value.Get<float>();
            //Equivalent to KeyDown
            if (value.isPressed)
            {
                ShootABulletInForwardDirection(Vector3.zero);
                //Equivalent to Hold
                if (v > UnityEngine.InputSystem.InputSystem.settings.defaultHoldTime)
                {
                    m_IsFire1Held = true;
                }
            }
            else
            {
                //Equivalent to KeyUp
                ShootABulletInForwardDirection(new Vector3(0, 1, 0),
                    PrimitiveType.Capsule, 1.5f);

                m_IsFire1Held = false;
            }
        }

        public void OnFire2(InputValue value)
        {
            Debug.Log("Fire2");
            var v = value.Get<float>();

            if (value.isPressed)
            {
                //Add SpinMovement component
                var spinMovement = gameObject.AddComponent<SpinMovement>();

                //Equivalent to Hold
                if (v > UnityEngine.InputSystem.InputSystem.settings.defaultHoldTime)
                {
                    m_IsFire2Held = true;
                }
            }
            else
            {
                //Remove SpinMovement component
                var spinMovement = gameObject.GetComponent<SpinMovement>();
                Destroy(spinMovement);

            }

            m_IsFire2Held = false;
        }

        private void Update()
        {
            float hMovement = m_CurrentHorizontal * m_MovementScale;
            float vMovement = m_CurrentVertical * m_MovementScale;

            transform.Translate(new Vector3(hMovement, vMovement, 0));

            if (m_IsFire1Held)
            {
                Debug.Log("Fire1‐Hold");
            }

            if (m_IsFire1Held)
            {
                Debug.Log("Fire2‐Hold");
            }

        }

        private void ShootABulletInForwardDirection(Vector3 forceModifier, PrimitiveType type = PrimitiveType.Sphere,
            float forceMagnitude = 1)
        {
            //Create a new primitive at runtime
            var newGameObject = GameObject.CreatePrimitive(type);
            //Start the newGameObject position with forward*1.5f
            newGameObject.transform.position = transform.position + transform.forward * 1.5f;
            //Add rigidbody to the newly created gameobject
            var rigidbody = newGameObject.AddComponent<Rigidbody>();
            rigidbody.mass = 0.15f;
            //Calculate the shooting direction
            Vector3 shootingDirection = (forceModifier + transform.forward) *
                                        forceMagnitude;
            rigidbody.AddForce(shootingDirection, ForceMode.Impulse);
            //Destroy the new gameobject in 3 sec
            Destroy(newGameObject, 3);
        }

    }
}

 
