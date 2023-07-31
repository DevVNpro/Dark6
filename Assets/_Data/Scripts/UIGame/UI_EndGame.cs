using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_EndGame : MonoBehaviour
{
    [SerializeField] protected Button backMenu;
    [SerializeField] protected GameObject canvasEndMenu;

    private void Start()
    {
        backMenu.onClick.AddListener(BackMenu);
    }
    void Update()
    {
        this.SetUIEndGame();

    }

    protected virtual void SetUIEndGame()
    {
        if(EnemySpawner.Instance.CountDespawnPrefabs == 21)
        {
            canvasEndMenu.SetActive(true);
        }
     
    }
    protected virtual void BackMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
    }

    private void OnEnable()
    {
        GameManager.PlayerDied += ShowEndGameUI;
    }

    private void OnDisable()
    {
        GameManager.PlayerDied -= ShowEndGameUI;
    }

    private void ShowEndGameUI()
    {
        canvasEndMenu.SetActive(true);
    }

}
