using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
   
   private AudioSource source;

   public AudioClip cionSound;

      void Awake ()
      {
        source = GetComponent<AudioSource>();
      }
      
      void OnTriggerEnter2D (Collider2D collider)

             {
                if(collider.gameObject.tag == "Player")
                {
                    source.PlayOneShot(cionSound);
                    Destroy(gameObject,0.5F);
                }

             }
}