using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaReceita2 : MonoBehaviour
{
    public string spawnPointTag = "Local";
    public List<GameObject> prefabs;
    public bool alwaysSpan = true;
    public static bool contaPontos2;
    public static bool tiraPontos2;
    // Start is called before the first frame update
    void Start()
    {
        contaPontos2 = false;
        tiraPontos2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(FazSanduiche.enterPao == true && FazSanduiche.enterPepperone && FazSanduiche.enterAlface){
            contaPontos2 = true;
            FazSanduiche.enterPao = false;
            FazSanduiche.enterPepperone = false;
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

        if (FazSanduiche.enterQueijo == true){
            tiraPontos2 = true;
        }
    }
    
}
