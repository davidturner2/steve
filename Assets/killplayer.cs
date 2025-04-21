using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class killplayer : MonoBehaviour
{
     public Transform goal;
    NavMeshAgent agent;
    public bool aaa = true;
    public bool n = true;

    // Start is called before the first frame update
    void Awake()
    {
        //set goal to the transform position
        // get the navmesh ageny
        agent = GetComponent<NavMeshAgent>();
        n = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player"){
            SceneManager.LoadScene(1);
        } 
    }
    // Update is called once per frame
    void Update()
    {
        if ( agent.remainingDistance <= 0 && aaa && n){
         
        }

        
        //print(agent.remainingDistance);
        //if aaa is true then start moving to the goal
        if (aaa){
        agent.destination = goal.position;
        }
    }
}
