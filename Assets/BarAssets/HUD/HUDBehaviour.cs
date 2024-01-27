using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDBehaviour : MonoBehaviour
{
    public Text time;

    public Image beerBar;
    public Text drinkedBeers;
    private int drinkedBeersCount = 0;
    public Image clock;

    private bool blinking = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(timerHUD(endPhase));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timerHUD(Action callback)
    {
        int maxTime = 30;
        int blinkTime = 7;
        float blinkFrecuency = 0.15f;
        
        for (int i = maxTime; i >= 0; i--)
        {
            time.text = i.ToString();
            yield return new WaitForSeconds(1);
            if (i <= blinkTime && blinking == false)
            {
                blinking = true;
                StartCoroutine(blinkClock(blinkFrecuency));
            }
        }
        Debug.Log("Tiempo finalizado");
        if (callback != null) callback();
        yield return null;
    }

    public void fillBar()
    {
        beerBar.fillAmount += 0.05f;
        drinkedBeersCount += 1;
        drinkedBeers.text = drinkedBeersCount.ToString();
    }

    public IEnumerator blinkClock(float waitTime)
    {
        while (true)
        {
            clock.transform.localScale += new Vector3(0.15f,0.15f,0.15f);
            yield return new WaitForSeconds(waitTime);
            clock.transform.localScale += new Vector3(0.15f,0.15f,0.15f);
            yield return new WaitForSeconds(waitTime);
            clock.transform.localScale -= new Vector3(0.15f,0.15f,0.15f);
            yield return new WaitForSeconds(waitTime);
            clock.transform.localScale -= new Vector3(0.15f,0.15f,0.15f);
        }
    }

    void endPhase()
    {
        StopAllCoroutines();
        if (drinkedBeersCount == 0)
        {
            //BARMAN KICKS YOU OUT 
            Debug.Log("Fuera!!! no has bebido");
        }else if (drinkedBeersCount > 0 && drinkedBeersCount < 25)
        {
            //BAJA BORRACHERA
            Debug.Log("Aguantaría todo el día");
        }else if (drinkedBeersCount >= 25)
        {
            //VAS LIADO
            Debug.Log("Quien es Juan?");
        }
        PlayerPrefs.SetInt("drinkedBeersCount",drinkedBeersCount);
        SceneManager.LoadScene("Assets/Scenes/CarScene.unity");
            
    }
}
