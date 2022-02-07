using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCounter : MonoBehaviour
{
    TMP_Text myText; 
    // Start is called before the first frame update
    void Start()
    {
        myText = GetComponent<TMP_Text>();
        ChangeText();
        GameManager.DeathUpdate.AddListener(ChangeText);
    }

    private void ChangeText()
    {
        myText.text = "Deaths: " + GameManager.death;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
