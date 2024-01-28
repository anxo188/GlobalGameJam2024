using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] treeGroupPool;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTreeGroup());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnTreeGroup()
    {
      
        while (true)
        {
            GameObject.Instantiate(treeGroupPool[Random.Range(0,treeGroupPool.Length-1)], this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(Random.Range(0.75f,2));
        }
    }
}
