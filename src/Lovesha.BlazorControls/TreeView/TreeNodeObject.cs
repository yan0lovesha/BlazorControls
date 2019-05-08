using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lovesha.BlazorControls.TreeView
{
    public class TreeNodeObject
    {
        public string Text { get; set; }
        public JToken NodeData { get; set; }
        public bool AlwaysReloadChildren { get; set; }
        public bool IsExpanded { get; set; }

        public List<TreeNodeObject> ChildNodes { get; set; } = new List<TreeNodeObject>();

        public Func<TreeNodeObject, Task<List<TreeNodeObject>>> LoadChildNodesFunc { get; set; }
    }
}