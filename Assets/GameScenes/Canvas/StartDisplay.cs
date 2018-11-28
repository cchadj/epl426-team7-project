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
    public Vector2 posbarH = new Vector2();
    public Vector2 posbarP = new Vector2();
    public Vector2 sizeBar = new Vector2();
    public Texture progressBarEmpty;
    public Texture progressBarFullH;
    public Texture progressBarFullP;
    private float barDisplay;
    private bool con = false;
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
        intro.GetComponent<CPC_CameraPath>().enabled = true;
        canvasStart.SetActive(false);
        canvasPlay.SetActive(true);
        health = GameObject.Find("/CanvasPlay/Health");
        score = GameObject.Find("/CanvasPlay/Score");
        power = GameObject.Find("/CanvasPlay/Power");
        scoreP = GameObject.Find("/CanvasPlay/ScorePoints");
        score.GetComponent<Image>().CrossFadeAlpha(0, 0f, false);
        scoreP.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        health.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        power.GetComponent<Text>().CrossFadeAlpha(0, 0f, false);
        yield return new WaitForSeconds(waitSeconds + 2);
        score.GetComponent<Image>().CrossFadeAlpha(1, 4f, false);
        scoreP.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        health.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        power.GetComponent<Text>().CrossFadeAlpha(1, 4f, false);
        con = true;
        OnGUI();

    }

    void OnGUI()
    {
        if (con)
        {
            GUI.BeginGroup(new Rect(posbarH.x, posbarH.y, sizeBar.x, sizeBar.y));
            GUI.Box(new Rect(0, 0, sizeBar.x, sizeBar.y), progressBarEmpty);

            GUI.BeginGroup(new Rect(0, 0, sizeBar.x*barDisplay , sizeBar.y));
            GUI.Box(new Rect(0, 0, sizeBar.x, sizeBar.y), progressBarFullH);
            GUI.EndGroup();

            GUI.EndGroup();

            GUI.BeginGroup(new Rect(posbarP.x, posbarP.y, sizeBar.x, sizeBar.y));
            GUI.Box(new Rect(0, 0, sizeBar.x, sizeBar.y), progressBarEmpty);

            GUI.BeginGroup(new Rect(0, 0, sizeBar.x * barDisplay, sizeBar.y));
            GUI.Box(new Rect(0, 0, sizeBar.x, sizeBar.y), progressBarFullP);
            GUI.EndGroup();

            GUI.EndGroup();



        }
    }


    void Update()
    {

        barDisplay = Time.time * 0.07f;
    }
}
