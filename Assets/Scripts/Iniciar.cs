using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public bool ativado;
    public GameObject menu;
    public GameObject inter;
  

    

    [SerializeField] 
    private TMP_Text count;
    public GameObject panelCount;
    public float timer = 3;
    public bool isRunning;

    

void Start(){
      menu.SetActive(true);
      inter.SetActive(false);
      Time.timeScale = 0;
      
   }

void Update(){

    if(ativado == true){
        menu.SetActive(true);
    }
    else{
        menu.SetActive(false);
    }

    if (isRunning)
    {
        timer -= Time.deltaTime;
        panelCount.SetActive(true);
        
        //GetComponent<Text>().text = "Tempo: " + Mathf.RoundToInt(timer).ToString() + " s";
        count.text = Mathf.RoundToInt(timer).ToString();
    
        if (timer < 0){
            isRunning = false;
            ativado = false;
            inter.SetActive(true);
            
        }
    }

    
}
public void Botao(){
    
    isRunning =true;
    Time.timeScale = 1;

    
}


}
