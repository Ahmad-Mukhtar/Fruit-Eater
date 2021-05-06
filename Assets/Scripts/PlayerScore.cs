using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    private Text score;

    private int countscore = 0;
    // Start is called before the first frame update
    void Awake()
    {
        score.text = "0";
    }
 void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag=="Bomb")
        {
            transform.position = new Vector2(0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine(Restartgame());
        }
        if(target.tag=="Fruit")
        {
            target.gameObject.SetActive(false);
            countscore++;
            score.text = countscore.ToString();
        }

    }
    
    IEnumerator Restartgame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
