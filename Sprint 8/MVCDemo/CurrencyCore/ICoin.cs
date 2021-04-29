using System;
using System.Runtime.Serialization;

namespace Currency
{
    
    public interface ICoin : ICurrency, ISerializable
    {
        int Year { get; set; }
    }
}