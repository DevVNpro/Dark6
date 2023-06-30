using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISetting : MonoBehaviour
{
    [SerializeField] protected Button back;
    [SerializeField] protected Button exitGame;

    [SerializeField] protected GameObject game;
    private void Start()
    {
        back.onClick.AddListener(CloseSetting);
        exitGame.onClick.AddListener(ExitGame);
    }

    protected virtual void CloseSetting()
    {
       transform.gameObject.SetActive(false);
        game.SetActive(true);
    }
    private void ExitGame()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.MainMenu);
    }
}
