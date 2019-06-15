using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator m_Animator;
    Vector3 m_Movement;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
      float vertical = Input.GetAxis("Vertical");

      m_Movement.Set(horizontal, 0f, vertical);
      m_Movement.Normalize();

      bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
      bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
      bool isWalking = hasHorizontalInput || hasVerticalInput;
    }
}
