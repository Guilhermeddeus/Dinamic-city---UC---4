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
        Debug.Log("Voc� saiu");
    }

    public void OpenOption()
    {
        Debug.Log("Voc� Entrou nas op��es");
        painelMenuInicial.SetActive(false);// ao apertar no bot�o de op��es desativar a cena de menu
        painelOpcoes.SetActive(true);// ativer a cena de op��es
    }

    public void CloseOption()
    {
        Debug.Log("Voc� saiu das op��es");
        painelOpcoes.SetActive(false); // ao apertar o bot�o de voltar, desativa a cena de op��es
        painelMenuInicial.SetActive(true);// ativa a cena de menu novamente 
    }


}
