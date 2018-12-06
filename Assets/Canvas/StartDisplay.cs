using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDisplay : MonoBehaviour
{
    private float duration = 500.0f;
    public GameObject title;
    public GameObject playButton;
    private Image titleImage;
    private Image playbuttonImage;
    private float waitSeconds = 3.0f;
    public GameObject intro;
    private IEnumerator coroutine;
    public GameObject canvasPlay;
    public GameObject canvasStart;
    public GameObject health;
    public GameObject score;
    public GameObject power;
    public GameObject scoreP;
    public GameObject barH;
    public GameObject barP;
    public GameObject barHM;
    public GameObject barPM;
    public GameObject camera;
    public Vector2 posbarH = new Vector2();
    public Vector2 posbarP = new Vector2();
    public Vector2 sizeBar = new Vector2();

    public bool start= false;
    private float barDisplay;

     void Start()
    {
           
            canvasPlay.SetActive(false);

    }


    public void Intro()
    {
        Debug.Log("hello");
        
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
        camera.GetComponent<CameraSplinePathFollower>().enabled= true;
    }



    void Update()
    {
     
    }
}
