using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    [SerializeField] GameObject[] fruitPrefabs;

    [SerializeField] float secondSpawn = 0.5f;

    [SerializeField] float minTras;

    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FruitSpawn());
    }

    IEnumerator FruitSpawn(){
        while(true){
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(fruitPrefabs[Random.Range(0, fruitPrefabs.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
