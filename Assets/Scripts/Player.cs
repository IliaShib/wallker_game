using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] private SpriteRenderer _characterSprite;

    public float _gravity_forse = 50f;
    public float _speed = 5;
    public bool _isRight = false;
    public bool _isLeft = true;

    public void Start()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool("Run", true);
        _animator.SetBool("Fall", false);
    }

    public void Control()
    {
        if( _isRight == false && _isLeft)
        {
            Physics2D.gravity = new Vector2(_gravity_forse, 0);
            _animator.SetBool("Run", true);
            _animator.SetBool("Fall", false);
            _characterSprite.flipY = false;
            _isRight = true;
            _isLeft = false;
        }
        else if (_isLeft == false && _isRight)
        {
            Physics2D.gravity = new Vector2(-_gravity_forse, 0);
            _animator.SetBool("Run", true);
            _animator.SetBool("Fall", false);
            _characterSprite.flipY = true;
            _isRight = false;
            _isLeft = true;
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
