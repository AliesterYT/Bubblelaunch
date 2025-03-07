using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill_Player : MonoBehaviour
{
    //private GameObject cameraObject;

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
            Destroy(GameObject.Find("TimeCanvas"));
        }
    }
}
