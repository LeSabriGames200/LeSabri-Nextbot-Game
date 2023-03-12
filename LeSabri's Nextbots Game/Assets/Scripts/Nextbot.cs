using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Nextbot : MonoBehaviour
{

    public NavMeshAgent NextbotThing;
    public Transform Player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NextbotThing.SetDestination(Player.position);
    }

    public void OnTriggerEnter() 
    {
        Debug.Log("You Died");
        SceneManager.LoadScene("SampleScene");
    }

}
