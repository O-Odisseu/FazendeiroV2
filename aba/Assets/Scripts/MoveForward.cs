using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MoveForward : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction pauseAction;
    private InputAction unpauseAction;
    private bool active = true;
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        if (pauseAction.WasPressedThisFrame())
        {
            active = false;
        }

        if (unpauseAction.WasPressedThisFrame())
        {
            active = true;
        }

        if (active)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }

    private void Awake()
    {
        pauseAction = InputSystem.actions.FindAction("Pause");
        unpauseAction = InputSystem.actions.FindAction("Unpause");
    }
}
