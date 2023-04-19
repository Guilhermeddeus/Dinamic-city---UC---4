using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyer : MonoBehaviour
{
    // Start is called before the first frame update


    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");// guarda o audio source em uma lista 
        if (musicObj.Length > 1)// se tiver mais de um objeto com a tag game music sera destruido para evitar problemas no audio
        {
            Destroy(this.gameObject);// destruindo o obj
        }
        DontDestroyOnLoad(this.gameObject);// para que quando apertar start o audiosource não ser destruido


    }

}
