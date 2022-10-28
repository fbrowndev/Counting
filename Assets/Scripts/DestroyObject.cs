using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Destroying when touching plane
/// </summary>
public class DestroyObject : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
        }
    }
}
