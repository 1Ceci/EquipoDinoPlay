using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.ThirdPerson;
public class ThirdPerCon : MonoBehaviour
{
    
    public  FixedJoystick          controller;
    private ThirdPersonUserControl _thirdPersonUserControl;
    public  Button                 jump;
    void Start()
    {
        _thirdPersonUserControl = GetComponent<ThirdPersonUserControl>();
    }

    // Update is called once per frame
    void Update()
    {
        _thirdPersonUserControl.h = controller.input.x;
        _thirdPersonUserControl.v = controller.input.y;
    }

    public void onButtonPre()
    {
        _thirdPersonUserControl.m_Jump = true;
    }
}
