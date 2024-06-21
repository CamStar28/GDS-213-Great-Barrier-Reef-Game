using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject potatoCodImage;

    public GameObject potatoCodBio; 
    
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
        }
    }
}
