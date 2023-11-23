using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStickController : MonoBehaviour
{
    public Image _innerCircle;
    Vector3 destination;
    [SerializeField]
    float moveSpeed = 80;

    void Start()
    {
        destination = _innerCircle.transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destination = Input.mousePosition;
        }

        _innerCircle.transform.position = Vector3.MoveTowards(transform.position, destination, moveSpeed * Time.deltaTime);
    }
}
