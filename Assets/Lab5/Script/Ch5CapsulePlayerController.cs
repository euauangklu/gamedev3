using UnityEngine;
using GameDev3Library;

namespace Euaungkul.GameDev3.Chapter1
{
    public class Ch5CapsulePlayerController : GameDev3Library.PlayerSystem.CapsulePlayerControllerWithKeyboard
    {
        public override void MoveForward()
        {
            transform.Translate(transform.forward*m_DirectionalSpeed*Time.deltaTime,Space.World);
        }
        public override void MoveForwardSprint()
        {
            transform.Translate(transform.forward*m_DirectionalSprintSpeed*Time.deltaTime,Space.World);
        }

        public override void MoveBackward()
        {
            //move backward speed is less than normal speed by 60%
            transform.Translate(-transform.forward*(m_DirectionalSpeed*0.4f)*Time.deltaTime,Space.World);
        }

        public override void TurnLeft()
        {
            transform.Rotate(transform.up,-m_RotationSpeed*Time.deltaTime,Space.Self);
        }

        public override void TurnRight()
        {
            transform.Rotate(transform.up,m_RotationSpeed*Time.deltaTime,Space.Self);
        }
    }
}