using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class BehaviourTest
{
#if UNITY_EDITOR_WIN || (UNITY_STANDALONE_WIN && !UNITY_EDITOR)
    public string test = "blah";
#endif
#if UNITY_EDITOR_LINUX || (UNITY_STANDALONE_LINUX && !UNITY_EDITOR)
    public string test = "blah";
#endif
}
