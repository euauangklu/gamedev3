using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using GameDev3Library.InteractionSystem;

[RequireComponent(typeof(Rigidbody))]
public class Pushable : MonoBehaviour, IInteractable, IActorEnterExitHandler
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
        m_rigidBody.AddForce(actor.transform.forward * m_Power, ForceMode.Impulse);
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
