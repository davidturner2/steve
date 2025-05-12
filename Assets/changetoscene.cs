using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changetoscene : MonoBehaviour
{
    public void aart()
    {
        StartCoroutine("asdf");
    }
    IEnumerator asdf()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);

    }
}
