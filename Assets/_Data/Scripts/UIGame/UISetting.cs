using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISetting : MonoBehaviour
{
    [SerializeField] protected Button back;
    [SerializeField] protected Button exitGame;

    [SerializeField] protected GameObject player;
    [SerializeField] protected GameObject playerClickAttak;

    protected CapsuleCollider2D colliderPlayer;
    private void Start()
    {
        back.onClick.AddListener(CloseSetting);
        exitGame.onClick.AddListener(ExitGame);
        colliderPlayer= player.GetComponent<CapsuleCollider2D>();

    }

    protected virtual void CloseSetting()
    {
       gameObject.SetActive(false);
        colliderPlayer.enabled = true;
        playerClickAttak.SetActive(true);
    }
    private void ExitGame()
    {
        ScenesManager.Instance.LoadScene(ScenesManager.Scene.MainMenu);
    }
}
