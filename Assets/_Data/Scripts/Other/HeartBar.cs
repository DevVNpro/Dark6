    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HeartBar : RootMonoBehaviour
{
    [SerializeField] protected Slider slider;
    [SerializeField] protected DamageReceiver damageReceiver;
 
    protected virtual  void FixedUpdate()
    {
        this.UpdateHpBar();
    }
    protected virtual void UpdateHpBar() {
        if (this.slider == null) return;
        IHpBarInterface hpBarInterface = damageReceiver.GetComponent<IHpBarInterface>();
        if (hpBarInterface == null) return;
        this.slider.value = hpBarInterface.Hp();
    
    }
    
    
}
