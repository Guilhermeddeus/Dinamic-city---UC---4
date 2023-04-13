using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Libera_Save : MonoBehaviour
{
    public GameObject player,banner;
    public Sprite salve, nsalve;
    // Start is called before the first frame update

   private void OnTriggerEnter2D(Collider2D other)
    {
      

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("entro");
            DataControl.podesalva = true;
            if(DataControl.salvou)
            {
                banner.GetComponent<SpriteRenderer>().sprite = salve;
            }
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
}
