using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
  public float fadeDuration = 1f;
  public GameObject player;

  void OnTriggerEnter(Collider other) {
    if (other.gameObject == player)
      {

      }
  }
}
