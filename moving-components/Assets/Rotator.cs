using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Rotator : MonoBehaviour
    {
        [Tooltip("Movement vector in meters per second")]
        [SerializeField] float speed = 90;

        [SerializeField] Vector3 rotationVector = new Vector3(0, 1, 0);

        void Update()
        {
            transform.Rotate(rotationVector, speed*Time.deltaTime);
        }

    }
}
