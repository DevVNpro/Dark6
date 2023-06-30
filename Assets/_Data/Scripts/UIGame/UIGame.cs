using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{
    [SerializeField] protected Button setting;
    [SerializeField] protected Canvas canvasSetting;
    [SerializeField] protected GameObject game;
    //uiendgame
    [SerializeField] protected GameObject UIEndGame;

    private void Start()
    {
        setting.onClick.AddListener(OnClickSetting);
    }

    protected virtual void OnClickSetting()
    {
        canvasSetting.gameObject.SetActive(true);
        game.SetActive(false);
    }
    private void OnEnable()
    {
        // Đăng ký lắng nghe sự kiện Player chết
        GameManager.PlayerDied += ShowEndGameUI;
    }

    private void OnDisable()
    {
        // Hủy đăng ký lắng nghe sự kiện Player chết
        GameManager.PlayerDied -= ShowEndGameUI;
    }

    private void ShowEndGameUI()
    {
        // Hiển thị UI End Game
        UIEndGame.SetActive(true);
    }

}
