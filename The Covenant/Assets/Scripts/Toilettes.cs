using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Toilettes : MonoBehaviour
{
        public GameObject buttonT;
        public Animation abattant;
        public AudioSource audiosource3;
        public AudioClip toilettes;

        // Start is called before the first frame update
        void Start()
        {
            buttonT.SetActive(false);
        }
    
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.T))
            {
                abattant.Play();
                audiosource3.PlayOneShot(toilettes);
            }
        }
    
        private void OnTriggerStay(Collider player)
        {
            buttonT.SetActive(true);
        }
    
        void OnTriggerExit(Collider player)
        {
            buttonT.SetActive(false);
        }
}
