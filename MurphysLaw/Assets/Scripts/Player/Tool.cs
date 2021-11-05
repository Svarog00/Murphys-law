using System.Collections;
using UnityEngine;

public enum ToolTypes
{
    Tape,
    Plank,
    Food,
    Cutter,
}

[CreateAssetMenu(fileName = "Tool", menuName = "Tool", order = 0)]
public class Tool : ScriptableObject
{
    [SerializeField] private Sprite _icon;
    [SerializeField] private ToolTypes _type;

    public ToolTypes Type
    {
        get => _type;
        set => _type = value;
    }

    public Sprite Icon
    {
        get => _icon;
    }
}
