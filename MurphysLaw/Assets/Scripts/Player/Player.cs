using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Tool _curTool;

    public Tool CurTool
    {
        get => _curTool;
        private set => _curTool = value;
    }

    public void SetTool(Tool tool)
    {
        _curTool = tool;
        Debug.Log($"Current tool: {_curTool.Type}");
    }
}
