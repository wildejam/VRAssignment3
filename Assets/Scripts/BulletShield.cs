using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShield : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }
}
