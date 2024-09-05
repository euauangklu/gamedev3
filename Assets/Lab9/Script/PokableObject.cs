using System;
using GameDev3Library.InteractionSystem;
using TMPro;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class PokableObject : MonoBehaviour, IInteractable, IActorEnterExitHandler
    {
        [SerializeField] protected TextMeshProUGUI m_InteractionTxt;
        [SerializeField] protected float m_Power = 10;
        private Rigidbody m_rigidBody;

        private void Start()
        {
            m_rigidBody = GetComponent<Rigidbody>();
        }

        public void Interact(GameObject actor)
        {
            m_rigidBody.AddForce(Vector3.up*m_Power,ForceMode.Impulse);
        }

        public void ActorEnter(GameObject actor)
        {
            m_InteractionTxt.gameObject.SetActive(true);
        }

        public void ActorExit(GameObject actor)
        {
            m_InteractionTxt.gameObject.SetActive(false);
        }
    }
}