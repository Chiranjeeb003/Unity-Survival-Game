using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    public float health;
    public Slider slider;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        slider.value = health;                           //syncing value of slider with player health
        text.text = "Health : " + health;                  //syncing text with player health

    }
    //Function which detects collision
    void OnCollisionEnter(Collision obj)
    {
        //checking whether object tagged Enemy is collided
      
        if (obj.gameObject.tag == "Enemy")
        {
            health = health - 10f;
        }

        if (obj.gameObject.tag == "Watercollider")
        {
            health = health - 100f;
           
        }



       if (obj.gameObject.CompareTag ("healthkit"))
            {

                health = health + 30f;
                Destroy(obj.gameObject);
            }

        if (health==0)
        {
            Cursor.visible = false;
            SceneManager.LoadScene("game over UI");
           
        }
       
    }

}

