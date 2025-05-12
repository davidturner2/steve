using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changetoscene : MonoBehaviour
{
    public int sdf;
    public void aart(int a)
    {
        StartCoroutine("asdf");
        sdf = a;
    }
    IEnumerator asdf()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sdf);

    }
}
