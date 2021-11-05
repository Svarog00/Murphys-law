using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tool", menuName = "Tool Set", order = 1)]
public class ToolSet : ScriptableObject
{
    public List<Tool> Set;
}
