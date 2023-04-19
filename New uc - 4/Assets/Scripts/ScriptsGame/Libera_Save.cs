using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libera_Save : MonoBehaviour
{
    public GameObject player,banner;
    public Sprite salve, nsalve;
    public bool ativo;
  
    // Start is called before the first frame update

    void Update()
    {
        Salva();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("entro");
            DataControl.podesalva = true;
            //if(DataControl.salvou)
            //{
            //    banner.GetComponent<SpriteRenderer>().sprite = salve;
             

            //}
        }
       
    }
    private void OnTriggerExit2D(Collider2D other)
    {
       

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("saiu");
            DataControl.podesalva = false;
          
        }
       
    }
    //void ActiveSprite()
    //{
    //    if(DataControl.salvou)
    //    {
    //        banner.GetComponent<SpriteRenderer>().sprite = salve;
    //    }
    //    if(!DataControl.podesalva)
    //    {
    //        banner.GetComponent<SpriteRenderer>().sprite = nsalve;
    //    }

    //}
    void Salva()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && DataControl.podesalva)
        {
            PlayerPrefs.SetFloat("x", player.transform.position.x);
            PlayerPrefs.SetFloat("y", player.transform.position.y);
            PlayerPrefs.SetFloat("z", player.transform.position.z);
            DataControl.salvou = true;
            banner.GetComponent<SpriteRenderer>().sprite = salve;
        }
        if (!DataControl.podesalva)
        {
            banner.GetComponent<SpriteRenderer>().sprite = nsalve;
        }
    }
}
