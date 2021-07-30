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
    
    public GameObject hood, b1, b2;

    private GameObject guideViewRenderer;

    public TextMeshProUGUI uiText;

    // Start is called before the first frame update
    void Start()
    {
        uiText.text = "Welcome! \nThis tutorial will show you how to properly change the blade of the Table Saw";

        bladeIcon.gameObject.SetActive(false);
        bladeChange.gameObject.SetActive(false);
        hood.gameObject.SetActive(false);

        guideViewRenderer = GameObject.Find("GuideViewRenderer");
        guideViewRenderer.gameObject.SetActive(false);
    }

    void changeStep()
    {
        // State tracker (activate text and AR elements based 
        // on the step user is on)
        switch (step)
        {
            case 1:
                uiText.text = "Before starting any work, be sure you are wearing the proper PPE and the emergency stop is engaged";
                bladeIcon.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 2:
                uiText.text = "On the touch screen\ntouch the blade icon: ";
                bladeIcon.gameObject.SetActive(true);
                bladeChange.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 3:
                uiText.text = "Select the blade change icon:";
                bladeChange.gameObject.SetActive(true);
                bladeIcon.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
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
                guideViewRenderer.gameObject.SetActive(false);
                uiText.text = "Push the \"|\" button above the white light (AR glow around button?)"; // TODO: Maybe use AR to highlight button?
                break;
            case 7:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Astronaut\" target and tap \"Next\"";    
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 8:
                uiText.text = ""; // "Slide until stop, then tap next
                backPlane.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 9:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Drone\" target under the table and tap \"Next\""; 
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 10:
                uiText.text = ""; // Pull the safety knob and slide table to end (AR)
                backPlane.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 11:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the \"Oxygen\" target and tap \"Next\"";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 12:
                uiText.text = "";
                backPlane.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 13:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Find the Allen key in the tool box"; // TODO: might want to make model of the tool and hover/ spin it
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 14:
                uiText.text = "Find the \"Fissure\" target (may be hidden by blade) and tap \"Next\"";
                guideViewRenderer.gameObject.SetActive(false); 
                break;
            case 15:
                uiText.text = ""; // Loosen the nut on the splitter using short-side of allen key and move it out of the way then tap "next"
                backPlane.gameObject.SetActive(false);
                guideViewRenderer.gameObject.SetActive(false);
                b1.gameObject.SetActive(true);
                b2.gameObject.SetActive(false);
                break;
            case 16:
                // Change AR element on fissure target
                uiText.text = ""; // Loosen locking screw on main spindle using the long-side of allen key and remove. Set aside and tap "next" when complete
                //backPlane.gameObject.SetActive(true);
                guideViewRenderer.gameObject.SetActive(false);
                b1.gameObject.SetActive(false);
                b2.gameObject.SetActive(true);
                break;
            case 17:
                backPlane.gameObject.SetActive(true);
                uiText.text = "Replace blade. \nCAUTION: Blade teeth must face right and blade should be flush against spindle.";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 18:
                uiText.text = "Find the \"Fissure\" target again and tap \"Next\"";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 19:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 20:
                uiText.text = "Tighten lock screw";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 21:
                uiText.text = "Check blade is flush and hand tighten main spindle (AR arrow clockwise)";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 22:
                uiText.text = "Move splitter back, making sure there is enough clearance and tighten"; // TODO: AR wireframe could be used here
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 23:
                uiText.text = "Close the fence \nCheck both sides are secure (AR arrow)";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 24:
                uiText.text = "Slide table back to its original position (AR arrow)";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 25:
                uiText.text = "On the touchscreen, select \"yes\" and select the blade you installed from the database";
                guideViewRenderer.gameObject.SetActive(false);
                break;
            case 26:
                uiText.text = "FIN!";
                break;
            case 27:
                uiText.text = "";
                break;
            case 28:
                uiText.text = "";
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
        if (step > 0)
        {
            step--;
            changeStep();
            Debug.Log(step);
        }
    }

    public void finish()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
