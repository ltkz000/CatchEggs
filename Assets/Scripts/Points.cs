using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public int points;
    public int health;
    TextMeshProUGUI TEXT;

    void Start(){
        TEXT = FindObjectOfType<TextMeshProUGUI>();
        points = 0;
        health = 3;
    }

    private void Lose(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Fruits")){
            points++;
        }else if(collision.gameObject.CompareTag("Trap")){
            points--;
            health--;
        }
        Destroy(collision.gameObject);
        TEXT.text = "Health: " + health.ToString()
                    + "\n\nPoints: " + points.ToString();

        if(health == 0){
            Lose();
        }
    }
}
