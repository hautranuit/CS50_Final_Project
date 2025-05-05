using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ListDeadChild : ListChild
{
    protected override void ShowAllChild()
    {
        foreach (Transform child in transform)
        {
            if (this.IsDead(child))
            {
                Debug.Log(child.name + ":IsDead");
            }
        }
    }
    protected virtual bool IsDead(Transform monster)
    {
        if (monster.name.Contains("Dead")) return true;
        return false;
    }
}
