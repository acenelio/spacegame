using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public float waitTime = 3f;
    public string nextScene;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Next());
    }

    IEnumerator Next()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(nextScene);
    }
}
