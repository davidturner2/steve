using UnityEngine;
using TMPro;
using System.Collections;

public class throwItback : MonoBehaviour
{

private bool bouttothrow = false;
bool cantrhow;


    public TextMeshProUGUI asdfghj;
public GameObject player;
public GameObject ahh;
public GameObject activate;
private GameObject throwme;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = 50.07f;

        if (bouttothrow){
            if (throwme==null){
                bouttothrow = false;
                cantrhow = false;
            }else{
                throwme.transform.position = ahh.transform.position;
            }
        }
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
if (Input.GetMouseButton(0)&&bouttothrow&&cantrhow){
                throwme.transform.parent = null;
                    throwme.GetComponent<Rigidbody>().freezeRotation = false;
                    throwme.GetComponent<Collider>().isTrigger = false;

               // throwme.GetComponent<Collider>().isTrigger = true;
                        throwme.GetComponent<Rigidbody>().AddForce(Camera.main.transform.rotation*Vector3.forward*4000);
                        bouttothrow = false;
                        StartCoroutine("asdf");
        
}


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


                }else if(lskdljf.collider.gameObject.tag == "Student"){
                    if(bouttothrow == false && cantrhow==false){
                    throwme = lskdljf.collider.gameObject;
                    throwme.GetComponent<Rigidbody>().freezeRotation = true;
                    throwme.transform.rotation = Quaternion.identity;
                    throwme.transform.parent = ahh.transform;

                    StartCoroutine("asdf");
                    bouttothrow = true;
                    }
                   
                }

                asdfghj.text = "Throw player WIP";
                //Destroy(lskdljf.collider.gameObject);
            }
        }else{
            asdfghj.text ="";
        }
    
        
    }

    IEnumerator asdf(){
    yield return new WaitForSeconds(1f);
    cantrhow = !cantrhow;
    }

}