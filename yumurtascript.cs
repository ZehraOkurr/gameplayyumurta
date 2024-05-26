using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yumurtascript : MonoBehaviour
{
    
    public Vector3 targetPosition;

    public float shakeDuration = 0.5f; 
    public float shakeMagnitude = 0.1f; 
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.localPosition;
    }
    private void Update()
    {
        if (gamescript.secim == true)
        {
            if (this.name == gamescript.enCokOlanRenk)

            {
                transform.position = Vector3.Lerp(transform.position, targetPosition, 2 * Time.deltaTime);
                if (Vector3.Distance(transform.position, targetPosition) < 0.4)
                {
                    gamescript.kontrol = 2;
                }
            }
           
        }
        if(gamescript.kontrol==1)
        {
            if(gamescript.secim==false)
                {
                if (this.name != gamescript.enCokOlanRenk)

                {
                    StartCoroutine(Shake());
                }
            }
        }
    }
       

    
    private IEnumerator Shake()
    {
        float elapsedTime = 0.0f;

        while (elapsedTime < shakeDuration)
        {
        
            float xOffset = Random.Range(-shakeMagnitude, shakeMagnitude);
            
            transform.localPosition = new Vector3(originalPosition.x + xOffset, originalPosition.y, originalPosition.z);

            elapsedTime += Time.deltaTime;

          
            yield return null;
        }

        
        transform.localPosition = originalPosition;
        gamescript.kontrol = 2;

    }



        private void OnMouseDown()
    {
        Debug.Log(gameObject.name);
        if(this.name == gamescript.enCokOlanRenk)

        {
            if(gamescript.kontrol!=1)
            {
                gamescript.kontrol = 1;
                gamescript.secim = true;
                endscript.pointsystem += 1;
            }
           
        }
        else
        {
            if (gamescript.kontrol != 1)
            {
                gamescript.kontrol = 1;
                gamescript.secim = false;
                healthscript.healthsystem--;
                healthscript.timecarpan *= 1.3f;
            }
        }
    }



}                     
