using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class survey : MonoBehaviour
{
    public TMP_InputField abc;
    public GameObject lose;

    public string asdfg = "192134";
    public int a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

public void check(){
    if (abc.text == asdfg){
        SceneManager.LoadScene(3);
    }else{
        lose.SetActive(true);
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
