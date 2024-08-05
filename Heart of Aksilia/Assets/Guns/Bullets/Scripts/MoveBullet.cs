using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private float bulletSpeed = 1.0f;
    public GameObject player;
    public Vector3 bullet_direction;

    void Start()
    {
        player = GameObject.Find("Kaylo");
        bullet_direction = player.transform.forward;
    }

    void Update()
    {
        transform.Translate(bullet_direction * bulletSpeed * Time.deltaTime);
    }
}
