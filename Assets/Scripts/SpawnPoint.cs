using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
            Instantiate(target); //автоматический спавн одного объекта 
    }
}
