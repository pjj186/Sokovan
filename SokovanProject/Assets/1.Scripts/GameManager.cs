using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winUI;
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("Main");
        } 

        if(isGameOver == true) {
            return;
        }

        int count = 0;
        for(int i = 0; i < itemBoxes.Length; i++){
            if(itemBoxes[i].isOveraped == true) {
                count++;
            }
        }

        if(count >= 3) {
            isGameOver = true;
            winUI.SetActive(true);
            Debug.Log("게임 승리");
        }
    }
}
