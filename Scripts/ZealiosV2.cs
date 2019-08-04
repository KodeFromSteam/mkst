using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZealiosV2 : MonoBehaviour
{
    public GameObject tildeKey;
    public GameObject oneKey;
    public GameObject twoKey;
    public GameObject threeKey;
    public GameObject fourKey;
    public GameObject fiveKey;
    public GameObject sixKey;
    public GameObject sevenKey;
    public GameObject eightKey;
    public GameObject nineKey;
    public GameObject zeroKey;
    public GameObject minusKey;
    public GameObject equalsKey;
    public GameObject backspaceKey;
    public GameObject tabKey;
    public GameObject qKey;
    public GameObject wKey;
    public GameObject eKey;
    public GameObject rKey;
    public GameObject tKey;
    public GameObject yKey;
    public GameObject uKey;
    public GameObject iKey;
    public GameObject oKey;
    public GameObject pKey;
    public GameObject leftSquareBracketKey;
    public GameObject rightSquareBracketKey;
    public GameObject reverseSlashKey;
    public GameObject capsKey;
    public GameObject aKey;
    public GameObject sKey;
    public GameObject dKey;
    public GameObject fKey;
    public GameObject gKey;
    public GameObject hKey;
    public GameObject jKey;
    public GameObject kKey;
    public GameObject lKey;
    public GameObject colonKey;
    public GameObject apostrapheKey;
    public GameObject enterKey;
    public GameObject shiftKey;
    public GameObject zKey;
    public GameObject xKey;
    public GameObject cKey;
    public GameObject vKey;
    public GameObject bKey;
    public GameObject nKey;
    public GameObject mKey;
    public GameObject commaKey;
    public GameObject periodKey;
    public GameObject slashKey;
    public GameObject rightShiftKey;
    public GameObject spaceKey;

    public AudioSource _as;

    public AudioClip[] zealiosKeyClicks;
    public AudioClip zealiosKeyClickClip;
    public AudioClip[] zealiosOtherKeyClicks;
    public AudioClip zealiosOtherKeyClickClip;

    public AudioClip[] cherryBlueKeyClicks;
    public AudioClip cherryBlueKeyClickClip;
    public AudioClip[] cherryBlueOtherKeyClicks;
    public AudioClip cherryBlueOtherKeyClickClip;

    public AudioClip[] cherryBrownKeyClicks;
    public AudioClip cherryBrownKeyClickClip;
    public AudioClip[] cherryBrownOtherKeyClicks;
    public AudioClip cherryBrownOtherKeyClickClip;

    public AudioClip[] cherryRedKeyClicks;
    public AudioClip cherryRedKeyClickClip;
    public AudioClip[] cherryRedOtherKeyClicks;
    public AudioClip cherryRedOtherKeyClickClip;

    public AudioClip[] kailhJadeKeyClicks;
    public AudioClip kailhJadeKeyClickClip;
    public AudioClip[] kailhJadeOtherKeyClicks;
    public AudioClip kailhJadeOtherKeyClickClip;

    public AudioClip[] blueAlpsKeyClicks;
    public AudioClip blueAlpsKeyClickClip;
    public AudioClip[] blueAlpsOtherKeyClicks;
    public AudioClip blueAlpsOtherKeyClickClip;

    public AudioClip[] fujitsuReedsKeyClicks;
    public AudioClip fujitsuReedsKeyClickClip;
    public AudioClip[] fujitsuReedsOtherKeyClicks;
    public AudioClip fujitsuReedsOtherKeyClickClip;

    public AudioClip[] omronAmbersKeyClicks;
    public AudioClip omronAmbersKeyClickClip;
    public AudioClip[] omronAmbersOtherKeyClicks;
    public AudioClip omronAmbersOtherKeyClickClip;

    public AudioClip[] holyPandasKeyClicks;
    public AudioClip holyPandasKeyClickClip;
    public AudioClip[] holyPandasOtherKeyClicks;
    public AudioClip holyPandasOtherKeyClickClip;

    public AudioClip[] modelMKeyClicks;
    public AudioClip modelMKeyClickClip;
    public AudioClip[] modelMOtherKeyClicks;
    public AudioClip modelMOtherKeyClickClip;

    public AudioClip[] modelFKeyClicks;
    public AudioClip modelFKeyClickClip;
    public AudioClip[] modelFOtherKeyClicks;
    public AudioClip modelFOtherKeyClickClip;

    public AudioClip[] whiteAlpsKeyClicks;
    public AudioClip whiteAlpsKeyClickClip;
    public AudioClip[] whiteAlpsOtherKeyClicks;
    public AudioClip whiteAlpsOtherKeyClickClip;

    public AudioClip[] cherryBlackKeyClicks;
    public AudioClip cherryBlackKeyClickClip;
    public AudioClip[] cherryBlackOtherKeyClicks;
    public AudioClip cherryBlackOtherKeyClickClip;

    public AudioClip[] kailhNavyKeyClicks;
    public AudioClip kailhNavyKeyClickClip;
    public AudioClip[] kailhNavyOtherKeyClicks;
    public AudioClip kailhNavyOtherKeyClickClip;

    public GameObject zealiosv2Button;
    public GameObject cherryBlueButton;
    public GameObject cherryBrownButton;
    public GameObject cherryRedButton;
    public GameObject kailhJadeButton;
    public GameObject blueAlpsButton;
    public GameObject fujitsuReedsButton;
    public GameObject omronAmbersButton;
    public GameObject holyPandasButton;
    public GameObject modelMButton;
    public GameObject modelFButton;
    public GameObject whiteAlpsButton;
    public GameObject cherryBlackButton;
    public GameObject kailhNavyButton;

    void Update()
    {
        if(zealiosv2Button.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, zealiosKeyClicks.Length);
                zealiosKeyClickClip = zealiosKeyClicks[index];
                _as.clip = zealiosKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, zealiosOtherKeyClicks.Length);
                zealiosOtherKeyClickClip = zealiosOtherKeyClicks[index];
                _as.clip = zealiosOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(cherryBlueButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, cherryBlueKeyClicks.Length);
                cherryBlueKeyClickClip = cherryBlueKeyClicks[index];
                _as.clip = cherryBlueKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, cherryBlueOtherKeyClicks.Length);
                cherryBlueOtherKeyClickClip = cherryBlueOtherKeyClicks[index];
                _as.clip = cherryBlueOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(cherryBrownButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, cherryBrownKeyClicks.Length);
                cherryBrownKeyClickClip = cherryBrownKeyClicks[index];
                _as.clip = cherryBrownKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, cherryBrownOtherKeyClicks.Length);
                cherryBrownOtherKeyClickClip = cherryBrownOtherKeyClicks[index];
                _as.clip = cherryBrownOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(cherryRedButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, cherryRedKeyClicks.Length);
                cherryRedKeyClickClip = cherryRedKeyClicks[index];
                _as.clip = cherryRedKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, cherryRedOtherKeyClicks.Length);
                cherryRedOtherKeyClickClip = cherryRedOtherKeyClicks[index];
                _as.clip = cherryRedOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(kailhJadeButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, kailhJadeKeyClicks.Length);
                kailhJadeKeyClickClip = kailhJadeKeyClicks[index];
                _as.clip = kailhJadeKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, kailhJadeOtherKeyClicks.Length);
                kailhJadeOtherKeyClickClip = kailhJadeOtherKeyClicks[index];
                _as.clip = kailhJadeOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(blueAlpsButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, blueAlpsKeyClicks.Length);
                blueAlpsKeyClickClip = blueAlpsKeyClicks[index];
                _as.clip = blueAlpsKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, blueAlpsOtherKeyClicks.Length);
                blueAlpsOtherKeyClickClip = blueAlpsOtherKeyClicks[index];
                _as.clip = blueAlpsOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(fujitsuReedsButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, fujitsuReedsKeyClicks.Length);
                fujitsuReedsKeyClickClip = fujitsuReedsKeyClicks[index];
                _as.clip = fujitsuReedsKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, fujitsuReedsOtherKeyClicks.Length);
                fujitsuReedsOtherKeyClickClip = fujitsuReedsOtherKeyClicks[index];
                _as.clip = fujitsuReedsOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if(omronAmbersButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, omronAmbersKeyClicks.Length);
                omronAmbersKeyClickClip = omronAmbersKeyClicks[index];
                _as.clip = omronAmbersKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, omronAmbersOtherKeyClicks.Length);
                omronAmbersOtherKeyClickClip = omronAmbersOtherKeyClicks[index];
                _as.clip = omronAmbersOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (holyPandasButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, holyPandasKeyClicks.Length);
                holyPandasKeyClickClip = holyPandasKeyClicks[index];
                _as.clip = holyPandasKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, holyPandasOtherKeyClicks.Length);
                holyPandasOtherKeyClickClip = holyPandasOtherKeyClicks[index];
                _as.clip = holyPandasOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (modelMButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, modelMKeyClicks.Length);
                modelMKeyClickClip = modelMKeyClicks[index];
                _as.clip = modelMKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, modelMOtherKeyClicks.Length);
                modelMOtherKeyClickClip = modelMOtherKeyClicks[index];
                _as.clip = modelMOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (modelFButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, modelFKeyClicks.Length);
                modelFKeyClickClip = modelFKeyClicks[index];
                _as.clip = modelFKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, modelFOtherKeyClicks.Length);
                modelFOtherKeyClickClip = modelFOtherKeyClicks[index];
                _as.clip = modelFOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (whiteAlpsButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, whiteAlpsKeyClicks.Length);
                whiteAlpsKeyClickClip = whiteAlpsKeyClicks[index];
                _as.clip = whiteAlpsKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, whiteAlpsOtherKeyClicks.Length);
                whiteAlpsOtherKeyClickClip = whiteAlpsOtherKeyClicks[index];
                _as.clip = whiteAlpsOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (cherryBlackButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, cherryBlackKeyClicks.Length);
                cherryBlackKeyClickClip = cherryBlackKeyClicks[index];
                _as.clip = cherryBlackKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, cherryBlackOtherKeyClicks.Length);
                cherryBlackOtherKeyClickClip = cherryBlackOtherKeyClicks[index];
                _as.clip = cherryBlackOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }

        if (kailhNavyButton.GetComponent<Button>().interactable == false)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                qKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                wKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                eKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                rKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.T))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                tKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Y))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                yKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                uKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                iKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.O))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                oKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                pKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                aKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                sKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                dKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                fKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                gKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                hKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                jKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                kKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                lKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                zKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                xKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                cKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                vKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                bKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                nKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                mKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                oneKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                twoKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                threeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                fourKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                fiveKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                sixKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                sevenKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                eightKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                nineKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                zeroKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Minus))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                minusKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Equals))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                equalsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                backspaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftCurlyBracket))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                leftSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightCurlyBracket))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                rightSquareBracketKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                reverseSlashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Colon))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                colonKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Quote))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                apostrapheKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Period))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                periodKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Comma))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                commaKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Slash))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                slashKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                spaceKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.BackQuote))
            {
                int index = Random.Range(0, kailhNavyKeyClicks.Length);
                kailhNavyKeyClickClip = kailhNavyKeyClicks[index];
                _as.clip = kailhNavyKeyClickClip;
                _as.Play();
                tildeKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                tabKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.CapsLock))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                capsKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                shiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                rightShiftKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                int index = Random.Range(0, kailhNavyOtherKeyClicks.Length);
                kailhNavyOtherKeyClickClip = kailhNavyOtherKeyClicks[index];
                _as.clip = kailhNavyOtherKeyClickClip;
                _as.Play();
                enterKey.GetComponent<SpriteRenderer>().color = new Color(100f, 100f, 100f, 100f);
            }
        }
    }
}
