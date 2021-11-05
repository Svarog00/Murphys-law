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

    public bool CanMove => _canMove;

    private void Start()
    {
        _rb2 = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb2.MovePosition(_rb2.position + _direction * _movementSpeed * Time.deltaTime);
    }
}
