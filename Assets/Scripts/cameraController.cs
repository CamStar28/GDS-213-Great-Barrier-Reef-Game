using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public bool potatoCodUnlocked;
    public bool giantClamUnlocked;
    public bool whaleSharkUnlocked;
    public bool maoriWrasseUnlocked;
    public bool clownfishUnlocked;
    public bool humpbackWhaleUnlocked;
    public bool mantaRayUnlocked;
    public bool greenTurtleUnlocked;

    public GameObject fullCompletionStar;
    public TextMeshProUGUI fullCompletionText; 

    public SpriteRenderer flashRenderer;

    // Start is called before the first frame update
    void Start()
    {
        potatoCodUnlocked = false;
        giantClamUnlocked = false;
        whaleSharkUnlocked = false;
        maoriWrasseUnlocked = false;
        clownfishUnlocked = false;
        humpbackWhaleUnlocked = false;
        mantaRayUnlocked = false;
        greenTurtleUnlocked = false;

        fullCompletionStar.SetActive(false);
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
        if (other.gameObject.tag == "PotatoCod" && potatoCodImage != null)
        {
            potatoCodImage.SetActive(true);
            //Debug.Log("fish wit da LIPS");

            potatoCodBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            potatoCodUnlocked = true;
        }
        else if (other.gameObject.tag == "GreenTurtle" && greenTurtleImage != null)
        {
            greenTurtleImage.SetActive(true);
            //Debug.Log("I spent hours of my life stomping... KOOPAS");

            greenTurtleBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            greenTurtleUnlocked = true;

        }
        else if (other.gameObject.tag == "MaoriWrasse" && maoriWrasseImage != null)
        {
            maoriWrasseImage.SetActive(true);

            maoriWrasseBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            maoriWrasseUnlocked = true;

        }
        else if (other.gameObject.tag == "GiantClam" && giantClamImage != null)
        {
            giantClamImage.SetActive(true);

            giantClamBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            giantClamUnlocked = true;
        }
        else if (other.gameObject.tag == "Clownfish" && clownfishImage != null)
        {
            clownfishImage.SetActive(true);

            clownfishBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            clownfishUnlocked = true;
        }
        else if (other.gameObject.tag == "MantaRay" && mantaRayImage != null)
        {
            mantaRayImage.SetActive(true);

            mantaRayBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            mantaRayUnlocked = true;
        }
        else if (other.gameObject.tag == "WhaleShark" && whaleSharkImage != null)
        {
            whaleSharkImage.SetActive(true);

            whaleSharkBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            whaleSharkUnlocked = true;
        }
        else if (other.gameObject.tag == "HumpbackWhale" && humpbackWhaleImage != null)
        {
            humpbackWhaleImage.SetActive(true);

            humpbackWhaleBio.gameObject.GetComponent<fishBioController>().UnlockBio();

            humpbackWhaleUnlocked = true;
        }

        if(potatoCodUnlocked == true && giantClamUnlocked == true && greenTurtleUnlocked == true && mantaRayUnlocked == true && maoriWrasseUnlocked == true && humpbackWhaleUnlocked == true && whaleSharkUnlocked == true && clownfishUnlocked == true && fullCompletionText != null)
        {
            fullCompletionStar.SetActive(true);

            fullCompletionText.GetComponent<sentenceTypeScript>().StartTyping();
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
