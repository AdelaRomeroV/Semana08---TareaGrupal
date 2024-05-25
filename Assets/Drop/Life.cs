using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : Item
{
    [SerializeField] protected int life;

    protected virtual void ChangeLife(int value)
    {
        life += value;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
