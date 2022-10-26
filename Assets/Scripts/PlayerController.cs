using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Handling all movement of the box that will be used to catch objects
/// </summary>
public class PlayerController : MonoBehaviour
{
    #region Controller Variables
    [Header("Player Speeds")]
    [SerializeField] float speed = 10f;

    float horizontalMovement;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
    }


    #region Basic Movement
    void HorizontalMovement()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * horizontalMovement * speed * Time.deltaTime);
    }

    #endregion
}
