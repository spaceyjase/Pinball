using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
  [SerializeField]
  private GameObject ballPrefab;
  [SerializeField]
  private static int lives = 3;
  [SerializeField]
  private Transform spawnPosition;

  private void Update()
  {
    if (!GameObject.FindGameObjectWithTag("Ball"))
    {
      --lives;
      Instantiate(ballPrefab, spawnPosition.position, ballPrefab.transform.rotation);
    }
  }
}
