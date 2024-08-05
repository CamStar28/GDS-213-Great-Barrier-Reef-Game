using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetRandomiser : MonoBehaviour
{

    public float[] xPositions;
    public float[] yPositions;

    private int randomNumber;
    private int previousRandNum; 
    
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, xPositions.Length);
        previousRandNum = randomNumber;

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
            RandomisePosition();
        }
    }

    public void RandomisePosition()
    {
        randomNumber = Random.Range(0, xPositions.Length);

        if(randomNumber == previousRandNum)
        {
            if(randomNumber >= xPositions.Length - 1)
            {
                randomNumber--;
                Debug.Log("down the array");
            } else
            {
                randomNumber++;
                Debug.Log("up the array");
            }
        }

        previousRandNum = randomNumber;

        //transform.position = new Vector3(xPositions[randomNumber] + Random.Range(-5, 5), yPositions[randomNumber] + Random.Range(-5, 5), 0); //Version with slight target randomness
        transform.position = new Vector3(xPositions[randomNumber], yPositions[randomNumber], 0);
    }

}
