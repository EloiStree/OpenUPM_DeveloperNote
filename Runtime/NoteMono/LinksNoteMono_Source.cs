using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinksNoteMono_Source : LinksNoteMono
{
    [ContextMenu("Open Source")]
    public void OpenSource()
    {
        base.OpenLinks();
    }
}
