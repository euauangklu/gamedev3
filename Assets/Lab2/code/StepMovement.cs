using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public abstract class StepMovement : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] protected float movementStep = 1.0f;

        public virtual void MoveUp()
        {
            transform.Translate(0, movementStep, 0);
        }

        public virtual void MoveDown()
        {
            transform.Translate(0, -movementStep, 0);
        }

        public virtual void MoveLeft()
        {
            transform.Translate(-movementStep, 0, 0);
        }

        public virtual void MoveRight()
        {
            transform.Translate(movementStep, 0, 0);
        }

        public virtual void MoveForward()
        {
            transform.Translate(0, 0, movementStep);
        }

        public virtual void MoveBackward()
        {
            transform.Translate(0, 0, -movementStep);
        }
    }
}
