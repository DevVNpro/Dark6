using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnRandom : RootMonoBehaviour
{
    [Header("Enemy Random")]
    [SerializeField] protected EnemyCtrl enemyCtrl;
    [SerializeField] protected float time = 0f;
    [SerializeField] protected float timeLimid = 5f;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.enemyCtrl != null) return;
        this.enemyCtrl = GetComponent<EnemyCtrl>();
        Debug.LogWarning(transform.name + ": LoadJunkCtrl", gameObject);
    }
    private void Update()
    {
        this.SpawnEnemy();

    }
    protected virtual void SpawnEnemy()
    {
   
            this.time += Time.deltaTime;
            if (this.time < this.timeLimid) return;
            this.time = 0;
            Transform prefab = SetSpawnPrefabs(GameManager.Instance.level);
             if (prefab == null) return;
            Transform Pos = enemyCtrl.SpawnerPoint.RandPoint();
            Transform enemy = EnemySpawner.Instance.Spawner(prefab, Pos.position, transform.rotation); ;
             enemy.gameObject.SetActive(true);
            
    }
    protected virtual Transform SetSpawnPrefabs(int level)
    {
        if (level == 1)
        {
          return  EnemySpawner.Instance.SpawnLevel1Prefabs();

        }
        else if (level == 2)
        {
            return EnemySpawner.Instance.SpawnLevel2Prefabs();
        }
        else if (level == 3)
        {
            return EnemySpawner.Instance.SpawnLevel3prefabs();
     
        }
        return null;
    }

}
