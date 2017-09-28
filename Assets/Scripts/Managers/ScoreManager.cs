using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  [SerializeField]
  private TextMesh scoreDisplay;

  public static int Score { get; set; }

  private void Start()
  {
    Score = 0;
  }

  private void Update()
  {
    if (scoreDisplay != null)
    {
      scoreDisplay.text = Score.ToString("D8");
    }
  }
}
