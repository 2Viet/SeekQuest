using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpMEnu : MonoBehaviour
{

    [SerializeField] private GameObject HelpModule;
    private bool _IsHelpOn;

    public delegate void ToggleMenu();
    public static ToggleMenu toggleOn;
    public static ToggleMenu toggleOff;


    void Awake()
    {
        toggleOn += ToggleOn;
        toggleOff += ToggleOff;
        HelpModule.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        _IsHelpOn = false;  
    }

    // Update is called once per frame
    void Update()
    {
        ToggleChecker();

        if(Input.GetKey(KeyCode.H))
        {
            toggleOff?.Invoke();
        }
    }


    private bool SetToggle(bool value)
    {
        _IsHelpOn = value;
        return _IsHelpOn;
    }


    public void ToggleOn()
    {
        SetToggle(true);
    }

    public void ToggleOff()
    {
        SetToggle(false);
    }


    void ToggleChecker()
    {
        if(_IsHelpOn)
        {
            HelpModule.SetActive(true);
            
        }
        else
        {
            HelpModule.SetActive(false);
        }
    }
}
