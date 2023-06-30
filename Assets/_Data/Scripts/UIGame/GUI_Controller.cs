using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Controller : MonoBehaviour
{
   [SerializeField] private float timeOff = 3f;
    [SerializeField] private float time = 0f;
    void Update()
    {
        this.Close_GUI();
    }
    protected virtual void Close_GUI()
    {
        time += Time.deltaTime;
        if (this.time < this.timeOff) return;
        transform.gameObject.SetActive(false);
    }
}
