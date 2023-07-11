using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveSkillBallFire : MonoBehaviour
{
    [SerializeField] protected GameObject[] ballFires;

    protected void ActiveBall()
    {
        foreach(GameObject ballFire in ballFires)
        {
            ballFire.SetActive(true);
        }
    }
    protected void DeActiveBall()
    {
        foreach (GameObject ballFire in ballFires)
        {
            ballFire.SetActive(false);
        }
    }
}
