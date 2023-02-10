using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Transfert : MonoBehaviour
    {
        
        private Transform _objetsJoueur;
        private Transform _objetsMarchand;

        private void Awake()
        {
            _objetsMarchand = GameObject.FindGameObjectWithTag("Shop").transform;
            _objetsJoueur = GameObject.FindGameObjectWithTag("Inventory").transform;
        }


        public void GoTransfert(GameObject buttonToTransfert)
        {
            if (transform.parent == _objetsMarchand)
            {
                transform.SetParent(_objetsJoueur.transform);
                
                Debug.Log("Objet achete !");
            }
            else if (transform.parent == _objetsJoueur)
            {
                transform.SetParent(_objetsMarchand.transform);
                
                Debug.Log("Objet vendu !");
            }
            
            
        }

    }

