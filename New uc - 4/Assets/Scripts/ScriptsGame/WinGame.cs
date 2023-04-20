using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    
    

    // Start is called before the first frame update

   

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "Player")
        {

            SceneManager.LoadScene("Win");
        }

    }
   
}
