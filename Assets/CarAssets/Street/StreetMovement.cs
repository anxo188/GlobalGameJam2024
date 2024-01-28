using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetMovement : MonoBehaviour
{
    public Material street;
   
    public float speed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            street.mainTextureOffset = new Vector2(street.mainTextureOffset.x + speed*Time.deltaTime,0f);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }
}
