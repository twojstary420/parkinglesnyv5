using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject winScreenUI;

    // Start is called before the first frame update
    void Start()
    {
        winScreenUI.SetActive(false);
    }

    public void ShowWinScreen()
    {
        winScreenUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
