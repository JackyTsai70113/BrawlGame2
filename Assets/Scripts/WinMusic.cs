﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMusic : MonoBehaviour
{
    public AudioClip winAudio;

    void Start()
    {
        StartCoroutine(PlayMusic());
    }

    // Update is called once per frame
    IEnumerator PlayMusic()
    {
        AudioSource.PlayClipAtPoint(
            winAudio, Camera.main.transform.position);
        yield return new WaitForSeconds(winAudio.length);
        gameObject.GetComponent<SceneLoader>().LoadLobbyScene();
    }
}