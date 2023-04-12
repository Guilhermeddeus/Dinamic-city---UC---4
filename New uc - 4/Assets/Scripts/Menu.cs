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
        Debug.Log("Você saiu");
    }

    public void OpenOption()
    {
        Debug.Log("Você Entrou nas opções");
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void CloseOption()
    {
        Debug.Log("Você saiu das opções");
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }


}
