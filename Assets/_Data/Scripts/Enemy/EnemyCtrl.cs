using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : RootMonoBehaviour
{

    [SerializeField] protected SpawnerPoint spawnerPoint;
    public SpawnerPoint SpawnerPoint { get => spawnerPoint; }

    [SerializeField] protected EnemySpawner enemySpawner;
    public EnemySpawner EnemySpawner { get => enemySpawner; }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnerPoint();
        this.LoadEnemySpawner();
    }
    protected virtual void LoadSpawnerPoint()
    {
        if (this.spawnerPoint != null) return;
        this.spawnerPoint = FindObjectOfType<SpawnerPoint>();
        Debug.Log(transform.gameObject + "Load SpawnderPoint",gameObject);
    }
    protected virtual void LoadEnemySpawner()
    {
        if (this.enemySpawner != null) return;
        this.enemySpawner = transform.GetComponentInChildren<EnemySpawner>();
        Debug.Log(transform.gameObject + "Load EnemySpawner", gameObject);


    }

}
