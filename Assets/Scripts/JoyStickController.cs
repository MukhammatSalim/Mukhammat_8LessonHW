using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Joystickcontroller : MonoBehaviour
{
    public Image _InnerCirclie;
    public float _moveSpeed;
    [SerializeField] private Vector2 IC_original_pos;
    private Vector3 mousePos;

    private void Start()
    {
      
    }

    private void Update()
    {
        mousePos = Input.mousePosition;
        
    }

    private void OnMouseDown()
    {
        _InnerCirclie.transform.position = mousePos; 
    }

    private void OnMouseUp()
    {
        
    }
}
