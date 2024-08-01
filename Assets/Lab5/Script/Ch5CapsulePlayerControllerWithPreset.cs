using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class Ch5CapsulePlayerControllerWithPreset : CapsulePlayerControllerWithPreset
    {
        // Start is called before the first frame update
        public override void MoveForward()
        {
            transform.Translate(transform.forward * m_Preset.DirectionalSpeed * Time.deltaTime, Space.World);
        }

        public override void MoveForwardSprint()
        {
            transform.Translate(transform.forward * m_Preset.DirectionalSprintSpeed * Time.deltaTime, Space.World);
        }

        public override void MoveBackward()
        {
            //move backward speed is less than normal speed by 60%
            transform.Translate(-transform.forward * (m_Preset.DirectionalSpeed * 0.4f) * Time.deltaTime, Space.World);
        }

        public override void TurnLeft()
        {
            transform.Rotate(transform.up, -m_Preset.RotationSpeed * Time.deltaTime, Space.Self);
        }

        public override void TurnRight()
        {
            transform.Rotate(transform.up, m_Preset.RotationSpeed * Time.deltaTime, Space.Self);
        }
    }

}

