using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class CharacterMovement : MonoBehaviour
{
    private bool _canMove;
    private Rigidbody2D _rb2;
    private Animator _animator;

    [SerializeField] private float _movementSpeed;
    private Vector2 _direction = Vector2.right;

    public bool CanMove
    {
        get => _canMove;
        set
        {
            _canMove = value;
            _animator.SetBool("Run", _canMove);
        }
    }

    private void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _animator.SetBool("Run", _canMove);
    }

    private void FixedUpdate()
    {
        Run();
    }

    private void Run()
    {
        if (_canMove)
        {
            _rb2.MovePosition(_rb2.position + _direction * _movementSpeed * Time.deltaTime);
        }
    }
}
