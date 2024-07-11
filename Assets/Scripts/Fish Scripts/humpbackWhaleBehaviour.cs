using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding; 

public class humpbackWhaleBehaviour : MonoBehaviour
{
    private AIPath path;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<AIPath>();
    }

    // Update is called once per frame
    void Update()
    {
        path.maxSpeed = moveSpeed;

        path.destination = target.position;
    }
}
