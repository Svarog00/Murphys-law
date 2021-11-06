using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public event Action OnDeath;

    private CharacterMovement _charMovement;

    void Start()
    {
        _charMovement = GetComponent<CharacterMovement>();
        _charMovement.CanMove = true;
    }

    public void Die()
    {
        _charMovement.CanMove = false;
        OnDeath?.Invoke();
        gameObject.SetActive(false);
    }
}
