using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMovement : MonoBehaviour
{
    private bool _canMove;
    private Rigidbody2D _rb2;

    [SerializeField] private float _movementSpeed;
    private Vector2 _direction = Vector2.right;

    public bool CanMove
    {
        get => _canMove;
        set => _canMove = value;
    }

    private void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(_canMove)
        {
            _rb2.MovePosition(_rb2.position + _direction * _movementSpeed * Time.deltaTime);
        }
    }
}
