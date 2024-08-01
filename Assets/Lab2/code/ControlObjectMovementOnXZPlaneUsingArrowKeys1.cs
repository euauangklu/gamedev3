using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlObjectMovementOnXZPlaneUsingArrowKeys1 : StepMovement
    {
        // Start is called before the first frame update
        void Update()
        {
            Keyboard keyboard = Keyboard.current;

            //GetKey
            if (keyboard[Key.LeftArrow].isPressed)
            {
                MoveLeft();
            }
            else if (keyboard[Key.RightArrow].isPressed)
            {
                MoveRight();
            }
            else if (keyboard[Key.UpArrow].isPressed)
            {
                MoveForward();
            }
            else if (keyboard[Key.DownArrow].isPressed)
            {
                MoveBackward();
            }
        }
    }
}
