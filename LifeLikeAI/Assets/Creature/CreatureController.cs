using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    Brain brain = new Brain();
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        WalkAction action = (WalkAction) brain.getNextAction();

        Vector2 position = rigidbody.position;
        position.x += (float) action.getLeft();
        position.y += (float) action.getTop();

        rigidbody.MovePosition(position);
    }
}
