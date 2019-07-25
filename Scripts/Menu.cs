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

    public GameObject zealiosv2Button;
    public GameObject cherryBlueButton;
    public GameObject cherryBrownButton;
    public GameObject cherryRedButton;
    public GameObject kailhJadeButton;

    private void Start()
    {
        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
    }

    public void OpenMenu()
    {
        panel.SetActive(true);
        cherryButton.SetActive(true);
        zealButton.SetActive(true);
        kailhButton.SetActive(true);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
    }

    public void BackFromMenu()
    {
        panel.SetActive(false);
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
    }

    public void Cherry()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(true);
        cherryBrownButton.SetActive(true);
        cherryRedButton.SetActive(true);
        kailhJadeButton.SetActive(false);
    }

    public void Zeal()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        zealiosv2Button.SetActive(true);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(false);
    }

    public void Kailh()
    {
        cherryButton.SetActive(false);
        zealButton.SetActive(false);
        kailhButton.SetActive(false);
        zealiosv2Button.SetActive(false);
        cherryBlueButton.SetActive(false);
        cherryBrownButton.SetActive(false);
        cherryRedButton.SetActive(false);
        kailhJadeButton.SetActive(true);
    }
}
