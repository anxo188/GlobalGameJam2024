using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerSpawner : MonoBehaviour
{
    public GameObject beerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBeer());
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    IEnumerator SpawnBeer()
    {
        float timeBetweenSpawns = 1.6f;
        for(int i = 0; i < 200;i++)
        {
            GameObject newBeer = GameObject.Instantiate(beerPrefab, this.transform.position, this.transform.rotation);
            newBeer.transform.localScale = new Vector3(2,2,2);
            if (i % 3 == 0 && timeBetweenSpawns > 0.4f)
            {
                timeBetweenSpawns -= 0.15f;
            }
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
        yield return null;
    }
    
    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<BeerBehaviour>() != null)
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
