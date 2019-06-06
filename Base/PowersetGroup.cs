﻿using System;
using System.Collections.Generic;

// Token: 0x02000090 RID: 144
public class PowersetGroup : IComparable
{
    
    public string Name { get; private set; }
    public IDictionary<string, IPowerset> Powersets { get; private set; }
    public PowersetGroup(string name)
    {
        this.Name = name;
        this.Powersets = new Dictionary<string, IPowerset>();
    }
    public int CompareTo(object obj)
    {
        PowersetGroup powersetGroup = obj as PowersetGroup;
        if (powersetGroup != null)
        {
            return string.Compare(this.Name, powersetGroup.Name, StringComparison.OrdinalIgnoreCase);
        }
        throw new ArgumentException("Comparison failed - Passed object was not an Archetype Class!");
    }
}
