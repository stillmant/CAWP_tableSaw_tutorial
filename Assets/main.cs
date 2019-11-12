using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class main : MonoBehaviour
{
    public Button nextButton, backButton, exit;
    public RawImage bladeIcon, bladeChange;
    public int step = 0;
    private List<GameObject> stepList = new List<GameObject>();

    public TextMeshProUGUI uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = gameObject.GetComponent<TextMeshProUGUI>();
        uiText.text = "Welcome! \nThis tutorial will show you how to properly change the blade of the Table Saw";

        bladeIcon.gameObject.SetActive(false);
        bladeChange.gameObject.SetActive(false);

        nextButton.onClick.AddListener(nextStep);
        backButton.onClick.AddListener(previousStep);
        exit.onClick.AddListener(finish);
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
                bladeIcon.gameObject.SetActive(false);
                break;
            case 2:
                uiText.text = "On the touch screen\ntouch the blade icon: ";
                bladeIcon.gameObject.SetActive(true);
                bladeChange.gameObject.SetActive(false);
                break;
            case 3:
                uiText.text = "Select the blade change icon:";
                bladeChange.gameObject.SetActive(true);
                bladeIcon.gameObject.SetActive(false);
                break;
            case 4:
                uiText.text = "Move the sawdust hood out of the way. (3D scan AR)"; // TODO: Get scan, build model target and arrow animation
                bladeChange.gameObject.SetActive(false);
                break;
            case 5:
                uiText.text = "Push the \"|\" button above the white light (AR glow around button?)"; // TODO: Maybe use AR to highlight button?
                break;
            case 6:
                uiText.text = "Slide the table in the direction of the arrow (AR)"; // TODO: move text out of the way to see AR element
                // Invoke("hideText", 5);            
                break;
            case 7:
                uiText.text = "";
                break;
            case 8:
                uiText.text = "Pull the safety knob and slide table to end (AR)"; // TODO: move text out of the way to see AR element
                //Invoke("hideText", 5);
                break;
            case 9:
                uiText.text = "";
                break;
            case 10:
                uiText.text = "Push red knob to the right and pull fence toward you (AR)";
                break;
            case 11:
                uiText.text = "Find this tool in the tool compartment (3D model w/ animation)"; // TODO: might want to make model of the tool and hover/ spin it
                break;
            case 12:
                uiText.text = "Loosen the splitter and move out of the way";
                break;
            case 13:
                uiText.text = "Loosen locking screw on main spindle (AR arrow pointing to screw)";
                break;
            case 14:
                uiText.text = "Unscrew main spindle counterclockwise and remove";
                break;
            case 15:
                uiText.text = "Replace blade. \nCAUTION: Blade teeth must face right";
                break;
            case 16:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                break;
            case 17:
                uiText.text = "Tighten lock screw";
                break;
            case 18:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                break;
            case 19:
                uiText.text = "Move splitter back, making sure there is enough clearance and tighten"; // TODO: AR wireframe could be used here
                break;
            case 20:
                uiText.text = "Close the fence \nCheck both sides are secure (AR arrow)";
                break;
            case 21:
                uiText.text = "Slide table back to its original position (AR arrow)";
                break;
            case 22:
                uiText.text = "On the touchscreen, select \"yes\" and select the blade you installed from the databse";
                break;
            case 23:
                uiText.text = "FIN!";
                break;
            default:
                Debug.Log(step);
                break;
        }
    }
    /*
    void hideText()
    {
        uiText.gameObject.SetActive(false);
    } */

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

    void finish()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
