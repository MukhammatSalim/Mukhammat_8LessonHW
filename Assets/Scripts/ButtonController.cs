using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator _animator;
    private float speedvalue;
    
    public void SpeedChange(float ChangeValue)
    {
        _animator.SetFloat("Velocity", ChangeValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
