using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cash : Item
{

    protected virtual void GetCash(int value)
    {
        cash += value;
    }
}
