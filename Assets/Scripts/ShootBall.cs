using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
  [SerializeField]
  private float force = 1000f;
  [SerializeField]
  private string buttonName = "Fire1";

  private List<Rigidbody> balls = new List<Rigidbody>();

  private void Update()
  {
    if (Input.GetButtonDown(buttonName))
    {
      foreach (Rigidbody ball in balls)
      {
        ball.AddForce(Vector3.forward * force, ForceMode.VelocityChange);
      }
    }
  }

  private void OnTriggerEnter(Collider other)
  {
    Rigidbody rb = other.GetComponent<Rigidbody>();
    if (rb != null)
    {
      balls.Add(rb);
    }
  }

  private void OnTriggerExit(Collider other)
  {
    Rigidbody rb = other.GetComponent<Rigidbody>();
    if (rb != null)
    {
      balls.Remove(rb);
    }
  }
}
