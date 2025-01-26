using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Win");

            GameObject.Find("Camera").GetComponent<Camera>().enabled = true;
            GameObject.Find("InfoCanvas").GetComponent<Canvas>().enabled = false;
            GameObject.Find("EndCanvasWin").GetComponent<Canvas>().enabled = true;
            Destroy(GameObject.Find("TimeCanvas"));
        }
    }
}
