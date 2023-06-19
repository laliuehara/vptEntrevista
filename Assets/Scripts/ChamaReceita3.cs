using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaReceita3 : MonoBehaviour
{
    public string spawnPointTag = "Local";
    public List<GameObject> prefabs;
    public bool alwaysSpan = true;
    public static bool contaPontos3;
    public static bool tiraPontos3; 
    // Start is called before the first frame update
    void Start()
    {
        contaPontos3 = false;
        tiraPontos3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(FazSanduiche.enterPao == true && FazSanduiche.enterQueijo && FazSanduiche.enterAlface){
            contaPontos3 = true;
            FazSanduiche.enterPao = false;
            FazSanduiche.enterQueijo = false;
            FazSanduiche.enterAlface = false;
            FazSanduiche.contador = 0;
            GameObject[] spawnPoints = GameObject.FindGameObjectsWithTag(spawnPointTag);
            foreach (GameObject spawnPoint in spawnPoints)
            {
                for(int i = 0; i<prefabs.Count; i++){                
                GameObject pts = Instantiate(prefabs[i] as GameObject);
                pts.transform.position = spawnPoint.transform.position;
                }
            
            }
            Destroy(gameObject);
        }

        
        if (FazSanduiche.enterCarne == true || FazSanduiche.enterPepperone == true){
            tiraPontos3 = true;
        }
    }
}
