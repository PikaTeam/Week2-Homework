using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class Visibility : MonoBehaviour
    {
        private bool isVisible = false;

        private void OnMouseUpAsButton()
        {
            GetComponent<Renderer>().enabled = isVisible;
            isVisible = !isVisible;
        }
    }
}
