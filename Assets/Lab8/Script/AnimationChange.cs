using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Slider Direction;
    [SerializeField]private Slider Speed;
    [SerializeField]private Animator _animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _animator.SetFloat("Direction",Direction.value);
        _animator.SetFloat("Speed",Speed.value);
    }
}
