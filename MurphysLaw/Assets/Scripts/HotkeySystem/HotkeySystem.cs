using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HotkeySystem
{
    public event Action<int> OnToolChangedEventHandler;

    private List<Tool> _tools;
    private Player _player;

    public HotkeySystem(Player player, List<Tool> toolSet)
    {
        _player = player;
        _tools = toolSet;
    }

    // Update is called once per frame
    public void HandleInput()
    {
        int index = 0;
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _player.SetTool(_tools[0]);
            index = 0;
            OnToolChangedEventHandler?.Invoke(index);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _player.SetTool(_tools[1]);
            index = 1;
            OnToolChangedEventHandler?.Invoke(index);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _player.SetTool(_tools[2]);
            index = 2;
            OnToolChangedEventHandler?.Invoke(index);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _player.SetTool(_tools[3]);
            index = 3;
            OnToolChangedEventHandler?.Invoke(index);
        }
    }
}
