using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCombat : MonoBehaviour
{
    [SerializeField] protected BallDamageSender ballDamageSender;
    protected Vector3 InitPosition;
 

    private void Start()
    {
        ballDamageSender= gameObject.GetComponent<BallDamageSender>();
        InitPosition = transform.position;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
 
        ballDamageSender.Send(collision.transform);
        gameObject.SetActive(false);
        transform.position = InitPosition;
        }
    }


}
