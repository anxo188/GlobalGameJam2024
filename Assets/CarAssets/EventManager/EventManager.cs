using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Event[] eventPool;
    private List<Event> onCooldownEvent = new List<Event>();
    private int maxEventActiveSimultanealy = 3;
    private int eventActives = 0;
    private bool canSpawnEvent = true;
    public bool generatorActive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(spawnNewEvent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawnNewEvent()
    {
        Event toSpawn;
        bool validEvent;
        while (generatorActive)
        {
            if (eventActives <= maxEventActiveSimultanealy)
            {
                validEvent = false;
                while (!validEvent)
                {
                    toSpawn = eventPool[Random.Range(0, eventPool.Length)];
                    Debug.Log("Spawn Event");
                    if (!onCooldownEvent.Contains(toSpawn))
                    {
                        validEvent = true;
                        onCooldownEvent.Add(toSpawn);
                    }
                }

                eventActives++;
            }

            yield return new WaitForSeconds(5);
        }

        yield return null;
    }
}
