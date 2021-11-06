using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI_DeathScreen : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private GameObject _visual;
    [SerializeField] private GameObject _toolSetUI;

    private void Start()
    {
        _visual.SetActive(false);
    }

    public void Activate()
    {
        _visual.SetActive(true);
        _toolSetUI.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Again()
    {
        SceneManager.LoadScene(0);
    }
}