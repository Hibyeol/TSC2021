using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    public GameObject IntroObject;
    public GameObject StartObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayTime(3));
    }

    IEnumerator DelayTime(float time)
    {
        yield return new WaitForSeconds(time);

        IntroObject.SetActive(false);
        StartObject.SetActive(true);
    }
    

    // Update is called once per frame
    void Update()
    {
        SceneChagne();
    }
    
    public void SceneChagne()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Solitaire");
        }
    }
}
