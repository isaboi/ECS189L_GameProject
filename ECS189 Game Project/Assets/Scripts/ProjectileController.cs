﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private double lifeTime;
    private double currentLife;

    void Awake()
    {
        lifeTime = 0.5;
        currentLife = 0.0;
        GetComponent<Animator>().Play("Player-Projectile");
    }

    void Update()
    {
        if (currentLife < lifeTime)
            currentLife += Time.deltaTime;
        else
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Enemy" || collider.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
