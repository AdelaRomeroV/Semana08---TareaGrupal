using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArma : Arma
{
    void Update()
    {
        ContadorBalas();
    }

    public void SumarBalas(int balas)
    {
        CountBullet += balas;
    }

    public void ContadorBalas()
    {
        if (CountBullet > 0)
        {
            
            if (Input.GetMouseButton(0)) 
            {
                GetDisparo(0);
            }

            if(Input.GetMouseButton(1)) 
            {
                GetDisparo(1);
            }
        }
    }
}
