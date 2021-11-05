using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleModel
{
    public event EventHandler OnDeactivateEventHandler;

    private ToolTypes _neededTool;
    private bool _active;

    public ToolTypes NeededTool => _neededTool;
    public bool Active => _active;

    public ObstacleModel(ToolTypes neededTool)
    {
        _neededTool = neededTool;
        _active = true;
    }

    public void Deactivate()
    {
        _active = false;
        OnDeactivateEventHandler?.Invoke(this, EventArgs.Empty);
    }
}
