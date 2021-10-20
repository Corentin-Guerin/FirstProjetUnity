using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private Transform playerTransform { get; set; } = null ;

        //variable 
    public Transform _eyeTransform = null ;
    public bool _invertCamera = false ;
        //propriete ( get et set sur la propriete)
    private Transform eyeTransform { get { return _eyeTransform; } set { _eyeTransform = value; } }
    private bool invertCamera { get { return _invertCamera; } set { _invertCamera = value; } }

        //permet a selement ce scrip de modifier la valeur de la variable (inverse entre private et public impossible)
        //public int valeur { get; private set;} ;

        // Start is called before the first frame update
    private void Start()
    {
        playerTransform = transform ;
    }

        // Update is called once per frame
    private void Update()
    {
        playerTransform.Rotate(Vector3.up,Input.GetAxis("Mouse X")) ;
        float invertValue = invertCamera == true ? 1:-1 ;
        eyeTransform.Rotate(Vector3.right,Input.GetAxis("Mouse Y")*invertValue) ;
    }
}
