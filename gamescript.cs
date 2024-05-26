using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamescript : MonoBehaviour
{
    int dikey = 4;
    int yatay = 4;
    public static int beyaz = 0; public static int mavi = 0; public static int mor = 0; public static int yesil=0; 
    public List<GameObject> Yumurtalar;
    public Transform obje;
    float aralik = 1.5f; 
    public static string enCokOlanRenk;
    int enCokOlanSayi;

    public static bool secim;
    public static int kontrol;

    public AudioSource ax;
    public AudioClip[] x;
    private bool sound = false;
   

    private void Start()
    {
        sound = false;
        ax = GetComponent<AudioSource>();
        kontrol = 0;
        secim = false;
        beyaz = 0;
        mavi = 0;
        mor = 0;
        yesil = 0;
        
        for (int x = 0; x < dikey; x++)
        {
            for (int y = 0; y < yatay; y++)
            {
                int i =    Random.Range(0, Yumurtalar.Count);
                GameObject Yumurta = Instantiate(Yumurtalar[i],obje.position + new Vector3(y * aralik, x * aralik, 0), Quaternion.identity);
                Yumurta.tag = Yumurtalar[i].name;
                Yumurta.name = Yumurtalar[i].name;

                switch(i)
                {
                    case 0:  mavi++; break;
                    case 1: beyaz++;  break;
                    case 2: mor++;  break;
                    case 3: yesil++;  break;
                    default: break;

                }
                

            }
        }

        enCokOlanRenk = "beyaz";
        enCokOlanSayi = beyaz;
        if (mavi == enCokOlanSayi)
        {
            kontrol = 2;
        }
        if (mavi > enCokOlanSayi)
        {
            enCokOlanRenk = "mavi";
            enCokOlanSayi = mavi;
        }

        if (mor == enCokOlanSayi)
        {
            kontrol = 2;
        }

        if (mor > enCokOlanSayi)
        {
            enCokOlanRenk = "mor";
            enCokOlanSayi = mor;
        }
        if (yesil == enCokOlanSayi)
        {
            kontrol = 2;
        }

        if (yesil > enCokOlanSayi)
        {
            enCokOlanRenk = "yesil";
            enCokOlanSayi = yesil;
        }
       
        Debug.Log("En cok " + enCokOlanRenk +" " + enCokOlanSayi);
       
    }

    private void Update()
    {
               if(kontrol==1)
        {
            if (secim && !sound)
            {
               
                ax.PlayOneShot(x[0]);
                sound = !sound;
               
            }
          else if (!secim && !sound)

            {
                Debug.Log("Yanlis");
                ax.PlayOneShot(x[1]);
                sound = !sound;
           
            }
        }
              if(kontrol==2)
        {
            GameObject[] toplar = GameObject.FindGameObjectsWithTag("beyaz");
            foreach (GameObject top in toplar)
            {
                Destroy(top);
            }
            toplar = GameObject.FindGameObjectsWithTag("mavi");
            foreach (GameObject top in toplar)
            {
                Destroy(top);
            }
            toplar = GameObject.FindGameObjectsWithTag("mor");
            foreach (GameObject top in toplar)
            {
                Destroy(top);
            }
            toplar = GameObject.FindGameObjectsWithTag("yesil");
            foreach (GameObject top in toplar)
            {
                Destroy(top);
            }
            Start();
        }
    }

 
}
