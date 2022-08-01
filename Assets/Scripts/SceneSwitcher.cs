using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneSwitcher : MonoBehaviour
{
    public Animator transition;
    public bool isWalkthrough;
    public string newSceneName;
    private SceneSwitcher sceneSwitcher;
    [SerializeField] private VideoPlayer videoPlayer;

    public void Start()
    {
        videoPlayer = FindObjectOfType<VideoPlayer>();
        sceneSwitcher = FindObjectOfType<SceneSwitcher>();
        videoPlayer.loopPointReached += EndReached;

        Animator[] objects = FindObjectsOfType<Animator>();
        for (int i = 0; i < objects.Length; i++)
        {
            if (objects[i].gameObject.name == "Image")
            {
                transition = objects[i];
                return;
            }
        }
    }

    public void SwitchScene(string sceneName)
    {
        Debug.Log("Switching Scenes");
        StartCoroutine(Switch(sceneName));
    }

    void EndReached(VideoPlayer vp)
    {
        if (isWalkthrough)
        {
            sceneSwitcher.SwitchScene(newSceneName);
        }
    }

    IEnumerator Switch(string scene)
    {
        Debug.Log("Switching Scene");
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(scene);
    }
}
