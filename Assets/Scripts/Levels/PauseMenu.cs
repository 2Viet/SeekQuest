using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    void CheckInput()
    {
        if(Input.GetKey(KeyCode.P))
        {
            GameState.Pause?.Invoke();
        }

        else if (Input.GetKey(KeyCode.Escape))
        {
            GameState.Resume?.Invoke();
        }
    }

}
