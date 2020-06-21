using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionScript : MonoBehaviour
{
    public string nextSceneName;
    public Animator transition;
    public Animator turnAnimation;
    public float transitionTime;

    private void Start()
    {
        gameObject.tag = "SceneChanger";
    }

    
    public IEnumerator SceneTransitionRoutine()
    {
        turnAnimation.SetTrigger("StartDraai");
        yield return new WaitForSeconds(2);
        transition.SetTrigger("Fade");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(nextSceneName);
    }
}
