using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class followPlayer : MonoBehaviour
{
    [SerializeField] GameObject target;
    NavMeshAgent nav;
    public GameObject zarCanvas;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(target.transform.position);


        float fark = Vector3.Distance(target.transform.position, this.transform.position);

        if (fark <= 2f)
        {
            GetComponent<Animator>().SetTrigger("Attack");
        }
        else if (fark >= 2f)
        {
            GetComponent<Animator>().ResetTrigger("Attack");
        }



    }

}
