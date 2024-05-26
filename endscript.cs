using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class endscript : MonoBehaviour
{
   
    public GameObject[] yildizlar;
    public TextMeshProUGUI point;
    public static int pointsystem;
    private int pointend;
    public static float timecarpan;
    void Start()
    {
        pointend = 0;
    }

    private void Update()
    {
         if(pointsystem >=15)
        {
            pointend = 5;
        }
         else if(pointsystem>=10)
        {
            pointend = 4;
        }
        else if (pointsystem >= 6)
        {
            pointend = 3;
        }
        else if (pointsystem >= 3)
        {
            pointend = 2;
        }
        else if (pointsystem >= 0)
        {
            pointend = 1;
        }
        point.text = pointsystem.ToString("0")+"0" + "\nPOINT";
        switch (pointend)
        {
            case 5:
                yildizlar[0].SetActive(true);
                yildizlar[1].SetActive(true);
                yildizlar[2].SetActive(true);
                yildizlar[3].SetActive(true);
                yildizlar[4].SetActive(true);
                break;
            case 4:
                yildizlar[0].SetActive(true);
                yildizlar[1].SetActive(true);
                yildizlar[2].SetActive(true);
                yildizlar[3].SetActive(true);
                yildizlar[4].SetActive(false);
                break;
            case 3:
                yildizlar[0].SetActive(true);
                yildizlar[1].SetActive(true);
                yildizlar[2].SetActive(true);
                yildizlar[3].SetActive(false);
                yildizlar[4].SetActive(false);
                break;
            case 2:
                yildizlar[0].SetActive(true);
                yildizlar[1].SetActive(true);
                yildizlar[2].SetActive(false);
                yildizlar[3].SetActive(false);
                yildizlar[4].SetActive(false);
                break;
            case 1:
                yildizlar[0].SetActive(true);
                yildizlar[1].SetActive(false);
                yildizlar[2].SetActive(false);
                yildizlar[3].SetActive(false);
                yildizlar[4].SetActive(false);
                break;

        }
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
