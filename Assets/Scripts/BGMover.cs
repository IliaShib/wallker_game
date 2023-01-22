using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMover : MonoBehaviour
{
    public float startY;
    public float endY;

    void Update()
    {
        if (transform.position.y < endY)
        {
            transform.position = new Vector2(transform.position.x, startY);
        }
    }
}
