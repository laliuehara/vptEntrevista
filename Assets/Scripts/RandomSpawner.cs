using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] receitaPrefab;
    [SerializeField] float secondSpawn = 0.0f;
    public List<GameObject> local;

    void Start(){
        StartCoroutine(ReceitaPrefab());
    }

    IEnumerator ReceitaPrefab(){
        while(true){
            var wanted = Random.Range(0, local.Count);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(receitaPrefab[Random.Range(0, receitaPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
