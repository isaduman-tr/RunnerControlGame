using UnityEngine;
using UnityEngine.AI;

public class Alt_Karakter : MonoBehaviour
{
    GameObject target;
    NavMeshAgent _Navmesh;
    
    void Start()
    {
        _Navmesh = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;
    }


    private void LateUpdate()
    {
        _Navmesh.SetDestination(target.transform.position);
    }
}
