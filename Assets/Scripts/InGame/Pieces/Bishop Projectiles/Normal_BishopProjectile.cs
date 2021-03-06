﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_BishopProjectile : F_BishopProjectile
{
    private void OnTriggerEnter2D(Collider2D other) {
        //Enemy_Health
        if(Mathf.Pow(2, other.gameObject.layer) == (int)enemyLayer && other.GetComponent<Enemy_Health>() != null){
            Debug.Log("if");
            //Enemy_Health
            GiveDamage(other.GetComponent<Enemy_Health>());
            Destroy(gameObject);
        }
    }
}
