using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallManager : MonoBehaviour
{
  [SerializeField]
  private GameObject ballPrefab;
  [SerializeField]
  private static int lives = 3;
  [SerializeField]
  private Transform spawnPosition;
  [SerializeField]
  private TextMesh ballsRemaining;

  private bool gameOver = false;

  private void Update()
  {
    if (!gameOver && !GameObject.FindGameObjectWithTag("Ball"))
    {
      --lives;
      if (lives < 0)
      {
        lives = 0;
      }

      if (lives == 0)
      { // shouldn't be here ;)
        ballsRemaining.text = "GAME OVER";
        gameOver = true;
      }
      else
      { // new ball
        Instantiate(ballPrefab, spawnPosition.position, ballPrefab.transform.rotation);
        ballsRemaining.text = string.Empty.PadLeft(lives, '•');
      }
    }

    if (gameOver)
    {
      if (Input.GetKeyDown(KeyCode.R))
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      }
    }
  }
}
