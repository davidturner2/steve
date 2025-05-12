using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UIElements;
using UnityEngine.AI;

public class throwItback : MonoBehaviour
{

public bool bouttothrow = false;
public bool cantrhow;


    public TextMeshProUGUI asdfghj;
public GameObject player;
public GameObject ahh;
public GameObject activate;
    public AudioSource throwsound;
private GameObject throwme;
    private bool firsttime = true;
    private bool nottalking = true;
    public GameObject talk;
    public TextMeshProUGUI studentme;

    public GameObject[] disabletheese;
    public GameObject[] enabletheese;
    public GameObject csript;
    int studentm;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            foreach (GameObject go in disabletheese)
            {
                Destroy(go);
            }
            foreach (GameObject go in enabletheese)
            {
                go.SetActive(true);
            }
            csript.GetComponent<FirstPersonLook>().enabled = false;
            UnityEngine.Cursor.visible = true;
            UnityEngine.Cursor.lockState = CursorLockMode.None;
            GetComponent<Animator>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = 27.07f;

        if (bouttothrow){           
            if (throwme==null){
                bouttothrow = false;
                cantrhow = false;
            }else{
                throwme.transform.position = ahh.transform.position;
            }
            if (Input.GetMouseButtonUp(0))
            {
                if (cantrhow == false)
                {
                    cantrhow = true;
                }
                
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
            throwsound.Play();
               // throwme.GetComponent<Collider>().isTrigger = true;
                        throwme.GetComponent<Rigidbody>().AddForce(Camera.main.transform.rotation*Vector3.forward*4000);
                        bouttothrow = false;
                       
            firsttime = false;


}

        if (Input.GetMouseButtonUp(0))
        {
            if (cantrhow == true&& bouttothrow==false)
            {
                cantrhow = false;
            }

        }


        Ray asadsfdg = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit lskdljf;
        if (Physics.Raycast(asadsfdg, out lskdljf, distance))
        {



            if (lskdljf.collider.gameObject.tag == "club")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    activate.SetActive(true);
                    UnityEngine.Cursor.visible = true;
                    csript.GetComponent<FirstPersonLook>().enabled = false;
                    UnityEngine.Cursor.lockState = CursorLockMode.None;
                }
                asdfghj.text = "Click to enter pin";


            }
            else if (lskdljf.collider.gameObject.tag == "Student")
            {
                if (bouttothrow == false && cantrhow == false && nottalking)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        lskdljf.collider.gameObject.GetComponent<STUDEN>().aaa = false;
                        lskdljf.collider.gameObject.GetComponent<STUDEN>().n = false;
                        Destroy(lskdljf.collider.gameObject.GetComponent<NavMeshAgent>());
                        throwme = lskdljf.collider.gameObject;
                        throwme.GetComponent<Rigidbody>().freezeRotation = true;
                        throwme.transform.rotation = Quaternion.identity;
                        throwme.transform.parent = ahh.transform;
                        asdfghj.text = "";
                        bouttothrow = true;
                    }
                    else if (Input.GetKeyDown("e"))
                    {
                        nottalking = false;
                        studentme.text = "Student: In bed last night I was doing the number '"+studentm+"' ";
                        throwme = lskdljf.collider.gameObject;
                        studentm = lskdljf.collider.gameObject.GetComponent<STUDEN>().message;
                        lskdljf.collider.gameObject.GetComponent<STUDEN>().ask();
                        asdfghj.text = "";
                        talk.SetActive(true);
                        csript.GetComponent<FirstPersonLook>().enabled = false;
                        UnityEngine.Cursor.visible = true;
                        UnityEngine.Cursor.lockState = CursorLockMode.None;
                        print("ASDFG");
                    }
                    asdfghj.text = "Click to grab, press E to talk";
                }

            }else if (lskdljf.collider.gameObject.tag == "Animal")
            {
                if (bouttothrow == false && cantrhow == false && nottalking)
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        throwme = lskdljf.collider.gameObject;
                        throwme.GetComponent<Rigidbody>().freezeRotation = true;
                        throwme.transform.rotation = Quaternion.identity;
                        throwme.transform.parent = ahh.transform;
                        asdfghj.text = "";
                        bouttothrow = true;
                    }                 
                    asdfghj.text = "Click to grab";
                }
            }


            //Destroy(lskdljf.collider.gameObject);

        }
        else
        {
            if (firsttime && cantrhow)
            {
                asdfghj.text = "Click to throw at steve to slow him down";
            }
            else
            {
                asdfghj.text = "";
            }
        }
    
        
    }

    public void okthen()
    {
        nottalking = true;
        if (throwme==null){

        }
        else{
            throwme.GetComponent<STUDEN>().bye();
        }
        csript.GetComponent<FirstPersonLook>().enabled = true;
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
}