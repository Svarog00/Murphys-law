using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private ToolSet _toolSet;

    private Tool _curTool;
    private HotkeySystem _hotkeySystem;

    public Tool CurTool
    {
        get => _curTool;
        private set => _curTool = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        _hotkeySystem = new HotkeySystem(this, _toolSet.Set);
    }

    // Update is called once per frame
    void Update()
    {
        _hotkeySystem.HandleInput();
    }

    public void SetTool(Tool tool)
    {
        _curTool = tool;
        Debug.Log($"Current tool: {_curTool.Type}");
    }
}
