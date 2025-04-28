using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class quickanddirty : MonoBehaviour
{
    public TMP_InputField input;
    public TextMeshProUGUI wrong;
    public GameObject unlock;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void asdf(){
                player.SetActive(true);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
            this.gameObject.SetActive(false);

    }

    // Update is called once per frame
   public void toll()
    {
        if(input.text=="1738"){
                player.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
            this.gameObject.SetActive(false);
            Destroy(unlock);
            Destroy(gameObject);
        }
        else if(input.text.Length>=5){
            input.text = "";
            wrong.text = "Wrong number";
        }else{
            wrong.text = "Enter PIN";
        }
    }
}
