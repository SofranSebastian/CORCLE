using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BallEventsController : MonoBehaviour
{
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText; 

    private void Awake() {
        _score = 0;
    }
    
    private void OnTriggerEnter2D(Collider2D collision) {
        if( collision.gameObject.CompareTag("Bonus") ){
            _score = _score + 1;
            _scoreText.text = _score.ToString();
            Destroy( collision.gameObject );
        }

        if( collision.gameObject.CompareTag("Enemy") ){
            PlayerPrefs.SetInt( "score", _score );
            SceneManager.LoadScene(2);
            Destroy( collision.gameObject );
        }

        // destroys the object which collides with this one -> Destroy( collision.gameObject );
    }
}
