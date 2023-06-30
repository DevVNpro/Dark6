using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeartBar : HeartBar
{
    public Gradient gradient;
    public Image image;
    protected override void UpdateHpBar()
    {
        base.UpdateHpBar();
        image.color = gradient.Evaluate(slider.normalizedValue);
    }
}
