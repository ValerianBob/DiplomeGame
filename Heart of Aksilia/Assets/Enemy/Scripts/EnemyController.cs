using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int HitPoints=10;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("Hit");
            HitPoints--;
            if (HitPoints <= 0)
            {
                Destroy(gameObject);
                Debug.Log("Crip Ubit");
            }
            Destroy(other.gameObject);
        }
    }
}
