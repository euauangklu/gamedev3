using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using GameDev3Library.InteractionSystem;

public class InteractableObjectWithTimer : MonoBehaviour, IInteractable, IActorEnterExitHandler
{
    [SerializeField] protected TextMeshProUGUI m_TextInfoEToInteract;
    [SerializeField] protected float m_TimerDuration = 5;
    [SerializeField] protected Slider m_SliderTimer;
    private bool _IsTimerStart = false;
    private float _StartTimeStamp;
    private float _EndTimeStamp;
    private float _SliderValue;

    public void ActorEnter(GameObject actor)
    {
        m_TextInfoEToInteract.gameObject.SetActive(true);
    }

    public void ActorExit(GameObject actor)
    {
        m_TextInfoEToInteract.gameObject.SetActive(false);
    }

    public void Interact(GameObject actor)
    {
        //Start the timer
        StartTimer();
    }

    private void StartTimer()
    {
        //Check if the timer is already running
        if (_IsTimerStart) return;

        _IsTimerStart = true;
        _StartTimeStamp = Time.time;
        _EndTimeStamp = Time.time + m_TimerDuration;
        _SliderValue = 0;
    }

    private void Update()
    {
        if (!_IsTimerStart) return;

        _SliderValue = ((Time.time - _StartTimeStamp) / m_TimerDuration) * m_SliderTimer.maxValue;
        m_SliderTimer.value = _SliderValue;

        if (Time.time >= _EndTimeStamp)
        {
            _IsTimerStart = false;
        }
    }
}
