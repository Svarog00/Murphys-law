using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private CharacterMovement _charMovement;

    // Start is called before the first frame update
    void Start()
    {
        _charMovement = GetComponent<CharacterMovement>();
        _charMovement.CanMove = true;
    }

    public void Die()
    {
        _charMovement.CanMove = false;
        gameObject.SetActive(false);
    }
}
