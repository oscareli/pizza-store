using System;
using System.Runtime.Serialization;

namespace PizzaStore.ApplicationCore.Entities
{
    public enum PersonalizacaoEnum
    {
        [EnumMember(Value = "extra bacon")]
        ExtraBacon = 0,

        [EnumMember(Value = "sem cebola")]
        SemCebola = 1,

        [EnumMember(Value = "borda recheada")]
        BordaRecheada = 2
    }
}
