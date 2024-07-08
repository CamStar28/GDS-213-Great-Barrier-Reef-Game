using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetRandomiser : MonoBehaviour
{

    public float[] xPositions;
    public float[] yPositions;

    private int randomNumber; 
    
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, xPositions.Length);

        transform.position = new Vector3(xPositions[randomNumber], yPositions[randomNumber], 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            randomNumber = Random.Range(0, xPositions.Length);

            transform.position = new Vector3(xPositions[randomNumber], yPositions[randomNumber], 0);
        }

    }
}
