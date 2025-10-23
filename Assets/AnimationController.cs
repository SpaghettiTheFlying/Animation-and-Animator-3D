using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Use these variables in the editor when the game is running to switch between animations
    public bool isWalking;
    public bool isRunning;

    private Animator anim;

    // We just get a reference for our animator here
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        // Here, update the Animator Controller parameters to match the booleans above.
    }
}
