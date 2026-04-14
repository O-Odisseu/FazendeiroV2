using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string nomedafase;
    [SerializeField] private GameObject painelMenuPrincipal;
    [SerializeField] private GameObject painelOpcoes;

    [SerializeField] private GameObject painelSaida;

    public void Jogar()
    {
        SceneManager.LoadScene(nomedafase);
    }

    public void AbrirOpcoes()
    {
        painelMenuPrincipal.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuPrincipal.SetActive(true);
    }

    public void Saida()
    {
        painelMenuPrincipal.SetActive(false);
        painelSaida.SetActive(true);
    }

    public void FecharSaida()
    {
        painelSaida.SetActive(false);
        painelMenuPrincipal.SetActive(true);
    }

    public void Fechar()
    {
        Application.Quit();
        print("Ok! saindo agora.");
    }
}
