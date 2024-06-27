using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetRandomiser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-90, 90), Random.Range(-90, 90), 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            transform.position = new Vector3(Random.Range(-90, 90), Random.Range(-90, 90), 0);
        }

    }
}
