using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] Button newGame;
    [SerializeField] Button exit;

    void Start()
    {
        newGame.onClick.AddListener(StartNewGame);
        exit.onClick.AddListener(ExitGame);
    }
    private  void StartNewGame()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.Level01);
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}
