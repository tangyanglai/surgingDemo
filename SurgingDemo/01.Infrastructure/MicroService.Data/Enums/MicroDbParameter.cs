﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace MicroService.Data.Enums
{
    public class MicroDbParameter : DbParameter, ICloneable
    {

       public MicroDbParameter(string parameterName, object value)
        {

        }
        public override DbType DbType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ParameterDirection Direction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool IsNullable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ParameterName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Size { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string SourceColumn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override bool SourceColumnNullMapping { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override object Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override void ResetDbType()
        {
            throw new NotImplementedException();
        }
    }
}
