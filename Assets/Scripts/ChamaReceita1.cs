using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChamaReceita1 : MonoBehaviour
{
    public string spawnPointTag = "Local";
    public List<GameObject> prefabs;
    public bool alwaysSpan = true;
    public static bool contaPontos1;
    public static bool tiraPontos1;
    // Start is called before the first frame update
    void Start()
    {
        contaPontos1 = false;
        tiraPontos1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(FazSanduiche.enterPao == true && FazSanduiche.enterCarne && FazSanduiche.enterAlface){
            contaPontos1 = true;
            FazSanduiche.enterPao = false;
            FazSanduiche.enterCarne = false;
            FazSanduiche.enterAlface = false;
            Debug.Log(contaPontos1);
            
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
            tiraPontos1 = true;
        }
    }
}
