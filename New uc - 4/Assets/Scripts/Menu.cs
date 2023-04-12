using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void LoadScene(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Voc� saiu");
    }

    public void OpenOption()
    {
        Debug.Log("Voc� Entrou nas op��es");
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void CloseOption()
    {
        Debug.Log("Voc� saiu das op��es");
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }


}
