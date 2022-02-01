using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseSceneController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Start() {
        var score = PlayerPrefs.GetInt( "score" );
        _scoreText.text = score.ToString();
    }

    public void RestartGame(){
        SceneManager.LoadScene(1);
    }

    public void QuitToMenu(){
        SceneManager.LoadScene(0);
    }
}
