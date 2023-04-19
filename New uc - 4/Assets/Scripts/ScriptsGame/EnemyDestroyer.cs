using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Transform ponto;
    float x,y,z;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            x = PlayerPrefs.GetFloat("x");
            y = PlayerPrefs.GetFloat("y");
            z = PlayerPrefs.GetFloat("z");
            ponto.position = new Vector3(x, y, z);
            DataControl.skill = false;
          
       
           player.transform.position = ponto.position;


        }
    }
}
