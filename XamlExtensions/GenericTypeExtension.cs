﻿using System;
using System.Windows.Markup;

namespace TreeNotes.XamlExtensions
{
    [MarkupExtensionReturnType(typeof(Type))]
    public class GenericTypeExtension : MarkupExtension
    {
        public GenericTypeExtension() { }

        public GenericTypeExtension(Type baseType, params Type[] innerTypes)
        {
            BaseType = baseType;
            InnerTypes = innerTypes;
        }

        public Type BaseType { get; set; }

        public Type[] InnerTypes { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            Type result = BaseType.MakeGenericType(InnerTypes);
            return result;
        }
    }
}
