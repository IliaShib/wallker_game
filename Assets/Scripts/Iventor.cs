using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Iventor : MonoBehaviour
{
    public UnityEvent onMouseClicked;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onMouseClicked?.Invoke();
        }
    }
}
