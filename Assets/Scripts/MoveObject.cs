using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 6f;

    private void Update()
    {
        int del = ScoreManager.Instance.GetScore();
        if (del > 0)
        {
            speed = speed + 0.01f / del;
        }
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
