using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class main : MonoBehaviour
{
    public Button nextButton, backButton, exit;
    public RawImage bladeIcon, bladeChange, backPlane;
    public int step = 0;
    
    public GameObject hood;

    private GameObject guideViewRenderer;

    public TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, true);

        uiText.text = "Welcome! \nThis tutorial will show you how to properly change the blade of the Table Saw";

        bladeIcon.gameObject.SetActive(false);
        bladeChange.gameObject.SetActive(false);
        hood.gameObject.SetActive(false);

        guideViewRenderer = GameObject.Find("GuideViewRenderer");
    }

    // Update is called once per frame
    void changeStep()
    {
        // State tracker (activate text and AR elements based 
        // on the step user is on)
        switch (step)
        {
            case 1:
                uiText.text = "Before starting any work, be sure you are wearing the proper PPE and the emergency stop is engaged";
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
                backPlane.gameObject.SetActive(true);
                uiText.text = "Move the sawdust hood out of the way. Tap next and align the wireframe with the black handle on the hood."; // TODO: Get scan, build model target and arrow animation
                bladeChange.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 5:
                backPlane.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(true);
                hood.gameObject.SetActive(true);
                uiText.text = ""; 
                break;
            case 6:
                guideViewRenderer.gameObject.SetActive(false);
                hood.gameObject.SetActive(false);
                backPlane.gameObject.SetActive(true);
                uiText.text = "Push the \"|\" button above the white light (AR glow around button?)"; // TODO: Maybe use AR to highlight button?
                break;
            case 7:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Astronaut\" target and tap \"Next\"";    
                break;
            case 8:
                uiText.text = ""; // "Slide until stop, then tap next
                backPlane.gameObject.SetActive(false);
                break;
            case 9:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Drone\" target under the table and tap \"Next\""; 
                break;
            case 10:
                uiText.text = ""; // Pull the safety knob and slide table to end (AR)
                backPlane.gameObject.SetActive(false);
                break;
            case 11:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Oxygen\" target and tap \"Next\"";
                break;
            case 12:
                uiText.text = "";
                backPlane.gameObject.SetActive(false);
                break;
            case 13:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the Allen key in the tool box"; // TODO: might want to make model of the tool and hover/ spin it
                break;
            case 14:
                uiText.text = "Loosen the splitter and move out of the way"; // GOOD PLACE TO USE MODEL TARGET
                break;
            case 15:
                uiText.text = "Loosen locking screw on main spindle (AR arrow pointing to screw)";
                break;
            case 16:
                uiText.text = "Unscrew main spindle counter clockwise and remove";
                break;
            case 17:
                uiText.text = "Replace blade. \nCAUTION: Blade teeth must face right";
                break;
            case 18:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                break;
            case 19:
                uiText.text = "Tighten lock screw";
                break;
            case 20:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                break;
            case 21:
                uiText.text = "Move splitter back, making sure there is enough clearance and tighten"; // TODO: AR wireframe could be used here
                break;
            case 22:
                uiText.text = "Close the fence \nCheck both sides are secure (AR arrow)";
                break;
            case 23:
                uiText.text = "Slide table back to its original position (AR arrow)";
                break;
            case 24:
                uiText.text = "On the touchscreen, select \"yes\" and select the blade you installed from the database";
                break;
            case 25:
                uiText.text = "FIN!";
                break;
            default:
                Debug.Log(step);
                break;
        }
    }

    public void nextStep()
    {
        step++;
        changeStep();
        Debug.Log(step);
    }

    public void previousStep()
    {
        step--;
        changeStep();
        Debug.Log(step);
    }

    public void finish()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
