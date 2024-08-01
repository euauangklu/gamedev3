using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlByInputManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public float m_MovementScale = 0.5f;

        // Update is called once per frame
        void Update()
        {
            float hMovement = Input.GetAxis("Horizontal") * m_MovementScale;
            float vMovement = Input.GetAxis("Vertical") * m_MovementScale;

            this.transform.Translate(new Vector3(hMovement, vMovement, 0));

            if (Input.GetButtonDown("Fire1"))
            {
                ShootABulletInForwardDirection(Vector3.zero);
            }

            if (Input.GetButtonDown("Fire2"))
            {
                ShootABulletInForwardDirection(new Vector3(0, 1, 0), PrimitiveType.Capsule, 1.5f);
            }
        }

        private void ShootABulletInForwardDirection(Vector3 forceModifier,
            PrimitiveType type = PrimitiveType.Sphere,
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
