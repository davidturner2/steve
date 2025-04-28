using UnityEngine;
using TMPro;

public class throwItback : MonoBehaviour
{




    public TextMeshProUGUI asdfghj;
public GameObject player;
public GameObject activate;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = 50.07f;
        /*
    Vector3 ra = (transform.position+Vector3.forward)+new Vector3(0f,5f,0f);
            RaycastHit down;

        if (Physics.Raycast(ra, transform.TransformDirection(Vector3.forward), out down, distance))
        {
            Debug.DrawRay(ra, transform.TransformDirection(Vector3.forward) * down.distance, Color.yellow);
            asdfghj.text = down.collider.gameObject.name;
        }
        else
        {
            asdfghj.text ="";
        }
*/


Ray asadsfdg = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit lskdljf;
        if(Physics.Raycast(asadsfdg, out lskdljf,distance)){
            asdfghj.text = lskdljf.collider.gameObject.name;

            if (Input.GetMouseButtonDown(0)){
                if (lskdljf.collider.gameObject.tag == "club"){
                    activate.SetActive(true);
                            Cursor.visible = true;
                            player.SetActive(false);
                Cursor.lockState = CursorLockMode.None;


                }
                asdfghj.text = "Throw player WIP";
                //Destroy(lskdljf.collider.gameObject);
            }
        }else{
            asdfghj.text ="";
        }
    
        
    }
}