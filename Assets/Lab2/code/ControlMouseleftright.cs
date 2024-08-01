using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ControlMouseleftright : StepMovement
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                MoveLeft();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                MoveRight();
            }
            if (Input.GetMouseButtonDown(1))
            {
                MoveRight();
            }
            else if (Input.GetMouseButtonUp(1))
            {
                MoveLeft();
            }
        }
    }
}
