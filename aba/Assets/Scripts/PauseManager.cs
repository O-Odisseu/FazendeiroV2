using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PauseManager : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction pauseAction;
    private InputAction unpauseAction;
    public GameObject pause;

    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseAction.WasPressedThisFrame())
        {
            pause.SetActive(true);
        }

        if (unpauseAction.WasPressedThisFrame())
        {
            pause.SetActive(false);
        }
    }

    private void Awake()
    {
        pauseAction = InputSystem.actions.FindAction("Pause");
        unpauseAction = InputSystem.actions.FindAction("Unpause");
    }
}

