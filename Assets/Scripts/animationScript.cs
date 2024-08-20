using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationScript : MonoBehaviour
{

    public string anim1; 
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>().Play(anim1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
