using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndState : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource rainSource;
    [SerializeField] AudioSource thunderSource;
    [SerializeField] AudioSource JumpScare;
    [SerializeField] ReturnToPlayerState returnToPlayerState;

    void Start(){
        returnToPlayerState.enabled = false;
        rainSource.enabled = false;
        thunderSource.enabled = false;
        JumpScare.PlayDelayed(0.01f);
        StartCoroutine(JumpScareSpawn());
    }
    IEnumerator JumpScareSpawn(){
        yield return new WaitForSeconds(3f);
        audioSource.PlayDelayed(0.1f);
        StartCoroutine(EndGame());
    }
    IEnumerator EndGame(){
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("MainMenu");
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
