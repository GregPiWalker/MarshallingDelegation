﻿using System;

namespace Diversions.Mvvm
{
    /// <summary>
    /// This attribute is used to indicate that a change to the decorated property also
    /// causes a derived property's value to change. 
    /// See: https://docs.microsoft.com/en-us/archive/msdn-magazine/2010/july/design-patterns-problems-and-solutions-with-model-view-viewmodel
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public sealed class AffectsPropertyAttribute : Attribute
    {
        public AffectsPropertyAttribute(string affectedPropertyName)
        {
            AffectedProperty = affectedPropertyName;
        }

        public string AffectedProperty { get; private set; }
    }
}