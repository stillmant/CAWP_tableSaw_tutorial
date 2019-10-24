using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class main : MonoBehaviour
{
    public Button nextButton, backButton;
    public int step = 0;
    private List<GameObject> stepList = new List<GameObject>();

    public TextMeshProUGUI uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = gameObject.GetComponent<TextMeshProUGUI>();
        uiText.text = "Welcome! \nThis tutorial will show you how to properly change the blade of the Table Saw";

        // TODO: change this for phone (tap instead of click);
        nextButton.onClick.AddListener(nextStep);
        backButton.onClick.AddListener(previousStep);
    }

    // Update is called once per frame
    void Update()
    {
        // State tracker (activate text and AR elements based 
        // on the step user is on)
        switch (step)
        {
            case 1:
                uiText.text = "Before starting any work, be sure you are wearing the proper PPE and the emergency stop is engaged.";
                break;
            case 2:
                uiText.text = "On the touch screen:\ntouch the blade icon -> then select the circular arrows";
                break;
            case 3:
                uiText.text = "Move the sawdust hood out of the way.";
                break;
            case 4:
                uiText.text = "";
                break;
            case 5:
                uiText.text = "Welcome";
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
