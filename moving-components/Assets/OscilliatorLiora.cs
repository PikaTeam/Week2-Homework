using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets
{
    class OscilliatorLiora : MonoBehaviour
    {
        public int speed = 1024;
        public float distance = 3;
        private Vector3 origin;


        void Start()
        {
            this.origin = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 currentPosition = transform.position;
            int count = Time.frameCount;
            int numberofPoints = 1024/speed;

            float xvalue = distance * Mathf.Sin((float)(count % numberofPoints) / (float)numberofPoints * 2 * Mathf.PI);
            float yvalue = distance * Mathf.Abs(Mathf.Sin((float)(count % numberofPoints) / (float)numberofPoints * 2 * Mathf.PI));
            currentPosition.x = origin.x + xvalue;
            //currentPosition.y = yvalue;
            transform.position = currentPosition;
        }
    }
}
