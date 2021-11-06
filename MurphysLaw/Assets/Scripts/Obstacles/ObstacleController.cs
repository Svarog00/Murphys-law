using System.Collections;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private ObstacleModel _obstacleModel;
    private Player _player;

    [SerializeField] private ToolTypes _neededTool;

    public ObstacleModel Model => _obstacleModel;

    // Start is called before the first frame update
    void Awake()
    {
        _player = FindObjectOfType<Player>();
        _obstacleModel = new ObstacleModel(_neededTool);
    }

    private void OnMouseUp()
    {
        if (_neededTool == _player.CurTool.Type)
        {
            _obstacleModel.Deactivate();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_obstacleModel.Active && collision.gameObject.GetComponent<Character>())
        {
            Character character = collision.gameObject.GetComponent<Character>();
            character.Die();
        }
    }
}