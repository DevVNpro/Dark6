using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : RootMonoBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance { get => instance; }
    
    [SerializeField] protected float fire;
    public float Fire { get => fire; }

    [SerializeField] protected float x;
    public float X { get => x; }
    [SerializeField] protected float y;
    public float Y { get => y; }
    protected override void Awake()
    {
        base.Awake();
        if (InputManager.instance != null) Debug.LogError("Only 1 Inputmanager alow ");
        InputManager.instance = this;     
    }
    private void Update()
    {
        this.SetFire();
        this.GetAxis();
      
    }
    protected virtual void GetAxis()
    {
        if(this.fire==1)
        {
            this.x = 0f;
            this.y = 0f;
        }
        else
        {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        }

    }
    protected virtual void SetFire()
    {
        fire = Input.GetAxisRaw("Fire1");
    }
    

}
