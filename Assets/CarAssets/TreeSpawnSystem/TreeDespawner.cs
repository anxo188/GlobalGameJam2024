using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDespawner : MonoBehaviour
{
  public void OnTriggerEnter(Collider other)
  {
    GameObject.Destroy(other.gameObject);
  }
}
