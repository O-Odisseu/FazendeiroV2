using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
public class InvisibleMaterials : MonoBehaviour
{
    public Material farmer;
    //public Color invis;
    private InputAction ghostAction;
    private IEnumerator coroutine;
    private float timer;

    void Start()
    {
        farmer.color = new Color(farmer.color.r, farmer.color.g, farmer.color.b, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ghostAction.WasPressedThisFrame() && timer > 0)
        {
            StartCoroutine("Invisibility");
        }

        timer += Time.deltaTime;
    }

    private void Awake()
    {
        ghostAction = InputSystem.actions.FindAction("Ghost");
    }

    IEnumerator Invisibility()
    {
        farmer.color = new Color(farmer.color.r, farmer.color.g, farmer.color.b, 0.08f);
        timer = 0.0f;
        GetComponent<BoxCollider>().enabled = false;

        yield return new WaitForSeconds(2);

        timer = -5.0f;
        farmer.color = new Color(farmer.color.r, farmer.color.g, farmer.color.b, 1.0f);
        GetComponent<BoxCollider>().enabled = true;
    }
}


