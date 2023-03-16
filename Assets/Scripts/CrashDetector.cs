using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeToRestart = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground" && hasCrashed == false)
        {
            hasCrashed = true;
            finishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            hasCrashed = true;
            Invoke("ReloadScene", timeToRestart);     
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
