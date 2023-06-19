using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FazSanduiche : MonoBehaviour
{

    public static bool enterCarne;
    public static bool enterPepperone;
    public static bool enterAlface;
    public static bool enterQueijo;
    public static bool enterPao;

    public static int contador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other){

        Debug.Log("Entrou");
        if(other.gameObject.CompareTag("pao")){
            enterPao = true;
            Debug.Log(enterPao);
            contador++;
            if(contador <= 3){
                Destroy(other.gameObject);
            }
        }
        else if(other.gameObject.CompareTag("salada")){
            enterAlface = true;
            contador++;
            if(contador <= 3){
                Destroy(other.gameObject);
            }
        }
        else if(other.gameObject.CompareTag("pepperone")){
            enterPepperone = true;
            contador++;
            if(contador <= 3){
                Destroy(other.gameObject);
            }
        }
        else if(other.gameObject.CompareTag("queijo")){
            enterQueijo = true;
            contador++;
            if(contador <= 3){
                Destroy(other.gameObject);
            }
        }
        else if(other.gameObject.CompareTag("carne")){
            enterCarne = true;
            contador++;
            if(contador <= 3){
                Destroy(other.gameObject);
            }
        }
    }
}
