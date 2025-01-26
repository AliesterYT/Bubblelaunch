using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text countdownText;
    [SerializeField] float startingTime = 30f;
    float currentTime = 0f;

    void Start()
    {
        currentTime = startingTime;
        currentTime = Mathf.Max(currentTime, 0);
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString("F2") + "s";
        //Debug.Log("Time");

        if (currentTime < 0)
        {
            Destroy(GameObject.FindWithTag("Player"));
            Debug.Log("Dead");
            GameObject.Find("Camera").GetComponent<Camera>().enabled = true;
            GameObject.Find("InfoCanvas").GetComponent<Canvas>().enabled = false;
            GameObject.Find("EndCanvasFail").GetComponent<Canvas>().enabled = true;
            Destroy(gameObject);
        }

    }
}
