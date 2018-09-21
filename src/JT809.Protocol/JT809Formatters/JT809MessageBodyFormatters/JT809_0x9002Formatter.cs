﻿using JT809.Protocol.JT809Enums;
using JT809.Protocol.JT809Extensions;
using JT809.Protocol.JT809MessageBody;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace JT809.Protocol.JT809Formatters.JT809MessageBodyFormatters
{
    public class JT809_0x9002Formatter : IJT809Formatter<JT809_0x9002>
    {
        public JT809_0x9002 Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JT809_0x9002 jT809_0X9002 = new JT809_0x9002();
            jT809_0X9002.Result = (JT809_0x9002_Result)JT809BinaryExtensions.ReadByteLittle(bytes, ref offset);
            readSize = offset;
            return jT809_0X9002;
        }

        public int Serialize(IMemoryOwner<byte> memoryOwner, int offset, JT809_0x9002 value)
        {
            offset += JT809BinaryExtensions.WriteByteLittle(memoryOwner, offset, (byte)value.Result);
            return offset;
        }
    }
}
