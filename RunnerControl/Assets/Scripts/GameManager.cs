using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Hedef;
    public GameObject PrefabKarakter;
    public GameObject DogmaNoktasi;
    public GameObject VarisNoktasi;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            Instantiate(PrefabKarakter, DogmaNoktasi.transform.position, Quaternion.identity);
    }
}
