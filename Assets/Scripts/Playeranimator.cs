using UnityEngine;
using System.Collections;

public class Playeranimator : MonoBehaviour
{

    Animator player_animation;

    // Use this for initialization
    void Start()
    {
        player_animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool runcheck = Input.GetKey(KeyCode.LeftArrow);

        player_animation.SetBool("runcheck", runcheck);
    }

    
}