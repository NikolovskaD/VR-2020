using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DentedPixel;

public class TimePassed : MonoBehaviour
{
    public float totalTime = 60f;
    public float passedTime = 0f;

    public GameObject bar;

    private void Start()
    {
        AnimateBar();
    }


    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;

        if (passedTime >= totalTime)
        {
            Debug.Log("Game over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            passedTime = 0;
        }
    }

    public void AnimateBar()
    {
        LeanTween.scaleX(bar,1,60);
    }
}
