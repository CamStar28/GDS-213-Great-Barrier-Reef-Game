using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class returnMenuScript : MonoBehaviour
{

    public Image returnPanel; 
    public GameObject returnMenu;
    public GameObject playerLink;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }

    public void Unpause()
    {
        StartCoroutine(FadeOut());
    }

    public IEnumerator FadeIn()
    {
        Color c = returnPanel.color;
        for (float alpha = 0; alpha <= 0.5; alpha += 0.01f)
        {
            c.a = alpha;
            returnPanel.color = c;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        returnMenu.SetActive(true);
    }

    public IEnumerator FadeOut()
    {
        returnMenu.SetActive(false);

        Color c = returnPanel.color;
        for (float alpha = 0.5f; alpha >= 0; alpha -= 0.01f)
        {
            c.a = alpha;
            returnPanel.color = c;
            yield return new WaitForSecondsRealtime(0.01f);
        }

        Time.timeScale = 1;
        playerLink.GetComponent<playerController>().gameIsPaused = false;
    }
}
