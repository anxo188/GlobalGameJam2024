using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject blackCourtain;
    public AudioClip[] clips;

    public AudioSource player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(magicHappens());
    }
    
    private IEnumerator magicHappens()
    {

        player.clip = clips[0];
        player.Play();
        yield return new WaitForSeconds(10);
        player.clip = clips[1];
        player.Play();
        yield return new WaitForSeconds(2);
        blackCourtain.SetActive(false);
        yield return new WaitForSeconds(3);
        blackCourtain.SetActive(true);
        player.clip = clips[2];
        player.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Assets/Scenes/LoseScene.unity");
    }
}
