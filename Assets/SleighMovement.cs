using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleighMovement : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float objectSpeed;

    int nextPosIndex;
    Transform nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.position == nextPos.position)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (nextPosIndex < 3)
                {
                nextPosIndex++;
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (nextPosIndex > 0)
                {
                    nextPosIndex--;
                }
            }

            
            nextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, nextPos.position, objectSpeed * Time.deltaTime);
        }
    }
}

    