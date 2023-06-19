using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{

    [SerializeField] 
    private TMP_Text count;
    [SerializeField] 
    private TMP_Text pontuacao;
    public float timer = 120;
    public GameObject fim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         timer -= Time.deltaTime;

        count.text = Mathf.RoundToInt(timer).ToString();

        if(timer <= 0){
            fim.SetActive(true);
            pontuacao.text = Mathf.RoundToInt(Pontuacao.contaPonto).ToString();
            Time.timeScale = 0;
        }
    }

    public void Reiniciar(){
    SceneManager.LoadScene("Jogo");
}
}
