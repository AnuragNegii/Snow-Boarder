using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float levelLoad = 1f;
void OnTriggerEnter2D(Collider2D other) {
    if(other.tag == "Player"){
        Invoke("ReloadScene", levelLoad);
    }
}
    void ReloadScene(){
    SceneManager.LoadScene(0);
    }
}
