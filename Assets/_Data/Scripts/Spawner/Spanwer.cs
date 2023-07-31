using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public abstract class Spanwer : RootMonoBehaviour
{
  
    [SerializeField] protected Transform holders;
    [SerializeField] protected List<Transform> prefabs;
    [SerializeField] protected List<Transform> Pool;
    protected Transform Prefab;
    public  int CountPrefabs;
    public int CountDespawnPrefabs;
 
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPrefabs();
        this.LoadHolder();
    }
    protected virtual void LoadPrefabs()
    {
        if (this.prefabs.Count > 0) return;
        if (this.Prefab != null) return;
        this.Prefab = transform.Find("Prefabs");
        Debug.Log(transform.name + "Load Prefabs", gameObject);
        foreach (Transform prefab in Prefab)
        {
            prefabs.Add(prefab);
        }
        this.HidePrefabs();
    }
    protected virtual void LoadHolder()
    {
        if (this.holders != null) return;
        holders = transform.Find("Holder");
        Debug.Log(transform.name + "Load Holder", gameObject);
    }

    protected virtual void HidePrefabs()
    {
        foreach(Transform Prefab in Prefab)
        {
            Prefab.gameObject.SetActive(false);
        }
    }
    public virtual Transform Spawner(Transform prefab, Vector3 pos, Quaternion rot)
    {
        if (!this.CheckPrefab(prefab)) return null;
       Transform newPrefab = GetObjectFromPool(prefab);
        newPrefab.SetLocalPositionAndRotation(pos, rot);
        newPrefab.parent = this.holders;
        this.CountPrefabs++;
        return newPrefab;
    }
    protected virtual Transform GetObjectFromPool(Transform prefab)
    {

        foreach (Transform poolObj in this.Pool)
        {
            if (poolObj == null) continue;
            if (poolObj.name == prefab.name)
            {
                this.Pool.Remove(poolObj);
                return poolObj;
            }
        }
        Transform newPrefab = Instantiate(prefab);
        newPrefab.name = prefab.name;
        return newPrefab;
    }
  
    protected virtual bool CheckPrefab(Transform prefab)
    {
        if (prefab != null) return true;
        Debug.Log(transform.name + "Prefab Null", gameObject);
        return false;
    }

    public virtual void Despawn(Transform obj)
    {
        this.Pool.Add(obj);
        obj.gameObject.SetActive(false);
        this.CountDespawnPrefabs++;
    }

}
