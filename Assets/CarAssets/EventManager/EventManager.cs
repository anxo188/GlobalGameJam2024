using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public Event[] eventPool;
    public TextMeshProUGUI time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnNewEvent());
        StartCoroutine(timer(endPhase));
    }
    IEnumerator spawnNewEvent()
    {
        yield return new WaitForSeconds(3);
        Event toSpawn;
        while(true)
        {
            toSpawn = eventPool[UnityEngine.Random.Range(0, eventPool.Length)];
            toSpawn.startEvent();
            yield return new WaitForSeconds(5);
            
        }
    }

    public IEnumerator timer(Action callback)
    {
        int maxTime = 60;
        for (int i = maxTime; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
        }
        Debug.Log("Tiempo finalizado");
        if (callback != null) callback();
        yield return null;
    }

    public void endPhase()
    {
        Debug.Log("Fin de fase");
        StopAllCoroutines();
        SceneManager.LoadScene("Assets/Scenes/WinScene.unity");
    }
}
