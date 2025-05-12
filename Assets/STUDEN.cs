using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;

public class STUDEN : MonoBehaviour
{    
    NavMeshAgent agent;
    public bool aaa = false;
    public bool n = true;
    int walkto;
    public GameObject locations;
    public Transform[] goals;
    Animator a;
    public int message;
    void Awake()
    {
        //set goal to the transform position
        // get the navmesh ageny
        agent = GetComponent<NavMeshAgent>();

    }
    void Start()

    {        
        goals = new Transform[locations.transform.childCount];
        for (int i = 0; i < locations.transform.childCount; i++)
        {
            goals[i] = locations.transform.GetChild(i);
        }
        
        
            walkto = Random.Range(0,goals.Length);
        a = GetComponent<Animator>();
        a.SetBool("walk", true);
        aaa = true;
       // agent.destination = transform.position;
        //StartCoroutine("wait");
    }
    void randomize()
    {
        int f = Random.Range(0, goals.Length);
        if (f == walkto)
        {
            randomize();
        }
        else
        {
            walkto = f;
            a.SetBool("walk", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "goal")
        {
            a.SetBool("walk", false);
            StartCoroutine("wait");
        }
    }
    public void ask()
    {
        if(aaa){
        agent.destination = transform.position;
        }
        aaa = false;

        a.SetBool("ask", true);

    }

    public void bye()
    {
        if(n){
        aaa = true;
        }
        a.SetBool("ask", false);
    }
        // Update is called once per frame
        void Update()
    {
        if (aaa)
        {
            agent.destination = goals[walkto].position;
        }
        else
        {
            a.SetBool("walk", false);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(Random.Range(0,12f));
        randomize();
    }
}
