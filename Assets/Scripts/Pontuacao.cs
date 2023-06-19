using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    public static int contaPonto;
    [SerializeField] 
    private TMP_Text pontos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ChamaReceita1.contaPontos1 == true){
            contaPonto += 100;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            ChamaReceita1.contaPontos1 = false;
        }

        if(ChamaReceita2.contaPontos2 == true){
            contaPonto += 100;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            ChamaReceita2.contaPontos2 = false;
        }

        if(ChamaReceita3.contaPontos3 == true){
            contaPonto += 100;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            ChamaReceita3.contaPontos3 = false;
        }

        else if (ChamaReceita2.tiraPontos2 == true){
            contaPonto = contaPonto - 50;
            ChamaReceita2.tiraPontos2 = false;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            
        }

        else if (ChamaReceita1.tiraPontos1 == true){
            contaPonto = contaPonto - 50;
            ChamaReceita1.tiraPontos1 = false;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            
        }

        else if (ChamaReceita3.tiraPontos3 == true){
            contaPonto = contaPonto - 50;
            ChamaReceita3.tiraPontos3 = false;
            pontos.text = Mathf.RoundToInt(contaPonto).ToString();
            
        }
    }
}
