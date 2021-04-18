using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityEngine.AI;
using System.Collections;
public class OgreMove : MonoBehaviour
{
    
    public NavMeshAgent enemyAgent;
    public GameObject player;
    public Text lifeText;
    private int life = 3;

    private void Start()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);
        lifeText.text = "Lives: " + life;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            life -= 1;
            gameObject.GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(1);
            gameObject.GetComponent<Collider>().enabled = true;
            Debug.Log("Oh No!");

        }
    }
}

