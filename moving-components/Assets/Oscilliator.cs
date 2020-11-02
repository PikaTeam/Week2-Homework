using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Oscilliator : MonoBehaviour
    { 
        [SerializeField] float radius = 5;
        [SerializeField] double angleOrigin = -90;
        [SerializeField] float speed = 90;
        [SerializeField] double maxRotatedAngle = 75;
        [SerializeField] Vector3 directionAngle = new Vector3(0,0,0);

        private double angle = 0;
        private bool isGoingRight = true;
        private Vector3 origin;

        void Start()
        {
            this.origin = transform.position;
           
        }

        void Update()
        {
            
            float currSpeed = -(float)((Math.Cos(angle * Math.PI / 180 )-Math.Cos((maxRotatedAngle+1) * Math.PI / 180)) * speed);

            if (isGoingRight)
            {
                angle -= currSpeed * Time.deltaTime;


                if (angle > maxRotatedAngle)
                    isGoingRight = false;
            } 
            else
            {
                angle += currSpeed * Time.deltaTime;

                if (angle < -maxRotatedAngle)
                    isGoingRight = true;
            }

            Vector3 v = new Vector3(
                (float)(origin.x + radius * Math.Cos((angleOrigin + angle) * Math.PI / 180)),
                (float)(origin.y + radius * Math.Sin((angleOrigin + angle) * Math.PI / 180)),
                origin.z
            );


            transform.position = v;
          

        }

    }
}
