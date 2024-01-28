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
    private List<Event> onCooldownEvent = new List<Event>();
    private int maxEventActiveSimultanealy = 1;
    private int eventActives = 0;
    private bool canSpawnEvent = true;
    public bool generatorActive = true;
    public TextMeshProUGUI time;

    private int hour = 3;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnNewEvent());
        StartCoroutine(timer(endPhase));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnNewEvent()
    {
        Event toSpawn;
        bool validEvent;
        for (int i = 1; i <= 9 ; i++)
        {
                toSpawn = eventPool[UnityEngine.Random.Range(0, eventPool.Length)];
                toSpawn.startEvent();
                
            yield return new WaitForSeconds(5);
            i++;
            time.text = i + ":00";
            
        }
        yield return null;
    }

    public IEnumerator timer(Action callback)
    {
        int maxTime = 45;
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
