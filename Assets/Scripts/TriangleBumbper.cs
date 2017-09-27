using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleBumbper : MonoBehaviour
{
  [SerializeField]
  private float force = 100f;

  private void OnTriggerEnter(Collider other)
  {
    Rigidbody rb = other.GetComponent<Rigidbody>();
    if (rb != null)
    {
      rb.AddForce(transform.forward * force);
    }
  }
}
