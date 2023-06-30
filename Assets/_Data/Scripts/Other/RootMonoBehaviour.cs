using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        //for override
    }
    protected virtual void Start()
    {
        this.LoadComponents();
    }
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        //for override
    }
}
