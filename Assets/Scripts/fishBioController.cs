using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishBioController : MonoBehaviour
{

    public GameObject buttonGroup;
    public GameObject bioGroup; 
    
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
        bioGroup.SetActive(true); 
    }
}
