using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDisplay : MonoBehaviour
{
    private float duration = 500.0f;
    private GameObject title;
    private GameObject playButton;
    private Image titleImage;
    private Image playbuttonImage;
    private float waitSeconds = 3.0f;
    private GameObject intro;
    private IEnumerator coroutine;
    public GameObject canvasPlay;
    public GameObject canvasStart;
    private GameObject health;
    private GameObject score;
    private GameObject power;
    private GameObject scoreP;
    private GameObject barH;
    private GameObject barP;
    private GameObject barHM;
    private GameObject barPM;
    public Vector2 posbarH = new Vector2();
    public Vector2 posbarP = new Vector2();
    public Vector2 sizeBar = new Vector2();
    public Texture progressBarEmpty;
    public Texture progressBarFullH;
    public Texture progressBarFullP;
    public bool start= false;
    private float barDisplay;
 

    public void Start()
    {
        canvasPlay.SetActive(true);
        health = GameObject.Find("/CanvasPlay/Health");
        score = GameObject.Find("/CanvasPlay/Score");
        power = GameObject.Find("/CanvasPlay/Power");
        scoreP = GameObject.Find("/CanvasPlay/ScorePoints");
        barH = GameObject.Find("/CanvasPlay/HealthBar");
        barP = GameObject.Find("/CanvasPlay/PowerBar");
        barHM = GameObject.Find("/CanvasPlay/HealthBarMinus");
        barPM = GameObject.Find("/CanvasPlay/PowerBarMinus");
        canvasPlay.SetActive(false);

    }


    public void Intro()
    {
        intro = GameObject.Find("/CameraIntro");
        playButton = GameObject.Find("/CanvasStart/Play");
        title = GameObject.Find("/CanvasStart/Title");
        titleImage = title.GetComponent<Image>();
        playButton.GetComponent<Button>().enabled = false;
        titleImage.CrossFadeAlpha(0, 2.0f, false);
        playButton.GetComponent<Button>().image.CrossFadeAlpha(0, 2.0f, false);

        coroutine = WaitIntro();
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitIntro()
    {

        yield return new WaitForSeconds(waitSeconds);
        canvasPlay.SetActive(true);
        intro.GetComponent<CPC_CameraPath>().enabled = true;
        canvasStart.SetActive(false);
       
    
        
        score.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        scoreP.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        health.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        power.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        barH.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        barP.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        barHM.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        barPM.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);

        yield return new WaitForSeconds(waitSeconds + 2);
        score.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        scoreP.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        health.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        power.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        barH.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        barP.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        barPM.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        barHM.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        start = true;
    }



    void Update()
    {
        if (start)
        barH.GetComponent<RectTransform>().sizeDelta = new Vector2(100-(Time.time*5), 30);
    }
}
