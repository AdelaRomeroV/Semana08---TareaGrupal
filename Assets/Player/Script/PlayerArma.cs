using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArma : Arma
{
    void Update()
    {
        ContadorBalas();
    }

    public void ContadorBalas()
    {
        if (CountBullet > 0)
        {
            
            if (Input.GetMouseButtonDown(0)) 
            {
                GetDisparo(0);
            }

            if(Input.GetMouseButtonDown(1)) 
            {
                GetDisparo(1);
            }
        }
    }
}
