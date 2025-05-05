using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform monster in transform)
        {
            //Debug.Log(monster.name);
            if(this.IsDead(monster))
            {
                Debug.Log(monster.name + ":IsDead");
            }
        }

    }
    protected virtual bool IsDead(Transform monster)
    {   
        if(monster.name.Contains("Dead")) return true;
        return false;
    }
}
