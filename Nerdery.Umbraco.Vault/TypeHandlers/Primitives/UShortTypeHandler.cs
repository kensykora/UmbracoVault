﻿using System;

namespace Nerdery.Umbraco.Vault.TypeHandlers.Primitives
{
    public class ushortTypeHandler : ITypeHandler
    {
        private object Get(string stringValue)
        {
            ushort result;

            ushort.TryParse(stringValue, out result);

            return result;
        }

        public object GetAsType<T>(object input)
    	{
			return Get(input.ToString());
    	}
        
        public Type TypeSupported
        {
            get { return typeof (ushort); }
        }
    }
}
