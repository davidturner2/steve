using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class killplayer2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("asdf");
    }
IEnumerator asdf(){
    yield return new WaitForSeconds(4f);
                                    SceneManager.LoadScene(1);

}
    // Update is called once per frame
    void Update()
    {
       
    }
}
