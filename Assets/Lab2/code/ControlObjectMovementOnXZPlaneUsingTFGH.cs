using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlObjectMovementOnXZPlaneUsingTFGH : StepMovement
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                MoveRight();
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                MoveForward();
            }
            else if (Input.GetKeyDown(KeyCode.G))
            {
                MoveBackward();
            }

            //Reverse the movement when release a key
            if (Input.GetKeyUp(KeyCode.F))
            {
                MoveRight();
            }
            else if (Input.GetKeyUp(KeyCode.H))
            {
                MoveLeft();
            }
            else if (Input.GetKeyUp(KeyCode.T))
            {
                MoveBackward();
            }
            else if (Input.GetKeyUp(KeyCode.G))
            {
                MoveForward();

            }
        }
    }
}