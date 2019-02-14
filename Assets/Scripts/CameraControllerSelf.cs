﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerSelf : MonoBehaviour 
{
    Vector3 PlayerToCameraPos;
    PlayerBody playerBody;

    float rotX = 53.322f;

    void Start () 
    {
        SetPlayerBody();
        //transform.position = Vector3.zero;
        //StartCoroutine(printSth());
        if (playerBody != null)
            PlayerToCameraPos = transform.position - new Vector3(0, 0, -130);
        transform.rotation = Quaternion.Euler(rotX, 0, 0);
    }

    void Update () 
    {
        Move();
	}

    public void SetPlayerBody()
    {
        playerBody = FindObjectOfType<PlayerBody>();
    }

    void Move()
    {
        if (playerBody != null)
        {
            Vector3 targetPos = playerBody.transform.position +
            PlayerToCameraPos;
            if (playerBody.transform.position.z > 120)
                targetPos = new Vector3(0, 0, 120) + PlayerToCameraPos;
            else if (playerBody.transform.position.z < -120)
                targetPos = new Vector3(0, 0, -120) + PlayerToCameraPos;
            targetPos = new Vector3(0, targetPos.y, targetPos.z);
            transform.position = targetPos;
        }
    }
}