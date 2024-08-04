using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class photoFadeScript : MonoBehaviour
{

    public Image photoRenderer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeAway());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator FadeAway()
    {
        yield return new WaitForSeconds(3f);

        Color c = photoRenderer.color;
        for (float alpha = 1f; alpha >= 0; alpha -= 0.01f)
        {
            c.a = alpha;
            photoRenderer.color = c;
            yield return new WaitForSeconds(0.01f);
        }

        Destroy(gameObject);
    }

}
