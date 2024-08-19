using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class sentenceTypeScript : MonoBehaviour
{

    public TextMeshProUGUI fullCompletionText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartTyping()
    {
        fullCompletionText.alpha = 1;
        
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        string sentence;
        sentence = fullCompletionText.text;
        fullCompletionText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            fullCompletionText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }

        yield return new WaitForSeconds(5);
        Destroy(fullCompletionText);
    }
}
