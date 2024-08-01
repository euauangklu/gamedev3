using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Euaungkul.GameDev3.Chapter1
{
    public class ScriptLifeCycleStudy : MonoBehaviour
    {
        private int m_CallingSequence = 1;

        void Awake()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        // Use this for initialization
        void Start()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void FixedUpdate()
        {

        }

        private void OnEnable()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        void OnDisable()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        void OnDestroy()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        void OnApplicationPause()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }

        void OnApplicationQuit()
        {
            Debug.LogFormat("{0} {1} has been called.", m_CallingSequence++, MethodBase.GetCurrentMethod().Name);
        }
    }
}

