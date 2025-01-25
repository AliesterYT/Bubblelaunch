using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player : MonoBehaviour
{
    //private GameObject cameraObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Dead");

            //cameraObject = GameObject.Find("Camera");
            GameObject.Find("Camera").GetComponent<Camera>().enabled = true;
            GameObject.Find("InfoCanvas").GetComponent<Canvas>().enabled = false;
            GameObject.Find("EndCanvasFail").GetComponent<Canvas>().enabled = true;
        }
    }
}
