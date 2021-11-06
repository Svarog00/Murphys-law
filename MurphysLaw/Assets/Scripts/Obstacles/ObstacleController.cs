using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ObstacleController : MonoBehaviour
{
    private ObstacleModel _obstacleModel;
    private Player _player;
    private Animator _animator;

    [SerializeField] private ToolTypes _neededTool;
    [SerializeField] private UI_DeathScreen _DeathScreen;

    public ObstacleModel Model => _obstacleModel;

    // Start is called before the first frame update
    void Awake()
    {
        _player = FindObjectOfType<Player>();
        _obstacleModel = new ObstacleModel(_neededTool);
        _animator = GetComponent<Animator>();
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
            _animator.SetTrigger("Death");
        }
    }

    private void ActivateDeathScreen()
    {
        _DeathScreen.Activate();
    }
}