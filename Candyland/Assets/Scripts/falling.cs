﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class falling : MonoBehaviour
{
    private void OnCollisionEnter(Collision CollisionInfo)
    {

        if (CollisionInfo.collider.tag == "Player")
        {
                SceneManager.LoadScene("fall");

            }
    }
}