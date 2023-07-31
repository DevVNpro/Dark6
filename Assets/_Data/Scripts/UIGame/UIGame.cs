using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGame : MonoBehaviour
{

    [SerializeField] protected Button setting;
    [SerializeField] protected Canvas canvasSetting;
    [SerializeField] protected GameObject player;
    [SerializeField] protected GameObject playerClickAttak;

    protected CapsuleCollider2D colliderPlayer;

    private void Start()
    {

        setting.onClick.AddListener(OnClickSetting);
        colliderPlayer=player.GetComponent<CapsuleCollider2D>();
    }

    protected virtual void OnClickSetting()
    {
        canvasSetting.gameObject.SetActive(true);
        colliderPlayer.enabled = false;
        playerClickAttak.SetActive(false);
    }

}
