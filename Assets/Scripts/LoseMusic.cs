﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMusic : MonoBehaviour
{
    public AudioClip loseAudio;

    void Start()
    {
        StartCoroutine(PlayMusic());
    }

    IEnumerator PlayMusic()
    {
        AudioSource.PlayClipAtPoint(
            loseAudio, Camera.main.transform.position);
        yield return new WaitForSeconds(3f);
        gameObject.GetComponent<SceneLoader>().LoadLobbyScene();
    }
}