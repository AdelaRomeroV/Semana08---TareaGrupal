using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeMax : Item
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerLife playerLife = other.gameObject.GetComponent<PlayerLife>();
            if(playerLife != null) 
            { 
                playerLife.ChangeLife(count); 
                Destroy(gameObject);            
            }
        }
    }
}
