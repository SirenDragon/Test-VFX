using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Animator theAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theAnimator = GetComponent<Animator>();
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (theAnimator = null)
        {
            Debug.Log("help bro i got no clue");
        }
    }
}
