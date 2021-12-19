using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;




public class GameController : MonoBehaviour
{
    public Button play;
    public Button pvp;
    public Button claim;
    public TextMeshProUGUI comingSoon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void onClickPlay()
    {
        SceneManager.LoadScene("PlayScreen");
    }
    public void onClickPvp()
    {
        comingSoon.enabled = true;   
        //StartCoroutine(falseText());
    }
    public void onClickClaim()
    {
        
        StartCoroutine(falseText());
    }
    IEnumerator falseText()
    {
        yield return new WaitForSeconds(3f);
        
    }
}
