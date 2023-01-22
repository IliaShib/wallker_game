using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private SpriteRenderer _characterSprite;

    public float _gravity_forse = 50f;
    public float _speed = 5;

    public void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Physics2D.gravity = new Vector2(_gravity_forse, 0);
            _animator.SetBool("Run", true);
            _animator.SetBool("Fall", false);
            _characterSprite.flipY = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Physics2D.gravity = new Vector2(-_gravity_forse, 0);
            _animator.SetBool("Run", true);
            _animator.SetBool("Fall", false);
            _characterSprite.flipY = true;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-Vector3.left * _speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Danger"))
        {
            GameManager.instance.Lose();
        }
    }
}
