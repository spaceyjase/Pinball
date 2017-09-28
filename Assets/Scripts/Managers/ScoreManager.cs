using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  public static int Score { get; set; }

  private void Start()
  {
    Score = 0;
  }

  private void OnGUI()
  {
    GUILayout.Label("Score: " + Score.ToString());
  }
}
