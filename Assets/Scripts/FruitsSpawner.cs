using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] fruitsarr;

    private BoxCollider2D col;
    float x1, x2;
   void Awake()
    {

        col = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - col.size.x / 2;  //getthe corner value of our screen through collider
        x2 = transform.position.x + col.size.x / 2;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnfruit(1f));
    }
    IEnumerator Spawnfruit(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        Instantiate(fruitsarr[Random.Range(0, fruitsarr.Length)], temp, Quaternion.identity);

        StartCoroutine(Spawnfruit(1f));



    }
}
