using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishBioController : MonoBehaviour
{

    public GameObject bioGroup;
    public GameObject buttonGroup;
    public GameObject lockedGroup;
    public GameObject unlockedGroup; 
    
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

    public void UnlockBio()
    {
        unlockedGroup.SetActive(true);
        lockedGroup.SetActive(false);
    }
}
