using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public Rigidbody playerBody;
    public GameObject cameraFlash;

    public GameObject fishipediaMenu;
    public bool isFishipediaOpen;

    public bool gameIsPaused; 

    public bool isFacingRight; 
    
    // Start is called before the first frame update
    void Start()
    {
        isFacingRight = true; 
        isFishipediaOpen = false;
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameIsPaused == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                playerBody.velocity = new Vector3(0, 3, 0);
                //Debug.Log("going up?"); 
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                playerBody.velocity = new Vector3(5, -0.5f, 0);
                isFacingRight = true;
                //Debug.Log("right away"); 
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                playerBody.velocity = new Vector3(-5, -0.5f, 0);
                isFacingRight = false;
                //Debug.Log("the radical left");
            }

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                playerBody.velocity = new Vector3(5, 3, 0);
                isFacingRight = true;
                //camera flash won't spawn with this input combination specifically????
            }

            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                playerBody.velocity = new Vector3(-5, 3, 0);
                isFacingRight = false;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                playerBody.velocity = new Vector3(0, -5, 0);
                //Debug.Log("down"); 
            }

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                playerBody.velocity = new Vector3(5, -5, 0);
                isFacingRight = true;
            }

            if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                playerBody.velocity = new Vector3(-5, -5, 0);
                isFacingRight = false;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                cameraFlash.SetActive(true);

                if (isFacingRight == true)
                {
                    cameraFlash.transform.position = new Vector3(transform.position.x + 2.5f, transform.position.y, transform.position.z);
                }
                else
                {
                    cameraFlash.transform.position = new Vector3(transform.position.x - 2.5f, transform.position.y, transform.position.z);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if(isFishipediaOpen == false) 
            {
                fishipediaMenu.SetActive(true);
                isFishipediaOpen = true;
                Time.timeScale = 0;
                gameIsPaused = true;
            } else
            {
                fishipediaMenu.SetActive(false);
                isFishipediaOpen = false;
                Time.timeScale = 1;
                gameIsPaused = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused == false)
            {
                Time.timeScale = 0; 
                gameIsPaused = true;
            } else
            {
                Time.timeScale = 1; 
                gameIsPaused = false;
            }
        }
    }
}
