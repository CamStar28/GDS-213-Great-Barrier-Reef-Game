using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishBioController : MonoBehaviour
{

    public string whichFish;
    public GameObject buttonGroup; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowBio()
    {
        buttonGroup.SetActive(false);
        
        if (whichFish == "Potato Cod")
        {
            Debug.Log("is potat"); 
        } else if (whichFish == "Manta Ray")
        {
            Debug.Log("pancake :3"); 
        }
    }
}
