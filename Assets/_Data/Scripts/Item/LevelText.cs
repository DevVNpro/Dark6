using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : RootMonoBehaviour
{
    [SerializeField] protected Text text;
    private void Update()
    {
        this.SetLevelText();
    }
    public virtual void SetLevelText()
    {
        if (GameManager.Instance.level == 0) return;
        text.text = "Level " + GameManager.Instance.level;
    }
}
