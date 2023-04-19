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
        SceneManager.LoadScene(indexScene);// para rodar a cena do game
    }

    public void ExitGame()
    {
        Application.Quit();// apertar para sair 
        Debug.Log("Você saiu");
    }

    public void OpenOption()
    {
        Debug.Log("Você Entrou nas opções");
        painelMenuInicial.SetActive(false);// ao apertar no botão de opções desativar a cena de menu
        painelOpcoes.SetActive(true);// ativer a cena de opções
    }

    public void CloseOption()
    {
        Debug.Log("Você saiu das opções");
        painelOpcoes.SetActive(false); // ao apertar o botão de voltar, desativa a cena de opções
        painelMenuInicial.SetActive(true);// ativa a cena de menu novamente 
    }


}
