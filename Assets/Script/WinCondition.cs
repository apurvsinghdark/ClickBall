using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : Movement
{
    [SerializeField] Transform leftTransform;
    [SerializeField] Transform rightTransform;
    [SerializeField] GameObject winPanel;

    protected override void Start() {
        base.Start();
        
        winPanel.SetActive(false);    
    }
    private void Update() {
        if ((ball.transform.position.x - leftTransform.position.x) <= 0)
        {
            winPanel.SetActive(true);
        }
        if ((ball.transform.position.x - rightTransform.position.x) >= 0) 
        {
            winPanel.SetActive(true);
        }
    }

    public void OnWin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
