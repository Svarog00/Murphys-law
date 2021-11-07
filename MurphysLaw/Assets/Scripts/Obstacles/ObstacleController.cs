using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ObstacleController : MonoBehaviour
{
    private ObstacleModel _obstacleModel;
    private Player _player;
    private Animator _animator;
    private AudioSource _audioSource;
    private float _distance;

    [SerializeField] private ToolTypes _neededTool;
    [SerializeField] private UI_DeathScreen _deathScreen;
    [SerializeField] private string _deactivationSoundName;

    public ObstacleModel Model => _obstacleModel;

    // Start is called before the first frame update
    void Awake()
    {
        _player = FindObjectOfType<Player>();
        _obstacleModel = new ObstacleModel(_neededTool);
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _deathScreen.OnCharDeath += OnCharDeath;
    }

    private void OnCharDeath()
    {
        StopSound();
    }

    private void Update()
    {
        _distance = EstimateDistance();
        _audioSource.volume = 1 / (_distance * 10);
    }

    private void OnMouseUp()
    {
        if (_neededTool == _player.CurTool.Type)
        {
            _obstacleModel.Deactivate();
            StopSound();
            FindObjectOfType<AudioManager>().Play(_deactivationSoundName);
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
        _deathScreen.Activate();
    }

    private float EstimateDistance()
    {
        Vector2 vectorToPlayer = transform.position - _player.gameObject.transform.position; //направленный вектор к игроку / a vector to the player
        float distanceToPlayer = vectorToPlayer.magnitude; //длина вектора / lenght of the vector
        return distanceToPlayer;
    }

    private void StopSound()
    {
        _audioSource.Pause();
    }
}