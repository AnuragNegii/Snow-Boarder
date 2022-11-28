using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float levelLoad = 1f;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] AudioClip crasSFX;
    bool gotHit;
    void OnTriggerEnter2D(Collider2D other) {
          if(other.tag == "object" && !gotHit){
            gotHit = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashParticle.Play();
            GetComponent<AudioSource>().PlayOneShot(crasSFX);
            Invoke("ReloadScene", levelLoad);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
