using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameDev3Library.InteractionSystem;
using UnityEngine.InputSystem;

namespace Euaungkul.GameDev3.Chapter1
{
    public class Ch5CapsulePlayerControllerWithActorTrigger : Ch5CapsulePlayerControllerWithPreset
    {
        [SerializeField] protected ActorTriggerHandler m_ActorTriggerHandler;

        protected override void Update()
        {
            base.Update();

            Keyboard keyboard = Keyboard.current;

            if (keyboard[m_Preset.InteractionKey].wasPressedThisFrame)
            {
                PerformInteraction();
            }
        }

        protected virtual void PerformInteraction()
        {
            var interactable = m_ActorTriggerHandler.GetInteractable();

            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }
}