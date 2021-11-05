using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleView : MonoBehaviour
{
    private ObstacleModel _obstacleModel;
    private Player _player;
    [SerializeField] private ToolTypes _neededTool;

    // Start is called before the first frame update
    void Start()
    {
        _obstacleModel = new ObstacleModel(_neededTool);
        _obstacleModel.OnDeactivateEventHandler += OnDeactivate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(_neededTool == _player.CurTool.Type)
        {
            _obstacleModel.Deactivate();
        }
    }

    private void OnDeactivate(object sender, System.EventArgs e)
    {

    }
}
