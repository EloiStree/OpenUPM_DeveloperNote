using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Note
{
    public class LinksNoteMono_Source : LinksNoteMono
    {
        [ContextMenu("Open Source")]
        public void OpenSource()
        {
            base.OpenLinks();
        }
    }
}