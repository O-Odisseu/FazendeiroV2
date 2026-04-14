using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI pontos;
    public PlayerControllerEx7 player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidas.text = "VIDAS: " + player.vida;
    }
}
