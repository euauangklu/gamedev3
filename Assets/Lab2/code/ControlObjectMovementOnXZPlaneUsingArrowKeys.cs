using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlObjectMovementOnXZPlaneUsingArrowKeys : StepMovement
    {
        // Start is called before the first frame update
        // Update is called once per frame
        void Update()
        {
            //GetKey
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                MoveRight();
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                MoveForward();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                MoveBackward();
            }
        }
    }
}
