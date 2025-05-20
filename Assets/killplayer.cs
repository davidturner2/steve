using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
public class killplayer : MonoBehaviour
{
     public Transform goal;
    NavMeshAgent agent;
    public bool aaa = false;

    public AudioSource chase;
    public AudioSource ambience;
    //public AudioSource footsteps;
     IEnumerator a(){
        // slow down for
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(6f);
        aaa = true;
    }
    // Start is called before the first frame update
    void Awake()
    {
        //set goal to the transform position
        // get the navmesh ageny
        agent = GetComponent<NavMeshAgent>();
       
    }
    void Start()
    {
        aaa = false;
        agent.destination = transform.position;
        StartCoroutine("wait");
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        aaa = true;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
               if (collision.transform.tag =="Student"){
            agent.destination = transform.position;
            StopCoroutine("a");

                 aaa = false;
                 StartCoroutine("a");

        Destroy(collision.transform.gameObject);
            

        }

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player"){
            SceneManager.LoadScene(2);
        } 
        if (other.transform.tag =="Student"){
            agent.destination = transform.position;
            StopCoroutine("a");
                 aaa = false;
                 StartCoroutine("a");
            //victim = collision.transform.gameObject;            
            Destroy(other.gameObject);

               }
    }
    // Update is called once per frame
    void Update()
    {
        //print(agent.remainingDistance);
        

        
        //print(agent.remainingDistance);
        //if aaa is true then start moving to the goal
        if (aaa){
        agent.destination = goal.position;
           // footsteps.volume = 1;
        chase.volume = 1-Mathf.Lerp(0, 1f, agent.remainingDistance /222f);
            ambience.volume = Mathf.Lerp(0, 1f, agent.remainingDistance / 590f);
        }
        else
        {
          //  footsteps.volume = 0;
            chase.volume -= 0.54321f * Time.deltaTime;
            ambience.volume = 1f;
        }
    }
}
