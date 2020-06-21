using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 2f) && Input.GetMouseButtonDown(0))
        {
            if(hit.transform.tag == "SceneChanger")
            {
                Debug.Log("hit boui");
                SceneTransitionScript sceneTransitionScript = hit.transform.gameObject.GetComponent<SceneTransitionScript>();
                StartCoroutine(sceneTransitionScript.SceneTransitionRoutine());
            }
        }
    }
}
