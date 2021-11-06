using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ObstacleView : MonoBehaviour
{
    private ObstacleController _obstacleModel;
    private Animator _animator;

    void Start()
    {
        _obstacleModel = GetComponent<ObstacleController>();
        _obstacleModel.Model.OnDeactivateEventHandler += OnDeactivate;
        _animator = GetComponent<Animator>();
    }

    private void OnDeactivate(object sender, System.EventArgs e)
    {
        //TODO: Switch animation state
        _animator.SetBool("Deactivated", true);
        _obstacleModel.Model.OnDeactivateEventHandler -= OnDeactivate;
    }
}
