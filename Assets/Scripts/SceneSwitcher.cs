using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Animator transition;

    public void Start()
    {
        transition = FindObjectOfType<Animator>();
    }

    public void SwitchScene(string sceneName)
    {
        StartCoroutine(Switch(sceneName));
    }

    IEnumerator Switch(string scene)
    {
        Debug.Log("Switching Scene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(scene);
    }
}
