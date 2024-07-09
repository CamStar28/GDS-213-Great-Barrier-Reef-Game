using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject potatoCodImage;
    public GameObject greenTurtleImage;
    public GameObject giantClamImage;
    public GameObject whaleSharkImage;
    public GameObject maoriWrasseImage;
    public GameObject clownfishImage;
    public GameObject humpbackWhaleImage;
    public GameObject mantaRayImage;

    public GameObject potatoCodBio; 
    public GameObject greenTurtleBio;
    public GameObject giantClamBio;
    public GameObject whaleSharkBio;
    public GameObject maoriWrasseBio;
    public GameObject clownfishBio;
    public GameObject humpbackWhaleBio;
    public GameObject mantaRayBio;

    public SpriteRenderer flashRenderer; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(Fade());
    }

    public void SpriteFaceLeft()
    {
        GetComponent<SpriteRenderer>().flipY = false;
    }

    public void SpriteFaceRight()
    {
        GetComponent<SpriteRenderer>().flipY = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PotatoCod")
        {
            potatoCodImage.SetActive(true);
            //Debug.Log("fish wit da LIPS");

            potatoCodBio.gameObject.GetComponent<fishBioController>().UnlockBio(); 

        } else if (other.gameObject.tag == "GreenTurtle")
        {
            greenTurtleImage.SetActive(true);
            //Debug.Log("I spent hours of my life stomping... KOOPAS");

            greenTurtleBio.gameObject.GetComponent<fishBioController>().UnlockBio();

        } else if (other.gameObject.tag == "MaoriWrasse")
        {
            maoriWrasseImage.SetActive(true);

            maoriWrasseBio.gameObject.GetComponent<fishBioController>().UnlockBio(); 
        } else if (other.gameObject.tag == "GiantClam")
        {
            giantClamImage.SetActive(true);

            giantClamBio.gameObject.GetComponent<fishBioController>().UnlockBio();
        } else if (other.gameObject.tag == "Clownfish")
        {
            clownfishImage.SetActive(true);

            clownfishBio.gameObject.GetComponent<fishBioController>().UnlockBio();
        } else if (other.gameObject.tag == "MantaRay")
        {
            mantaRayImage.SetActive(true);

            mantaRayBio.gameObject.GetComponent<fishBioController>().UnlockBio();
        }
    }

    IEnumerator Fade()
    {
        Color c = flashRenderer.material.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
        {
            c.a = alpha;
            flashRenderer.material.color = c;
            yield return new WaitForSeconds(0.01f);
        }

        gameObject.SetActive(false);
    }
}
