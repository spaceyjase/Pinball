using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
  [SerializeField]
  private float force = 100.0f;
  [SerializeField]
  private float radius = 1.0f;
  [SerializeField]
  private float forceRadius = 1.0f;

  private void OnCollisionEnter(Collision collision)
  {
    foreach (Collider col in Physics.OverlapSphere(transform.position, radius))
    {
      Rigidbody rb = col.GetComponent<Rigidbody>();
      if (rb != null)
      {
        rb.AddExplosionForce(force, transform.position, forceRadius);
      }
    }
  }
}
