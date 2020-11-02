using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Scaler : MonoBehaviour
    {

        [SerializeField] float maxScale = 2;
        [SerializeField] float minScale = 0.5f;

        private bool isExpanding = true;

        void Update()
        {
            float scaleTo = (isExpanding) ? maxScale : minScale;
            transform.localScale += new Vector3((scaleTo-1) * Time.deltaTime*3, (scaleTo-1) * Time.deltaTime*3, 0);
            if (isExpanding && transform.localScale.x >= maxScale)
                isExpanding = false;
            else if (!isExpanding && transform.localScale.x <= minScale)
                isExpanding = true;


        }

        

    }
}
