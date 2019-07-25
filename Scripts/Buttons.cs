using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public GameObject zealiosv2Button;
    public GameObject cherryBlueButton;
    public GameObject cherryBrownButton;
    public GameObject cherryRedButton;
    public GameObject kailhJadeButton;

    public GameObject panel;
    public GameObject cherryButton;
    public GameObject zealButton;
    public GameObject kailhButton;

    public void Zealv2()
    {
        zealiosv2Button.GetComponent<Button>().interactable = false;

        kailhJadeButton.GetComponent<Button>().interactable = true;

        cherryRedButton.GetComponent<Button>().interactable = true;

        cherryBlueButton.GetComponent<Button>().interactable = true;

        cherryBrownButton.GetComponent<Button>().interactable = true;

        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        kailhButton.SetActive(false);
    }

    public void CherryBlue()
    {
        cherryBlueButton.GetComponent<Button>().interactable = false;

        kailhJadeButton.GetComponent<Button>().interactable = true;

        cherryRedButton.GetComponent<Button>().interactable = true;

        zealiosv2Button.GetComponent<Button>().interactable = true;

        cherryBrownButton.GetComponent<Button>().interactable = true;

        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        kailhButton.SetActive(false);
    }

    public void CherryBrown()
    {
        cherryBlueButton.GetComponent<Button>().interactable = true;

        kailhJadeButton.GetComponent<Button>().interactable = true;

        cherryRedButton.GetComponent<Button>().interactable = true;

        zealiosv2Button.GetComponent<Button>().interactable = true;

        cherryBrownButton.GetComponent<Button>().interactable = false;

        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        kailhButton.SetActive(false);
    }

    public void CherryRed()
    {
        cherryRedButton.GetComponent<Button>().interactable = false;

        kailhJadeButton.GetComponent<Button>().interactable = true;

        cherryBlueButton.GetComponent<Button>().interactable = true;

        zealiosv2Button.GetComponent<Button>().interactable = true;

        cherryBrownButton.GetComponent<Button>().interactable = true;

        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        kailhButton.SetActive(false);
    }

    public void KailhJade()
    {
        cherryRedButton.GetComponent<Button>().interactable = true;

        kailhJadeButton.GetComponent<Button>().interactable = false;

        cherryBlueButton.GetComponent<Button>().interactable = true;

        zealiosv2Button.GetComponent<Button>().interactable = true;

        cherryBrownButton.GetComponent<Button>().interactable = true;

        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        kailhButton.SetActive(false);
    }
}
