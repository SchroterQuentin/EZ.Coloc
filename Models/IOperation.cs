using System;

namespace EZ.Coloc.Models
{
    public interface IOperation
    {
        DateTime OrderDate { get; set; }
        string Label { get; set; }

        float Value { get; set; }

        OperationType Type { get; set; }

        User User { get; set; }
    }
}