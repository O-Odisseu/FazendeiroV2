using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public PlayerControllerEx7 player;
    public bool colissioncheck = false;
    // Update is called once per frame
    void Update()
    {
        colissioncheck = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            
            colissioncheck = true;
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
