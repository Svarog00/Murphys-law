using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotkeySystemPresenter : MonoBehaviour
{
    private HotkeySystem _hotkeySystem;
    [SerializeField] private Player _player;
    [SerializeField] private ToolSet _tools;

    // Start is called before the first frame update
    void Start()
    {
        _hotkeySystem = new HotkeySystem(_player, _tools.Set);
    }

    // Update is called once per frame
    void Update()
    {
        _hotkeySystem.HandleInput();
    }

    public HotkeySystem GetHotkeySystem()
    {
        return _hotkeySystem;
    }

    public List<Tool> GetToolList()
    {
        return _tools.Set;
    }
}
