using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject panel;
    public GameObject cherryButton;
    public GameObject zealButton;
    public GameObject kailhButton;
    public GameObject alpsButton;
    public GameObject fujitsuButton;
    public GameObject omronButton;

    public GameObject zealiosv2Button;
    public GameObject cherryBlueButton;
    public GameObject cherryBrownButton;
    public GameObject cherryRedButton;
    public GameObject kailhJadeButton;
    public GameObject blueAlpsButton;
    public GameObject fujitsuReedsButton;
    public GameObject omronAmbersButton;

    private void Start()
    {
        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        omronButton.SetActive(false);
        fujitsuButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void OpenMenu()
    {
        panel.SetActive(true);
        cherryButton.SetActive(true);
        zealButton.SetActive(true);
        kailhButton.SetActive(true);
        alpsButton.SetActive(true);
        fujitsuButton.SetActive(true);
        omronButton.SetActive(true);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void BackFromMenu()
    {
        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void Cherry()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(true);
        cherryBrownButton.SetActive(true);
        cherryRedButton.SetActive(true);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void Zeal()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(true);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void Kailh()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(true);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void Alps()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(true);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(false);
    }

    public void Fujitsu()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(true);
        omronAmbersButton.SetActive(false);
    }

    public void Omron()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        alpsButton.SetActive(false);
        fujitsuButton.SetActive(false);
        omronButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
        blueAlpsButton.SetActive(false);
        fujitsuReedsButton.SetActive(false);
        omronAmbersButton.SetActive(true);
    }
}
