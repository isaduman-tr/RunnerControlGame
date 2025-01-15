using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public GameObject Hedef;
    public GameObject PrefabKarakter;
    public GameObject DogmaNoktasi;
    public GameObject VarisNoktasi;
    public List<GameObject> Karakterler;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            foreach (var item in Karakterler)
            {
                if (!item.activeInHierarchy)
                {

                }
            }
    }
}
