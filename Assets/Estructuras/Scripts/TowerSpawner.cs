using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : Estructure_ItemSpawner
{
    [SerializeField] GameObject LifeItem;
    [SerializeField] Transform SpawnCenter;

    void Start()
    {
        StartCoroutine(Spawner(LifeItem, SpawnCenter));
    }
}
