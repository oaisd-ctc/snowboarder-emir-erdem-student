using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeToRestart = 1f; 

    [SerializeField] ParticleSystem finishEffect;

    [SerializeField] AudioClip audioEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", timeToRestart);
        }
    }


    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
