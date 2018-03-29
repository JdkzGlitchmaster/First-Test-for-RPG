using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWorld3 : MonoBehaviour {

    public bool isReadyForInput = false;

    // Use this for initialization
    void Start () {
        StartCoroutine(waitForInput());
    }

    IEnumerator waitForInput()
    {
        yield return new WaitForSeconds(1);
        isReadyForInput = true;

    }

    // Update is called once per frame
    void Update () {
        if (Input.anyKeyDown && isReadyForInput)
        {
            SceneManager.LoadScene("Real Main");
        }

    }
}
