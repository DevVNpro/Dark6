using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : RootMonoBehaviour
{
    protected static GameManager instance;
    public static GameManager Instance => instance;
  
    public int level = 1;
    public static event Action PlayerDied;
    public static event Action BossDied;

    public void PlayerDeath()
    {
        if (PlayerDied != null)
            PlayerDied.Invoke();
    }
    public void BossDeath()
    {
        if (BossDied != null)
            BossDied.Invoke();
    }
    protected override void Start()
    {
        base.Start();
        if (GameManager.instance != null) Debug.LogError("Only one Instance GameManager allow exist");
        GameManager.instance = this;
    }
    private void Update()
    {
        this.Setlevel();
    }

    protected void Setlevel()
    {
        int countPrefabs = EnemySpawner.Instance.CountPrefabs;
        int countDespawnPrefabs = EnemySpawner.Instance.CountDespawnPrefabs;

        if (countPrefabs == 0 && countDespawnPrefabs == 0)
        {
            level = 1;

        }
       else if (countPrefabs == 15 && countDespawnPrefabs == 15)
        {

            level = 2;
        }
        else if(countPrefabs == 20  && countDespawnPrefabs == 20)
        {
            level = 3;
        }
        else if (countPrefabs == 20 || countPrefabs == 21|| countPrefabs==15)
        {
            level = 0;
        }
    }
 
 
}
