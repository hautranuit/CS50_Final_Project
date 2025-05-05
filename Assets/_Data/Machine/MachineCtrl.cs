using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineCtrl : MonoBehaviour
{
    [Header("Machine")]   
    
    public Trigger trigger;
    public Action action;
    protected virtual void Start()
    {
        this.trigger = transform.GetComponentInChildren<Trigger>();
        this.action = transform.GetComponentInChildren<Action>();
    }
}
