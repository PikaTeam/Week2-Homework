using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Oscilliator1D : MonoBehaviour
    {
        public float distance = 3;

        private Vector3 origin;

        void Start()
        {
            this.origin = transform.position;
        }
        void Update()
        {
            transform.position = new Vector3(origin.x+Mathf.Sin(Mathf.Abs(transform.position.x - origin.x)+3),origin.y,origin.z);  
        }
    }
}
