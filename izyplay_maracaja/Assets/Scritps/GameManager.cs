using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float coins;

    public TMP_Text coins_txt;

    
    void Start()
    {
        instance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        coins_txt.text = coins.ToString();
    }



  
}
