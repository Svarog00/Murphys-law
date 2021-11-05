using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotkeySystem
{
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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _player.SetTool(_tools[0]);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _player.SetTool(_tools[1]);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _player.SetTool(_tools[2]);
        }
    }
}
