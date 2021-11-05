using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Tool _curTool;

    public Tool CurTool => _curTool;

    public void SetTool(Tool tool)
    {
        _curTool = tool;
        Debug.Log($"Current tool: {_curTool.Type}");
    }
}
