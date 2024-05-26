using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class healthscript : MonoBehaviour
{
    public static int healthsystem;
    public GameObject[] canlar;
    public TextMeshProUGUI text;
    public float time;
    public static float timecarpan;
    public GameObject endgame;
    private void Start()
    {
        endgame.SetActive(false);
        healthsystem = 3;
        time = 60;
        timecarpan = 1;


    }
    private void Update()
    {
        time -=  timecarpan*Time.deltaTime;
        text.text = time.ToString("0");
        switch(healthsystem)
        {
            case 3: canlar[0].SetActive(true);  
                canlar[1].SetActive(true);
                canlar[2].SetActive(true);
                break;
            case 2:
                canlar[0].SetActive(false);
                canlar[1].SetActive(true);
                canlar[2].SetActive(true);
                break;
            case 1:
                canlar[0].SetActive(false);
                canlar[1].SetActive(false);
                canlar[2].SetActive(true);
                break;
            case 0:
                endgame.SetActive(true);
                break;

        }
    }
}
