using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysDrop : MonoBehaviour
{
    
    [SerializeField] private Item[] items;
    [ContextMenu("Drop Item")]
    public void DropItem()
    {
        if(items != null)
        {
            Instantiate(items[Random.Range(0, items.Length)], transform.position, Quaternion.identity);
        }
    }


}
