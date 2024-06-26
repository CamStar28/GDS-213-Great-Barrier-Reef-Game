using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject potatoCodImage;
    public GameObject greenTurtleImage;

    public GameObject potatoCodBio; 
    public GameObject greenTurtleBio;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PotatoCod")
        {
            potatoCodImage.SetActive(true);
            Debug.Log("fish wit da LIPS");
            potatoCodBio.gameObject.GetComponent<fishBioController>().UnlockBio(); 
        } else if (other.gameObject.tag == "GreenTurtle")
        {
            greenTurtleImage.SetActive(true);
            Debug.Log("I spent hours of my life stomping... KOOPAS");
            greenTurtleBio.gameObject.GetComponent<fishBioController>().UnlockBio();
        }
    }
}
