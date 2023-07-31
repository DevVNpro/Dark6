using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPoint : RootMonoBehaviour
{
    [SerializeField] protected List<Transform> holders;
   // public List<Transform> Holders => holders;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.AddHolder();
    }
    protected virtual void AddHolder()
    {
        Transform holder = transform.Find("Holder");
        if (holders.Count > 0) return;
        foreach(Transform point in holder)
        {
            holders.Add(point);
        }
    }
    public virtual Transform RandPoint()
    {
        int ran = Random.Range(0, holders.Count);
        return holders[ran];
    }
}
