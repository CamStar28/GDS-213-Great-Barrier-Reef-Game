using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sealifeAirScript : MonoBehaviour
{

    public float surfaceTimer;
    public float timerEndRandom;

    public GameObject sealifeTarget;     
    
    // Start is called before the first frame update
    void Start()
    {
        surfaceTimer = 0;
        timerEndRandom = Random.Range(300, 600);
    }

    // Update is called once per frame
    void Update()
    {
        surfaceTimer += Time.deltaTime;

        if(surfaceTimer > timerEndRandom)
        {
            sealifeTarget.transform.position = new Vector3(0, 51, 0);
        }

        if(Mathf.Round(transform.position.y) == 50)
        {
            StartCoroutine(BreatheAndDive());
            //Debug.Log("air refill yummy");
        }
    }

    IEnumerator BreatheAndDive()
    {
        yield return new WaitForSeconds(Random.Range(5, 10));

        surfaceTimer = 0;
        sealifeTarget.GetComponent<targetRandomiser>().RandomisePosition();
    }

}
