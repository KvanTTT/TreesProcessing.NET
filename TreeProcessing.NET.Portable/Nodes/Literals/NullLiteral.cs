﻿using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TreeProcessing.NET
{
    [NodeAttr(NodeType.NullLiteral)]
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class NullLiteral : Terminal
    {
        public override NodeType NodeType => NodeType.NullLiteral;

        public NullLiteral()
        {
        }

        public override int CompareTo(Node other)
        {
            return base.CompareTo(other);
        }

        public override string ToString()
        {
            return "null";
        }
    }
}