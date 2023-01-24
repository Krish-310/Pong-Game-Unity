using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ScoringZone : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    public void OnCollisonEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");
        scoreTrigger.Invoke();
        
    }
}


