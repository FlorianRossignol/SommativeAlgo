﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class SlimeBehaviour : MonoBehaviour
{

    private bool isAlive_ = true;
    private bool followingPlayer_ = false;
    [SerializeField] private float moveSpeed_ = 5.0f;
    [SerializeField] private GameObject player_;
    [SerializeField] private float healPoints = 8.0f;
    
    // Update is called once per frame
    void Update()
    {
        CalculateDamage();
        if (followingPlayer_ == true)
        {
            Chase();
        }
    }

    private void Chase()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, player_.transform.position, moveSpeed_ * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Following Player!");
            followingPlayer_ = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Stopped following Player and moving randomly!");
            followingPlayer_ = false;
        }
    }

    private void Death()
    {
        if (isAlive_== false)
        {
            Destroy(gameObject);
        }
    }

    private void CalculateDamage()
    {
        PlayerAttack playerAttack = GetComponent<PlayerAttack>();
        healPoints = playerAttack.AttackDamage - healPoints;
        if (healPoints <= 0)
        {
            Death();
        }
    }
}
