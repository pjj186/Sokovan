using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

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
            Debug.Log("게임 승리");
        }
    }
}
