using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public GameObject welcomeText, s1, s2, s3, s4, s5;
    public Button nextButton, backButton;
    public int step = 0;
    private List<GameObject> stepList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        // Add step text GameObjects to list
        stepList.Add(s1);
        stepList.Add(s2);
        stepList.Add(s3);
        stepList.Add(s4);
        stepList.Add(s5);
        ////// for 18 more

        // Hide all steps on startup
        foreach(GameObject step in stepList)
        {
            step.SetActive(false);
        }
        // Display welcome message on startup
        welcomeText.SetActive(true);

        // TODO: change this for phone (tap instead of click);
        nextButton.onClick.AddListener(nextStep);
        backButton.onClick.AddListener(previousStep);
    }

    // Update is called once per frame
    void Update()
    {
        // hide welcome message when user taps screen
        if (welcomeText.active && Input.touchCount == 1)
        {
            welcomeText.SetActive(false);
        }

        // State tracker (activate text and AR elements based 
        // on the step user is on)
        switch (step)
        {
            case 1:
                welcomeText.SetActive(false);
                s2.SetActive(false);
                s1.SetActive(true);
                break;
            case 2:
                s3.SetActive(false);
                s1.SetActive(false);
                s2.SetActive(true);
                break;
            case 3:
                s4.SetActive(false);
                s2.SetActive(false);
                s3.SetActive(true);
                break;
            case 4:
                s5.SetActive(false);
                s3.SetActive(false);
                s4.SetActive(true);
                break;
            case 5:
                //s6.SetActive(false);
                s4.SetActive(false);
                s5.SetActive(true);
                break;
            default:
                Debug.Log(step);
                break;
        }
    }

    void nextStep()
    {
        step++;
        Debug.Log(step);
    }

    void previousStep()
    {
        step--;
        Debug.Log(step);
    }
}
