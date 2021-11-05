using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class HotkeySystemPresenter : MonoBehaviour
{
    public event Action<int> OnToolChangedPresent;

    private HotkeySystem _hotkeySystem;
    [SerializeField] private Player _player;
    [SerializeField] private ToolSet _tools;

    // Start is called before the first frame update
    private void Awake()
    {
        _hotkeySystem = new HotkeySystem(_player, _tools.Set);
        _hotkeySystem.OnToolChangedEventHandler += OnToolChanged;
    }

    private void OnToolChanged(int index)
    {
        OnToolChangedPresent?.Invoke(index);
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
